using ETSFecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FechasTest
{
    [TestClass]
    public class YearCalcTest
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
        /// Comprobamos si los años se calculan bien
        /// La funcion calcula los años antes de cristo
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 1100;
            dates.Month = 2;
            dates.Day = 10;
            dates.ACDC = 0;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreNotEqual(Dates.YearCalc(date), 3922);

        }
        /// <summary>
        /// Debería devolver 0 años ya que la fecha está bastante cerca.
        /// La función es calcular años despues de cristo.
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 2022;
            dates.Month = 1;
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
        public void TestMethod6()
        {
            Program.Date dates = new Program.Date();

            dates.Year = 2022;
            dates.Month = 2;
            dates.Day = 15;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);

            Assert.AreNotEqual(Dates.YearCalc(date), 1000);
        }
    }
}
