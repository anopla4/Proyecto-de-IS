using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class ClubMemberGenre
    {
        public Guid ClubMemberId { get; set; }
        public ClubMember ClubMember { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
