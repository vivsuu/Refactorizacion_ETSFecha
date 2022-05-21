using System;

namespace ETSFecha
{
    class TomaDatos
    {
        /// <summary>
        /// Programa para verificar el formato de la recogida de datos 
        /// </summary>
        /// <returns>Devuelve las fechas en un array de estructura</returns>
        public static Program.Date[] UsoStruct(string[] language)
        {
            Program.Date[] dates = new Program.Date[2];

            for (int fillDates = 0; fillDates < 2; fillDates++)
            {
                Console.Clear();
                bool leapYear = false;
                Console.WriteLine(language[17] + (fillDates+1));
                dates[fillDates].ACDC = BCInput(language);
                dates[fillDates].Year = InputYear(ref leapYear, language);
                dates[fillDates].Month = MonthInput(language);
                dates[fillDates].Day = DayInput(leapYear, dates[fillDates].Month, language);
            }

            return dates;
        }

        /// <summary>
        /// Pide y comprueba si es antes de cristo o después de cristo.
        /// </summary>
        /// <returns>1 si es antes de cristo o 0 si es después de cristo</returns>
        private static int BCInput(string[] language)
        {
            bool leave = false;
            int option = -1;

            while (!leave)
            {
                Console.WriteLine(language[0]);
                string text = Console.ReadLine();

                if (int.TryParse(text, out option))
                {
                    if (option == 0)
                    {
                        leave = true;
                    }
                    else
                    {
                        if (option == 1)
                        {
                            leave = true;
                        }
                        else
                        {
                            Console.WriteLine(language[1]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(language[2]);
                }

            }
            return option;
        }

        /// <summary>
        /// Pide un año y comprueba si es válido.
        /// </summary>
        /// <param name="LeapYear">Booleano que almacena si es bisiesto o no</param>
        /// <returns>Retorna el año</returns>
        private static int InputYear(ref bool LeapYear, string[] language)
        {
            bool leave = false;
            int anio = 0;

            while (!leave)
            {
                Console.Write(language[3]);
                string Text = Console.ReadLine();

                if (Int32.TryParse(Text, out anio))
                {
                    if (anio < 10000)
                    {
                        if (anio >= 1)
                        {
                            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
                            {
                                LeapYear = true;
                            }
                            leave = true;
                        }
                        else
                        {
                            Console.WriteLine(language[4]);
                        }
                    }
                    else
                    {
                        Console.WriteLine(language[5]);
                    }
                }
                else
                {
                    Console.WriteLine(language[2]);
                }
            }
            return (anio);
        }

        /// <summary>
        /// Pide un mes y comprueba si es válido.
        /// </summary>
        /// <returns>Devuelve el valor del mes</returns>
        private static int MonthInput(string[] language)
        {
            bool Continue = true;
            int month = 0;
            while (Continue)
            {
                Console.WriteLine(language[6]);
                string recogidaMes = Console.ReadLine();

                if (Int32.TryParse(recogidaMes, out month))
                {
                    if (month < 13)
                    {
                        if (month >= 1)
                        {

                            Continue = false;
                        }
                        else
                        {
                            Console.WriteLine(language[7]);
                        }
                    }
                    else
                    {
                        Console.WriteLine(language[8]);
                    }
                }
                else
                {
                    Console.WriteLine(language[2]);
                }
            }
            return month;
        }

        /// <summary>
        /// Pide dias y comprueba si es válido.
        /// </summary>
        /// <param name="bisiesto">Se le pasa el booleano para, en caso de que el mes sea febrero, aceptar los dias 29</param>
        /// <param name="mes">Numero de mes</param>
        /// <returns>Retorna el día comprobado</returns>
        private static int DayInput(bool bisiesto, int mes, string[] language)
        {
            bool leave = false;
            int day = 0;
            while (!leave)
            {
                Console.WriteLine(language[9]);
                string Text = Console.ReadLine();
                if (Int32.TryParse(Text, out day))
                {
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        if (day >= 1 && day <= 31)
                        {
                            leave = true;
                        }
                        else
                        {
                            Console.WriteLine(language[10]);
                        }
                    }
                    else
                    {
                        if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                        {
                            if (day >= 1 && day <= 30)
                            {
                                leave = true;
                            }
                            else
                            {
                                Console.WriteLine(language[10]);
                            }
                        }
                        if (mes == 2)
                        {
                            if (!bisiesto)
                            {
                                if (day >= 1 && day <= 28)
                                {
                                    leave = true;
                                }
                                else
                                {
                                    Console.WriteLine(language[10]);
                                }
                            }
                            else
                            {
                                if (day >= 1 && day <= 29)
                                {
                                    leave = true;
                                }
                                else
                                {
                                    Console.WriteLine(language[10]);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(language[2]);
                }
            }
            return day;
        }

    }
}
