using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;
using Cine__backend.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private AppDbContext _context;
        public ReservationRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void AddReservation(Reservation reservation)
        {
            reservation.Id = Guid.NewGuid();
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            return;
        }

        public Reservation GetReservation(Guid reservationId)
        {
            var reservation = _context.Reservations.Find(reservationId);
            if(reservation == null)
            {
                throw new KeyNotFoundException("No se encuentra la reservación especificada");
            }
            return reservation;
        }

        public IList<Reservation> GetReservationsFromFilmScreening(Guid filmScreeningId)
        {
            if(_context.FilmScreenings.Find(filmScreeningId)==null)
            {
                throw new KeyNotFoundException("No se encuentra la puesta en escena especificada");
            }
            var reservations = _context.Reservations.Where(c => c.FilmScreeningId == filmScreeningId);
            return reservations.ToList();
        }

        public void RemoveReservation(Guid reservationId)
        {
            var reservation = _context.Reservations.Find(reservationId);
            if (reservation == null)
            {
                throw new KeyNotFoundException("No se encuentra la reservación especificada");
            }
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
            return;
        }

        public async Task<IList<DTOReservationStatistics>> GetStatistics()
        {
            var statistics = new List<DTOReservationStatistics>();
            foreach(var reservation in await _context.Reservations.ToListAsync())
            {
                var dtoSt = new DTOReservationStatistics();
                var filmscreening = await _context.FilmScreenings.FindAsync(reservation.FilmScreeningId);
                dtoSt.ReservationDate = filmscreening.Date;
                var film = await _context.Films.FindAsync(filmscreening.FilmId);
                dtoSt.Country = film.Country;
                dtoSt.Year = film.Year;
                dtoSt.FilmName = film.Name;
                dtoSt.Img = film.Img;
                dtoSt.ImgPath = film.ImgPath;
                dtoSt.Actors = new List<string>();
                var count = 0;
                var rating = 0;
                foreach (var userFilm in _context.UserFilms.Where(c => c.FilmId == film.Id))
                {
                    count++;
                    rating += userFilm.Rating;
                }
                dtoSt.Rating = count == 0 ? 0 : (int)(rating / count);
                var actors_staff = await _context.FilmFilmRols.Include(c => c.FilmRol)
                            .Where(c => c.FilmId == film.Id && c.FilmRol.Name == "Actor")
                            .ToListAsync();
                foreach (var actor in actors_staff)
                    dtoSt.Actors.Add(actor.MemberRol);
                dtoSt.Genres = await _context.FilmGenres.Include(c => c.Genre)
                        .Where(c => c.FilmId == film.Id)
                        .Select(c => c.Genre).ToListAsync();
                statistics.Add(dtoSt);
            }
            return statistics;
        }
    }
}
