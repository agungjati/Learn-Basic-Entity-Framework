using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApplication;
using Models;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemberService a = new MemberService();
            //var member = a.Member;
            //member.Id = 111;
            //member.nama = "gung";
            //member.Alamat = "tg uma";
            //member.Umur = 10;
            //a.Save(member);

            MemberService Service = new MemberService();
            
            var MemberUpdate = Service.UpdateFind(4);
            MemberUpdate.nama = "Agung";
            MemberUpdate.Alamat = "Tg Umaaa";
            MemberUpdate.Umur = 11;
            Service.Update(MemberUpdate);
            //MemberService aa = new MemberService();
            //aa.update();
           

        }
    }
}
