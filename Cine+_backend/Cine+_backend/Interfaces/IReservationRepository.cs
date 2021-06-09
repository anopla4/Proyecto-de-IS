using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IReservationRepository
    {
        Reservation GetReservation(Guid reservationId);
        IList<Reservation> GetReservationsFromFilmScreening(Guid filmScreeningId);
        void AddReservation(Reservation reservation);
        void RemoveReservation(Guid reservationId);
    }
}
