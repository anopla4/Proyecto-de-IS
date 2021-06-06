using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmFilmStaffMemberFilmRol
    {
        [ForeignKey("Film")]
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        [ForeignKey("FilmStaffMember")]
        public Guid FilmStaffMemberId { get; set; }
        public FilmStaffMember FilmStaffMember { get; set; }
        [ForeignKey("FilmRol")]
        public Guid FilmRolId { get; set; }
        public FilmRol FilmRol { get; set; }
    }
}
