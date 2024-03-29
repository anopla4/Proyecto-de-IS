﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cine__backend.Models
{
    public class Reservation : Item
    {
        [ForeignKey("FilmScreening")]
        public Guid FilmScreeningId { get; set; }
        public FilmScreening FilmScreening { get; set; }
        public Guid? SeatSeatId { get; set; }
        public Guid? SeatSectionId { get; set; }
        public Guid? SeatLevelId { get; set; }
        public Guid? SeatRoomId { get; set; }
        [ForeignKey("SeatSeatId, SeatSectionId, SeatLevelId, SeatRoomId")]
        public SeatSectionLevelRoom Seat { get; set; }
    }
}
