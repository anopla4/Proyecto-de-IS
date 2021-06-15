using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
