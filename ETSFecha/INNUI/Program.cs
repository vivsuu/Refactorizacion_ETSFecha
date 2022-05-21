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
            string[] language = Menu.StartMenu();//Se inicia el menú
            if (language.Length > 0)
            {
                Date[] allDates = TomaDatos.UsoStruct(language);
                Dates.CheckInformation(allDates, language);
                string[] result = YearDifference.DifferenceYear(allDates);
                MyFiles.ShowMessage(language, result);
                MyFiles.ShowMessage(language);
            }
            else
            {
                MyFiles.ShowMessage();
            }


        }
    }
}
