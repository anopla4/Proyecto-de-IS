using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class SeatRepository : ISeatRepository
    {
        private AppDbContext _context;
        public SeatRepository(AppDbContext context)
        {
            _context = context;
        }
        public Seat AddSeat(Seat seat)
        {
            seat.Id = Guid.NewGuid();
            _context.Seats.Add(seat);
            _context.SaveChanges();
            return seat;
        }

        public Seat GetSeat(Guid seatId)
        {
            var seat = _context.Seats.Find(seatId);
            if (seat == null)
            {
                throw new KeyNotFoundException("No se encuentra el asiento especificado");
            }
            return seat;
        }

        public IList<Seat> GetSeats()
        {
            return _context.Seats.ToList();
        }

        public void RemoveSeat(Guid seatId)
        {
            var seat = _context.Seats.Find(seatId);
            if (seat == null)
            {
                throw new KeyNotFoundException("No se encuentra el asiento especificado");
            }
            _context.Seats.Remove(seat);
            _context.SaveChanges();
            return;
        }
    }
}
