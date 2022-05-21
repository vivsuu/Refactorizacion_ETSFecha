using ETSFecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FechasTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Comprobamos si los años se calculan bien
        /// La funcion calcula los años antes de cristo
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 1900;
            dates.Month = 2;
            dates.Day = 10;
            dates.ACDC = 0;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreEqual(Dates.YearCalc(date), 3922);

        }
        /// <summary>
        /// Debería devolver 0 años ya que la fecha está bastante cerca.
        /// La función es calcular años despues de cristo.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 2022;
            dates.Month = 2;
            dates.Day = 1;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreEqual(Dates.YearCalcDC(date), 0);
        }
        /// <summary>
        /// Tiene que ser incorrecto ya que los años están mal puestos.
        /// La funcion debería devolver 0 años ya que es una fecha próxima.
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 2022;
            dates.Month = 2;
            dates.Day = 1;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreNotEqual(Dates.YearCalc(date), 1000);
        }
        /// <summary>
        /// Esta funcion debería devolverle los días de la fecha puesta hasta el día de hoy
        /// </summary>
        [TestMethod]
        public void TestMethod4()
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
        /// Aquí igual solo que le ponemos una fecha AC y ebería devolver el valor de 11 días.
        /// </summary>
        [TestMethod]
        public void TestMethod5()
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
        /// Se comprueba que se devuelva el valor correcto del calculo de años de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod6()
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
        public void TestMethod7()
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
    }
}
