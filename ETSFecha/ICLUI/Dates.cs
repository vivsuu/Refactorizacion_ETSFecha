  using System;

namespace ETSFecha
{
    public class Dates
    {
        /// <summary>
        /// Hace el mostrado para las dos fechas (diferencia entre la fecha usuario y la actual) 
        /// </summary>
        /// <param name="CheckDates"></param>
        public static void CheckInformation(Program.Date[] CheckDates, string[] language)
        {
            for (int counter = 0; counter < CheckDates.Length; counter++)
            {
                DateTime fecha = new DateTime(CheckDates[counter].Anno, CheckDates[counter].Mes, CheckDates[counter].Dia);
                DateTime fechaHoy = DateTime.Today;
                if (CheckDates[counter].ACDC == 1)
                {
                    int agno = YearCalc(fecha);
                    int day = DayCalc(fecha);
                    Console.Clear();
                    Console.WriteLine(language[11] + agno + language[12] + day + language[13] + (counter + 1) + language[18]);
                    Console.WriteLine(language[14]);
                    Console.ReadKey();
                }
                else
                {
                    int agno = YearCalcDC(fecha);
                    int day = DayCalc(fecha);
                    Console.Clear();
                    Console.WriteLine(language[11] + agno + language[12] + day + language[13] + (counter + 1));
                    Console.WriteLine(language[14]);
                    Console.ReadKey();
                }
            }
        }
        /// <summary>
        /// Retorna el calculo de la diferencia de años (Para antes de cristo)
        /// </summary>
        /// <param name="Date"></param>
        /// <returns></returns>
        public static int YearCalc(DateTime Date)
        {
            DateTime Today = DateTime.Today;
            int agno = (Date.Year + Today.Year);
            return agno;
        }
        /// <summary>
        /// Lo mismo de arriba solo que aquí la usamos para los años DC
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int YearCalcDC(DateTime date)
        {
            DateTime today = DateTime.Today;
            int year = 0;
            if (date.Year < today.Year)
            {
                year = today.Year - date.Year;
            }
            else
            {
                year = date.Year - today.Year;
            }
            return year;
        }
        /// <summary>
        /// Función que calcula los días entre la fecha actual y fecha usuario.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int DayCalc(DateTime date)
        {
            DateTime today = DateTime.Today;
            int day = 0;
            if (date.Day < today.Day)
            {
                day = today.Day - date.Day;
            }
            else
            {
                day = date.Day - today.Day;
                DateTime preDate = new DateTime(1, date.Month, date.Day);
                DateTime todayPreDate = new DateTime(1, today.Month, today.Day);

                if (preDate < todayPreDate)
                {
                    day = (todayPreDate - preDate).Days;
                }
                else
                {
                    day = (preDate - todayPreDate).Days;
                }
            }
            return day;
        }
    }
}
