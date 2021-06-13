using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOFilmStatics
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Country { get; set; }
        public string ImgPath { get; set; }
        public IFormFile Img { get; set; }
        public int Rating { get; set; }
        public int TimesSeen { get; set; }
    }
}
