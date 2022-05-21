using System;

namespace ETSFecha
{
    public class Program
    {
        /// <summary>
        /// Estructura en donde guardar los datos de los años, meses, dias y si es antes de cristo.
        /// Si es antes de cristo(AC) = 0
        /// Si es después de cristo(DC) = 1
        /// </summary>
        public struct Date
        {
            public int Year;
            public int Month;
            public int Day;
            public int ACDC;
        }

        static void Main(string[] args)
        {
            string[] language = Menu.StartMenu();
            if (language.Length>0)
            {
                Date[] allDates = TomaDatos.UsoStruct(language);
                Dates.CheckInformation(allDates, language);
                string[] result = DiferenciasAnnos.DifferenceYear(allDates);

                Console.WriteLine(language[15] + result[0] + language[16] + result[1]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Pulsa una tecla para finalizar...");
                Console.ReadKey();
            }
            

        }
    }
}
