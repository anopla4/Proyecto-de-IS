using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.EntityFrameworkCore;
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
        public ClubMember AddClubMember(string userId, ClubMember clubMember)
        {
            if(_context.ClubMembers.Find(userId) != null)
            {
                throw new InvalidOperationException("Este usuario ya es miembro");
            }
            clubMember.UserId = userId;
            _context.ClubMembers.Add(clubMember);
            _context.SaveChanges();
            return clubMember;
        }

        public ClubMember GetClubMember(string userId)
        {
            if (_context.Users.Find(userId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            var clubMember = _context.ClubMembers.Find(userId);
            if (clubMember == null)
            {
                throw new KeyNotFoundException("El usuario especificado no es miembro");
            }
            return clubMember;           
        }

        public IList<ClubMember> GetClubMembers()
        {
            return _context.ClubMembers.Include(x => x.User).ToList();
        }

        public void RemoveClubMember(string userId)
        {
            if (_context.Users.Find(userId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            var clubMember = _context.ClubMembers.Find(userId);
            if (clubMember == null)
            {
                throw new KeyNotFoundException("El usuario especificado no es miembro");
            }
            _context.ClubMembers.Remove(clubMember);
            _context.SaveChanges();
            return;
        }

        public ClubMember UpdateClubMember(ClubMember clubMember)
        {
            var currClubMember = _context.ClubMembers.Find(clubMember.UserId);
            if (currClubMember == null)
            {
                throw new KeyNotFoundException("No se encuentra el miembro especificado");
            }
            currClubMember.Name = clubMember.Name;
            currClubMember.DateOfBirth = clubMember.DateOfBirth;
            currClubMember.Nationality = clubMember.Nationality;
            currClubMember.Points = clubMember.Points;
            _context.ClubMembers.Update(currClubMember);
            _context.SaveChanges();
            return currClubMember;
        }
    }
}
