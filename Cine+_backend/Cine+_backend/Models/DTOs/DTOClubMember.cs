using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOClubMember
    {
        public ClubMember ClubMember { get; set; }
        public List<Genre> FavouriteGenres { get; set; }
    }
}
