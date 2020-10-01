using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfClub.Model;

namespace GolfClub.DAL
{
    public class ClubMemberDbManager
    {
        public Member CreateMember(Member memberModal)
        {
            using (var dbEntities = new GolfClubContext())
            {
                var MemberObj = new Member()
                {
                    Name = memberModal.Name,
                    Gender = memberModal.Gender,
                    MemberFee = memberModal.MemberFee,
                };
                dbEntities.Members.Add(MemberObj);
                dbEntities.SaveChanges();
            }
            return memberModal;
        } 
        }
}