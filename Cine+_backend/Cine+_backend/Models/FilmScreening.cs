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

    }
}
