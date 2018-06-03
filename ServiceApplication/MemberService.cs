using Connnection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication
{
    public class MemberService
    {
        protected MyContext ctx;
        public Member Member;
        public MemberService()
        {
            ctx = new MyContext();
            Member = new Member();
        }
        public MyContext ContextNya
        {
            get
            {
                if (ctx == null)
                    ctx = new MyContext();

                return ctx;
            }
        }
        public void Save(Member mmb)
        {
            using (ctx)
            {
                ctx.Members.Add(mmb);
                var result = ctx.SaveChanges();
                Assert.IsTrue(result > 0);
                Console.WriteLine("GAME SUCCESS.");
                Console.ReadLine();
            }
        }

        public Member UpdateFind(int Id)
        {
            using (ctx)
            {
                var updfind = ctx.Members.Where(s => s.Id == 4).FirstOrDefault();
                return updfind;
            }
        }
       public void Update(Member Mmb)
        {
            using (ctx = new MyContext())
            {
                ctx.Entry(Mmb).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        //public void update()
        //{
        //    Member.Id = 4;
        //    var cc = ctx.Members.Find(Member.Id);
        //    cc.nama = "aaaaaa";
        //    cc.Alamat = "wwasda";
        //    cc.Umur = 10;
        //    ctx.SaveChanges();
        //    Console.WriteLine("Success");
        //    Console.ReadLine();
        //}

    }
}
