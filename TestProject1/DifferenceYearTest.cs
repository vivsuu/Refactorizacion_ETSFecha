using ETSFecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FechasTest
{
    [TestClass]
    public class DifferenceYearTest
    {
        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de años de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod7()
        {
            Program.Date[] dates = new Program.Date[2];

            dates[0].Year = 1900;
            dates[0].Month = 2;
            dates[0].Day = 10;
            dates[0].ACDC = 0;

            dates[1].Year = 1900;
            dates[1].Month = 2;
            dates[1].Day = 11;
            dates[1].ACDC = 1;

            string[] result = { "3800", "1" };

            Assert.AreEqual(YearDifference.DifferenceYear(dates)[0],result[0]);
        }

        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de días de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod8()
        {
            Program.Date[] date = new Program.Date[2];

            date[0].Year = 1900;
            date[0].Month = 2;
            date[0].Day = 10;
            date[0].ACDC = 0;

            date[1].Year = 1900;
            date[1].Month = 2;
            date[1].Day = 11;
            date[1].ACDC = 1;

            string[] result = { "3800", "1" };

            Assert.AreEqual(YearDifference.DifferenceYear(date)[1], result[1]);
        }
        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de años de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod9()
        {
            Program.Date[] dates = new Program.Date[2];

            dates[0].Year = 1910;
            dates[0].Month = 2;
            dates[0].Day = 10;
            dates[0].ACDC = 0;

            dates[1].Year = 1900;
            dates[1].Month = 2;
            dates[1].Day = 11;
            dates[1].ACDC = 1;

            string[] result = { "3800", "1" };

            Assert.AreNotEqual(YearDifference.DifferenceYear(dates)[0], result[0]);
        }

        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de días de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod10()
        {
            Program.Date[] date = new Program.Date[2];

            date[0].Year = 1912;
            date[0].Month = 2;
            date[0].Day = 10;
            date[0].ACDC = 0;

            date[1].Year = 1900;
            date[1].Month = 2;
            date[1].Day = 11;
            date[1].ACDC = 1;

            string[] result = { "3800", "1" };

            Assert.AreNotEqual(YearDifference.DifferenceYear(date)[0], result[1]);
        }
    }
}
