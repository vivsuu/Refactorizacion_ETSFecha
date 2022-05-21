using System;

namespace ETSFecha
{
    public class DiferenciasAnnos
    {

        /// <summary>
        /// Devuelve el numero de fechas antes de cristo que se envíen a través de la estructura(parámetro)
        /// </summary>
        /// <param name="allDates">
        /// Todos los datos de las fechas pedidas
        /// </param>
        /// <returns></returns>
        private static int CounterYears(Program.Date[] allDates)
        {
            int counter = 0;
            for (int position = 0; position < allDates.Length; position+1)
            {
                if (allDates[position].ACDC == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
        /// <summary>
        ///  Calcula la diferencia en años y en días y se muestra por pantalla.
        /// </summary>
        /// <param name="listaFechas">
        /// El parámetro contiene las dos fechas con las que se va a trabajar.
        /// </param>
        public static string[] DifferenceYear(Program.Date[] alldata)
        {
            int numACDC = CounterYears(alldata);
            string[] result = new string[2];
            int year = 0;
            int days = 0;
            if (numACDC == 1)
            {
                DateTime dateOne = new DateTime(1, alldata[0].Month, alldata[0].Day);
                DateTime dateTwo = new DateTime(alldata[0].Year + alldata[1].Year + 1, alldata[1].Month, alldata[1].Day);
                DiffYearsDays(ref days, ref year, dateTwo, dateOne);
            }
            else
            {
                DateTime dateOne = new DateTime(alldata[0].Year, alldata[0].Month, alldata[0].Day);
                DateTime dateTwo = new DateTime(alldata[1].Year, alldata[1].Month, alldata[1].Day);

                if (dateOne > dateTwo)
                {
                    DiffYearsDays(ref days, ref year, dateOne, dateTwo);
                }
                else
                {
                    if (dateOne < dateTwo)
                    {
                        DiffYearsDays(ref days, ref year, dateTwo, dateOne);
                    }
                }
            }
            result[0] = year.ToString();
            result[1] = days.ToString();

            return result;
        }

        /// <summary>
        /// Enviadas como argumentos las fechas diferenciadas
        /// </summary>
        /// <param name="days">
        /// Numero entero total de diferencias entre la fecha menor y mayor en dias
        /// </param>
        /// <param name="years">
        /// Numero entero total entre la fecha menor y mayor en años
        /// </param>
        /// <param name="higherYears">
        /// Fecha más actual
        /// </param>
        /// <param name="lowerYears">
        /// Fecha más antigua
        /// </param>
        private static void DiffYearsDays(ref int days, ref int years, DateTime higherYears, DateTime lowerYears)
        {
            years = higherYears.Year - lowerYears.Year;
            days = CalcDay(higherYears, lowerYears);
        }
        private static int CalcDay(DateTime date, DateTime dateTwo)
        {
            int day = 0;
            DateTime provisionalDateOne = new DateTime(1, date.Month, date.Day);
            DateTime provisionalDateTwo = new DateTime(1, dateTwo.Month, dateTwo.Day);

            if (provisionalDateOne < provisionalDateTwo)
            {
                day = (provisionalDateTwo - provisionalDateOne).Days;
            }
            else
            {
                day = (provisionalDateOne - provisionalDateTwo).Days;
            }
            return day;
        }
    }
}