using System;
using System.Collections.Generic;
using System.Linq;
using WinePusher.Models;

namespace WinePusher.BusinessLogic
{
    class MemberHandler
    {
        winepusherEntities wpe = new winepusherEntities();

        public MemberHandler()
        {
        }

        public List<MemberListItem> ListMembers()
        {
            List<MemberListItem> memberList = wpe.members.Select(m => new MemberListItem() { Id = m.Id, Name = m.Name }).ToList();
           
           return memberList;
        }
    }
}