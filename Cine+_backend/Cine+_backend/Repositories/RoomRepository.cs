using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;

namespace Cine__backend.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private AppDbContext _context;

        public RoomRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Room AddRoom(Room room)
        {
            room.Id = Guid.NewGuid();
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return room;
        }

        public void DeleteRoom(Guid roomId)
        {
            var oldRoom = _context.Rooms.Find(roomId);
            if(oldRoom is null)
            {
                throw new KeyNotFoundException($"No se encuentra la Sala especificada con id:{roomId}.");
            }
            _context.Rooms.Remove(oldRoom);
            _context.SaveChanges();
        }

        public Room GetRoom(Guid roomId)
        {
            var room = _context.Rooms.Find(roomId);
            if(room is null)
            {
                throw new KeyNotFoundException($"No se encuentra la Sala especificada con id:{roomId}.");
            }
            return room;
        }

        public List<Room> GetRooms()
        {
            return _context.Rooms.ToList();
        }

        public Room UpdateRoom(Room room)
        {
            var oldRoom = _context.Rooms.Find(room.Id);
            if(oldRoom is null)
            {
                throw new KeyNotFoundException($"No se encuentra la Sala especificada con id:{room.Id}.");
            }
            oldRoom.Name = room.Name;
            _context.Rooms.Update(oldRoom);
            _context.SaveChanges();
            return oldRoom;
        }
    }
}
