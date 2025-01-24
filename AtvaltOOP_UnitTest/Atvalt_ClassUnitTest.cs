using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtvaltOOP;
namespace AtvaltOOP_UnitTes 
{
    [TestClass]
    public class Atvalt_ClassUnitTest
    {
        Atvalt atvalt = new Atvalt();
        [TestMethod]
        public void IsDecimal_True()
        {
            string szoveg = "21";
            bool vartEredm = true,
            kapottEredm = false;
            kapottEredm = atvalt.isDecimal(szoveg);
            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]
        public void IsDecimal_False()
        {
            string szoveg1 = "k";
            bool vartEredm1 = false,
            kapottEredm1 = false;
            kapottEredm1 = atvalt.isDecimal(szoveg1);
            Assert.AreEqual(kapottEredm1, vartEredm1);


        }
        [TestMethod]
        public void isBinaris_True() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg2 = "21";
            bool vartEredm2 = true, kapottEredm2 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm2 = atvalt.isBinaris(szoveg2);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm2, vartEredm2);


        }
        [TestMethod]
        public void isBinaris_False() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg3 = "k";
            bool vartEredm3 = true, kapottEredm3 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm3 = atvalt.isBinaris(szoveg3);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm3, vartEredm3);


        }

    }
}
