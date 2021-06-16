using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class FilmScreeningRepository: IFilmScreeningRepository
    {
        private AppDbContext _context;
        public FilmScreeningRepository(AppDbContext context)
        {
            _context = context;
        }

        public FilmScreening AddFilmScreening(FilmScreening filmScreening, List<DTOPriceModificationId> priceModificationsIds)
        {
            filmScreening.Id = Guid.NewGuid();
            if (filmScreening.Time.Length > 8 || int.Parse(filmScreening.Time.Split(":")[0]) > 12 || int.Parse(filmScreening.Time.Split(":")[1].Split()[0]) > 59 || (filmScreening.Time.Split(":")[1].Split()[1] != "AM" && filmScreening.Time.Split(":")[1].Split()[1] != "PM"))
                throw new FormatException($"La hora {filmScreening.Time} para la puesta en escena no es válida");
            foreach(var priceModificationId in priceModificationsIds)
            {
                var priceModification = _context.PriceModifications.Find(priceModificationId.Id);
                if (priceModification == null)
                {
                    throw new KeyNotFoundException($"No se encuentra la modificación de precios {priceModificationId.Id}");
                }
                _context.FilmScreeningPriceModifications.Add(new FilmScreeningPriceModification { FilmScreeningId = filmScreening.Id, PriceModificationId = priceModificationId.Id, Optional = priceModificationId.Optional });
            }
            _context.FilmScreenings.Add(filmScreening);
            _context.SaveChanges();
            return filmScreening;
        }

        public void RemoveFilmScreening(Guid filmScreeningId)
        {
            var currFilmScreening = _context.FilmScreenings.Find(filmScreeningId);
            if (currFilmScreening == null)
            {
                throw new KeyNotFoundException("No se encuntra la puesta en escena especificada");
            }
            _context.FilmScreenings.Remove(currFilmScreening);
            _context.SaveChanges();
            return;
        }

        public DTOFilmScreening GetFilmScreening(Guid filmScreeningId)
        {
            var filmScreening = _context.FilmScreenings.Include(c => c.Film).Include(c => c.Room).SingleOrDefault(c => c.Id == filmScreeningId);
            if (filmScreening == null)
            {
                throw new KeyNotFoundException("No fue encontrada la puesta en escena especificada");
            }
            List<Genre> genres = _context.FilmGenres.Include(c => c.Genre).Where(c => c.FilmId == filmScreening.FilmId).Select(c => c.Genre).ToList();
            List<DTOPriceModification> priceModifications = new List<DTOPriceModification>();
            foreach(var priceModification in _context.FilmScreeningPriceModifications.Include(c => c.PriceModification).Where(c => c.FilmScreeningId == filmScreeningId))
            {
                priceModifications.Add(new DTOPriceModification { PriceModification = priceModification.PriceModification, Optional = priceModification.Optional });
            }
            DTOFilmScreening filmScreeningDTO = new DTOFilmScreening { FilmScreeningId = filmScreeningId, Film = new DTOFilm { Film = filmScreening.Film, Genres = genres }, Room = filmScreening.Room, StartTime = filmScreening.Time, priceModifications = priceModifications, Date = filmScreening.Date };
            return filmScreeningDTO;
        }

        public List<DTOFilmScreening> GetFilmScreenings()
        {
            var filmsSreenings = _context.FilmScreenings.Include(c => c.Film).Include(c => c.Room).ToList();
            List<DTOFilmScreening> filmScreeningsDTO = new List<DTOFilmScreening>();
            foreach(var filmScreening in filmsSreenings)
            {
                List<Genre> genres = _context.FilmGenres.Include(c => c.Genre).Where(c => c.FilmId == filmScreening.FilmId).Select(c => c.Genre).ToList();
                List<DTOPriceModification> priceModifications = new List<DTOPriceModification>();
                foreach (var priceModification in _context.FilmScreeningPriceModifications.Include(c => c.PriceModification).Where(c => c.FilmScreeningId == filmScreening.Id))
                {
                    priceModifications.Add(new DTOPriceModification { PriceModification = priceModification.PriceModification, Optional = priceModification.Optional });
                }
                filmScreeningsDTO.Add(new DTOFilmScreening { FilmScreeningId = filmScreening.Id, Film = new DTOFilm { Film = filmScreening.Film, Genres = genres }, Room = filmScreening.Room, StartTime = filmScreening.Time, priceModifications = priceModifications, Date = filmScreening.Date});
            }
            return filmScreeningsDTO;
        }

        public FilmScreening UpdateFilmScreening(FilmScreening filmScreening, List<DTOPriceModificationId> priceModificationsIds)
        {
            var currFilmScreening = _context.FilmScreenings.Find(filmScreening.Id);
            if (currFilmScreening == null)
            {
                throw new KeyNotFoundException("No se encuntra la puesta en escena especificada");
            }
            currFilmScreening.FilmId = filmScreening.FilmId;
            currFilmScreening.RoomId = filmScreening.RoomId;
            if (filmScreening.Time.Length > 8 || int.Parse(filmScreening.Time.Split(":")[0]) > 12 || int.Parse(filmScreening.Time.Split(":")[1].Split()[0]) > 59 || (filmScreening.Time.Split(":")[1].Split()[1] != "AM" && filmScreening.Time.Split(":")[1].Split()[1] != "PM"))
                throw new FormatException($"La hora {filmScreening.Time} de la puesta en escena no es válida");
            currFilmScreening.Time = filmScreening.Time;
            foreach(var priceModification in _context.FilmScreeningPriceModifications.Where(c => c.FilmScreeningId == filmScreening.Id).ToList())
            {
                _context.FilmScreeningPriceModifications.Remove(priceModification);
            }
            foreach (var priceModificationId in priceModificationsIds)
            {
                var priceModification = _context.PriceModifications.Find(priceModificationId.Id);
                if (priceModification == null)
                    throw new KeyNotFoundException($"No se encuentra la modificación de precio con id = {priceModificationId.Id}");
                _context.FilmScreeningPriceModifications.Add(new FilmScreeningPriceModification { FilmScreeningId = filmScreening.Id, PriceModificationId = priceModification.Id, Optional = priceModificationId.Optional});
            }
            _context.FilmScreenings.Update(currFilmScreening);
            _context.SaveChanges();
            currFilmScreening = _context.FilmScreenings.Include(c => c.Film).Include(c => c.Room).SingleOrDefault(c => c.Id == filmScreening.Id);
            return currFilmScreening;
        }

        public List<DTOSeat> GetSeats(Guid filmId, DateTime date, string time)
        {
            var filmScreeningsRoomsIDs = _context.FilmScreenings.Where(c => c.FilmId == filmId && c.Date == date && c.Time == time).Select(c => c.RoomId).ToList();
            if (filmScreeningsRoomsIDs.Count() == 0)
                throw new KeyNotFoundException($"No se encuentra una puesta en escena para la película seleccionada el día {date} a las {time}");
            List<SeatSectionLevelRoom> seats = _context.SeatSectionLevelRooms.Include(c => c.Room).Include(c => c.Section).Include(c => c.Level).Include(c => c.Seat).Where(c => filmScreeningsRoomsIDs.Contains(c.RoomId)).ToList();
            List<DTOSeat> seatsDTO = new List<DTOSeat>();

            foreach(var seat in seats)
            {
                seatsDTO.Add(new DTOSeat { Room = seat.Room, Level = seat.Level, Section = seat.Section, Seat = seat.Seat, Available = !(_context.Reservations.Any(c => c.FilmScreening.FilmId == filmId && c.FilmScreening.Date == date && c.FilmScreening.Time == time && c.SeatSeatId == seat.SeatId)) });
            }
            return seatsDTO;
        }
    }
}
