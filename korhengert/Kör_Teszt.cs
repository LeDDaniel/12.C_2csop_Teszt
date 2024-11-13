using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using korhenger;
namespace korhengert
{
    [TestClass]
    public class Kör_Teszt
    {
        [TestMethod]
        public void Kerület_Teszt()
        {
            double sugár = 5;
            kor kor = new kor(sugár);
            kor.SetKerulet();
            double vártEredm=31.4;
        }
        [TestMethod]
        public void Terület_Teszt()
        {
           
        }

    }
}
