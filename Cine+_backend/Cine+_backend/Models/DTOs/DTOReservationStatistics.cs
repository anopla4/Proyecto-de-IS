using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOReservationStatistics
    {
        public Guid FilmId { get; set; }
        public string FilmName { get; set; }
        public string Year { get; set; }
        public string Country { get; set; }
        public string ImgPath { get; set; }
        public IFormFile Img { get; set; }
        public List<Genre> Genres {get; set;}
        public List<string> Actors { get; set; }
        public int Rating { get; set; }
        public DateTime ReservationDate { get; set; } 

    }
}
