using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface ISeatRepository
    {
        IList<Seat> GetSeats();
        Seat GetSeat(Guid seatId);
        Seat AddSeat();
        void RemoveSeat(Guid seatId);
    }
}
