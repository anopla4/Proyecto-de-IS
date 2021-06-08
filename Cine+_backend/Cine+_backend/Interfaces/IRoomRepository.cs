using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IRoomRepository
    {
        public List<Room> GetRooms();
        public Room GetRoom(Guid roomId);
        public Room AddRoom(Room room);
        public Room UpdateRoom(Room room);
        public void DeleteRoom(Guid roomId);
    }
}
