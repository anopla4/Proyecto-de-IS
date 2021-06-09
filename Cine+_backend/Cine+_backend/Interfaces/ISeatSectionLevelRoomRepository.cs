using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface ISeatSectionLevelRoomRepository
    {
        SeatSectionLevelRoom GetSeatSectionLevelRoom(Guid seatId, Guid sectionId, Guid levelId, Guid roomId);
        IList<SeatSectionLevelRoom> GetAllSeatSectionLevelRoom();
        void AddSeatSectionLevelRoom(Guid seatId, Guid sectionId, Guid levelId, Guid roomId);
        void RemoveSeatSectionLevelRoom(Guid seatId, Guid sectionId, Guid levelId, Guid roomId);

    }
}
