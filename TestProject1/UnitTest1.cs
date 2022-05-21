using ETSFecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
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

            dates.Anno = 1900;
            dates.Mes = 2;
            dates.Dia = 10;
            dates.ACDC = 0;

            DateTime date = new DateTime(dates.Anno, dates.Mes, dates.Dia);

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

            dates.Anno = 2022;
            dates.Mes = 2;
            dates.Dia = 1;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Anno, dates.Mes, dates.Dia);

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

            dates.Anno = 2022;
            dates.Mes = 2;
            dates.Dia = 1;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Anno, dates.Mes, dates.Dia);

            Assert.AreNotEqual(Dates.YearCalc(date), 1000);
        }
        /// <summary>
        /// Esta funcion debería devolverle los días de la fecha puesta hasta el día de hoy
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            Program.Date dates = new Program.Date();

            dates.Anno = 2022;
            dates.Mes = 2;
            dates.Dia = 1;
            dates.ACDC = 1;

            DateTime date = new DateTime(dates.Anno, dates.Mes, dates.Dia);

            Assert.AreEqual(Dates.DayCalc(date), 20);
        }
        /// <summary>
        /// Aquí igual solo que le ponemos una fecha AC y ebería devolver el valor de 11 días.
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            Program.Date dates = new Program.Date();

            dates.Anno = 1900;
            dates.Mes = 2;
            dates.Dia = 10;
            dates.ACDC = 0;

            DateTime date = new DateTime(dates.Anno, dates.Mes, dates.Dia);

            Assert.AreEqual(Dates.DayCalc(date), 11);
        }

        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de años de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            Program.Date[] dates = new Program.Date[2];

            dates[0].Anno = 1900;
            dates[0].Mes = 2;
            dates[0].Dia = 10;
            dates[0].ACDC = 0;

            dates[1].Anno = 1900;
            dates[1].Mes = 2;
            dates[1].Dia = 11;
            dates[1].ACDC = 1;

            string[] result = { "3800", "1" };

            Assert.AreEqual(DiferenciasAnnos.DifferenceYear(dates)[0],result[0]);
        }

        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de días de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod7()
        {
            Program.Date[] date = new Program.Date[2];

            date[0].Anno = 1900;
            date[0].Mes = 2;
            date[0].Dia = 10;
            date[0].ACDC = 0;

            date[1].Anno = 1900;
            date[1].Mes = 2;
            date[1].Dia = 11;
            date[1].ACDC = 1;

            string[] result = { "3800", "1" };

            Assert.AreEqual(DiferenciasAnnos.DifferenceYear(date)[1], result[1]);
        }
    }
}
