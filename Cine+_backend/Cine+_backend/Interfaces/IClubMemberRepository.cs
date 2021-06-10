﻿using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IClubMemberRepository
    {
        ClubMember GetClubMember(string userId);
        IList<ClubMember> GetClubMembers();
        void AddClubMember(string userId, ClubMember clubMember);
        void UpdateClubMember(ClubMember clubMember);
        void RemoveClubMember(string userId);
    }
}
