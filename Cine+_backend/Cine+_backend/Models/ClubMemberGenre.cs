using System;

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
