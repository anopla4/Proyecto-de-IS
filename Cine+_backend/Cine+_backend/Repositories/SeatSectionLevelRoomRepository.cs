using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;

namespace Cine__backend.Repositories
{
    public class SeatSectionLevelRoomRepository : ISeatSectionLevelRoomRepository
    {
        private AppDbContext _context;
        public SeatSectionLevelRoomRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void AddSeatSectionLevelRoom(Guid seatId,Guid sectionId,Guid levelId,Guid roomId)
        {
            if(_context.Seats.Find(seatId)== null)
            {
                throw new KeyNotFoundException("No se encuentra el asiento especificado");
            }
            if (_context.Sections.Find(sectionId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la sección especificada");
            }
            if (_context.Levels.Find(levelId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el nivel especificado");
            }
            if (_context.Rooms.Find(roomId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la sala especificada");
            }
            if (_context.SeatSectionLevelRooms.Find(seatId,sectionId, levelId, roomId) != null)
            {
                throw new InvalidOperationException("Ya existe un asiento en la sección, el nivel y la sala especificadas");
            }
            var newSeatSectionLevelRoom = new SeatSectionLevelRoom { SeatId = seatId, SectionId = sectionId, 
                                                                    LevelId = levelId, RoomId = roomId };
            _context.SeatSectionLevelRooms.Add(newSeatSectionLevelRoom);
            _context.SaveChanges();
            return;
        }

        public IList<SeatSectionLevelRoom> GetAllSeatSectionLevelRoom()
        {
            return _context.SeatSectionLevelRooms.ToList();
        }

        public SeatSectionLevelRoom GetSeatSectionLevelRoom(Guid seatId,Guid sectionId,Guid levelId,Guid roomId)
        {
            if (_context.Seats.Find(seatId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el asiento especificado");
            }
            if (_context.Sections.Find(sectionId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la sección especificada");
            }
            if (_context.Levels.Find(levelId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el nivel especificado");
            }
            if (_context.Rooms.Find(roomId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la sala especificada");
            }
            var seatSectionLevelRoom = _context.SeatSectionLevelRooms.Find(seatId, sectionId, levelId, roomId);
            if (seatSectionLevelRoom == null)
            {
                throw new InvalidOperationException("No existe un asiento en la sección, el nivel y la sala especificadas");
            }
            return seatSectionLevelRoom;
        }

        public void RemoveSeatSectionLevelRoom(Guid seatId, Guid sectionId, Guid levelId, Guid roomId)
        {
            if (_context.Seats.Find(seatId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el asiento especificado");
            }
            if (_context.Sections.Find(sectionId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la sección especificada");
            }
            if (_context.Levels.Find(levelId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el nivel especificado");
            }
            if (_context.Rooms.Find(roomId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la sala especificada");
            }
            var seatSectionLevelRoom = _context.SeatSectionLevelRooms.Find(seatId, sectionId, levelId, roomId);
            if (seatSectionLevelRoom == null)
            {
                throw new InvalidOperationException("No existe un asiento en la sección, el nivel y la sala especificadas");
            }
            _context.SeatSectionLevelRooms.Remove(seatSectionLevelRoom);
            _context.SaveChanges();
            return;
        }
    }
}
