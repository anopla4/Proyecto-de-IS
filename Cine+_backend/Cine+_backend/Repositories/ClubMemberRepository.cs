using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class ClubMemberRepository : IClubMemberRepository
    {
        private AppDbContext _context;
        public ClubMemberRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void AddClubMember(string userId, ClubMember clubMember)
        {
            throw new NotImplementedException();
        }

        public ClubMember GetClubMember(string clubMemberId)
        {
            throw new NotImplementedException();
        }

        public IList<ClubMember> GetClubMembers()
        {
            throw new NotImplementedException();
        }

        public void RemoveClubMember(string userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateClubMember(ClubMember clubMember)
        {
            throw new NotImplementedException();
        }
    }
}
