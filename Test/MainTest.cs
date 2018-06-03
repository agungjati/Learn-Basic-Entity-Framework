using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Models
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Member member = new Member();
            member.Id = 1;
            member.nama = "Agung Jati";
            member.Umur = 10;
            member.Alamat = "Tanjung Uma, Lubuk Baja";


        }
    }
}
