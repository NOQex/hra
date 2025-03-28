using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using hra;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form1 = new Form1();
        NPC daniel = new NPC("daniel", true, "prace");
      
        [TestMethod]
        public void NameTest()
        {
            HerniPostava postavicka = new HerniPostava();
            Assert.AreNotEqual(postavicka.getName());
        }

        [TestMethod]
        public void LevelTest()
        {
            HerniPostava postavicka = new HerniPostava();
            Assert.AreEqual(postavicka.getLevel(), 1);
        }

        [TestMethod]
        public void XTest()
        {
            HerniPostava postavicka = new HerniPostava();
            Assert.AreEqual(postavicka.getX(), 0);
        }

        [TestMethod]
        public void YTest()
        {
            HerniPostava postavicka = new HerniPostava();
            Assert.AreEqual(postavicka.getY(), 0);
        }

        [TestMethod]
        public void SpecializationTest()
        {
            Hrac dan = new Hrac();
            dan.Specializace = "ABCD";
            Assert.IsFalse(
                   dan.getSpecialization() == "Kouzelník"
                || dan.getSpecialization() == "Berserker"
                || dan.getSpecialization() == "Inženýr"
                || dan.getSpecialization() == "Cizák");
        }

        [TestMethod]
        public void FaceTest()
        {
            Hrac dan = new Hrac();
            Assert.AreEqual(dan.getFace(), 0);
        }

        [TestMethod]
        public void HairTest()
        {
            Hrac dan = new Hrac();
            Assert.AreEqual(dan.getHair(), 0);
        }

        [TestMethod]
        public void HairColorTest()
        {
            Hrac dan = new Hrac();
            Assert.AreEqual(dan.getHairColor(), 0);
        }

        [TestMethod]
        public void XPTest()
        {
            Hrac dan = new Hrac();
            Assert.AreEqual(dan.getXP(), 0);
        }

        [TestMethod]
        public void addXPTest()
        {
            Hrac dan = new Hrac();
            Assert.AreEqual(dan.addXP(10, 20), 30);
        }

        [TestMethod]
        public void ToStringTest()
        {
            Hrac dan = new Hrac();
            string result = dan.ToString();


            StringAssert.Contains("Postava", result);
            StringAssert.Contains("1", result);
            StringAssert.Contains("0", result);
            StringAssert.Contains("0", result);
        }

        [TestMethod]
        public void KonstruktorTest()
        {
            HerniPostava postavicka = new HerniPostava();
            Assert.IsNotNull(postavicka);
            Assert.AreEqual("Lukas", postavicka.getName());
        }

        [TestMethod]
        public void PraceTest()
        {
            Assert.IsTrue(
                  daniel.getPrace() == "Obchodník"
               || daniel.getPrace() == "Nepřítel"
               || daniel.getPrace() == "Obyvatel");
        }

        [TestMethod]
        public void BossTest()
        {
            Assert.IsTrue(daniel.getStrenght());
        }

        public void Konstruktor2Test()
        {
            Assert.IsNotNull(daniel);
            Assert.AreEqual("daniel", daniel.getName());
            Assert.AreEqual(true, daniel.getStrenght());
            Assert.AreEqual("prace", daniel.getPrace());
        }

        [TestMethod]
        public void AddLvlTest()
        {
            Assert.AreEqual(daniel.addLvl(2), 3);
        }

        
        [TestMethod]
        public void xptonextlvltest()
        {
            Assert.AreEqual(daniel.xpToNextLvl(2), 200);
        }

    
        [TestMethod]
        public void Test_ChangePosition_ValidClick()
        {
            var character = new GameCharacter("Test");
            character.ChangePosition(5, 10);  
            Assert.AreEqual(5, character.PositionX);
            Assert.AreEqual(10, character.PositionY);
        }

      
        [TestMethod]
        public void Test_ToString()
        {
            var character = new GameCharacter("Test");
            string result = character.ToString();
            Assert.IsTrue(result.Contains("Test"));
            Assert.IsTrue(result.Contains("1")); 
            Assert.IsTrue(result.Contains("0"));  
            Assert.IsTrue(result.Contains("0"));  
        }

     
        public void Konstruktor2Test()
        {
            Assert.IsNotNull(daniel);
            Assert.AreEqual("daniel", daniel.getName());
            Assert.AreEqual(true, daniel.getStrenght());
            Assert.AreEqual("prace", daniel.getPrace());
        }
    }
}
