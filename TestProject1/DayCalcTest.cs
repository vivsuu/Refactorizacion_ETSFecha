using ETSFecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FechasTest
{
    [TestClass]
    public class DayCalcTest
    {
        /// <summary>
        /// Esta funcion deber�a devolverle los d�as de la fecha puesta hasta el d�a de hoy
        /// </summary>
        [TestMethod]
        public void TestMethod11()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 2022;
            dates.Month = 2;
            dates.Day = 1;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreEqual(Dates.DayCalc(date), 20);
        }
        /// <summary>
        /// Aqu� igual solo que le ponemos una fecha AC y eber�a devolver el valor de 11 d�as.
        /// </summary>
        [TestMethod]
        public void TestMethod12()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 1900;
            dates.Month = 2;
            dates.Day = 10;
            dates.ACDC = 0;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreEqual(Dates.DayCalc(date), 11);
        }
        /// <summary>
        /// Esta funcion deber�a devolverle los d�as de la fecha puesta hasta el d�a de hoy
        /// </summary>
        [TestMethod]
        public void TestMethod13()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 2020;
            dates.Month = 2;
            dates.Day = 1;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreNotEqual(Dates.DayCalc(date), 21);
        }
        /// <summary>
        /// Aqu� igual solo que le ponemos una fecha AC y eber�a devolver el valor de 11 d�as.
        /// </summary>
        [TestMethod]
        public void TestMethod14()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 100;
            dates.Month = 2;
            dates.Day = 10;
            dates.ACDC = 0;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreNotEqual(Dates.DayCalc(date), 12);
        }
    }
}
