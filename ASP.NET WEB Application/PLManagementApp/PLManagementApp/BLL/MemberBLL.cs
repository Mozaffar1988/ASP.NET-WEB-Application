using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PLManagementApp.DLL.GateWay;

namespace PLManagementApp.BLL
{
    public class MemberBLL
    {
        private MemberGateWay aMemberGateWay;

        public MemberBLL()
        {
            aMemberGateWay = new MemberGateWay();
        }

        public bool FindMemberById(int memberNumber)
        {
          return aMemberGateWay.FindMemberById(memberNumber);
        }

        public bool GetMemberNumber(int memberNumber)
        {
          return aMemberGateWay.GetMemberNumber(memberNumber);
        }
    }
}