//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Author : FERNANDEZ Tony
//Created On: ‎‎‎samedi ‎6 ‎mars ‎2021, ‏‎19:17:50
//Last Modified on : ‎‎‎dimanche ‎21 ‎mars ‎2021, ‏‎10:06:00
//‎Copy Rights : GSB
//Description : Tests unitaires des fonctions gestion de dates
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsServiceClotureDeFiche;
using System;

namespace WindowsServiceClotureDeFiche.Tests
{
    [TestClass()]
    public class GestionDeDatesTests
    {
        [TestMethod()]
        public void GetMoisPrecedentTest()
        {
            string expected = "02";
            string actual = GestionDeDates.GetMoisPrecedent();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMoisPrecedentTest1()
        {
            string expected = "01";
            DateTime date = DateTime.Parse("6/02/2021");
            string actual = GestionDeDates.GetMoisPrecedent(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMoisSuivantTest()
        {
            string expected = "04";
            string actual = GestionDeDates.GetMoisSuivant();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMoisSuivantTest1()
        {
            string expected = "02";
            DateTime date = DateTime.Parse("6/01/2021");
            string actual = GestionDeDates.GetMoisSuivant(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EntreTest()
        {
            bool expected = true; // false;
            int jour1 = 15; // 2;
            int jour2 = 30; // 15;
            bool actual = GestionDeDates.Entre(jour1, jour2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EntreTest1()
        {
            bool expected = false; // true;
            int jour1 = 7; // 2;
            int jour2 = 15;
            DateTime date = DateTime.Parse("6/01/2021");
            bool actual = GestionDeDates.Entre(jour1, jour2, date);
            Assert.AreEqual(expected, actual);
        }
    }
}