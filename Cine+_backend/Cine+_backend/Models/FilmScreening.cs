using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmScreening
    {
        public FilmScreening()
        {
            this.Points = 20;
            this.Price = 20.00;
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [ForeignKey("Room")]
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        [Required]
        [ForeignKey("Film")]
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        [Range(0,10000.00,ErrorMessage = "El precio de la puesta en escena está fuera del rango permitido(0,10000.00)")]
        public double Price { get; set; }
        [Required]
        [Range(0,100, ErrorMessage = "El precio de la puesta en escena en puntos está fuera del rango permitido(0,100)")]
        public double Points { get; set; }

    }
}
