using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSFecha
{
    class Menu
    {
        /// <summary>
        /// Genera un menu para seleccionar el idioma
        /// </summary>
        /// <returns>Retorna el idioma implementado en todo el programa</returns>
        public static string[] StartMenu()
        {
            const string spanish = "es.txt";
            const string english = "en.txt";
            const string chinese = "ch.txt";
            const string french = "fr.txt";
            const string portuguese = "pl.txt";
            const string polish = "pt.txt";
            const string russian = "ru.txt";
            string[] language = new string[0];
            ConsoleKeyInfo option;
            bool exit = false;
            do
            {
                ShowMenuOptions();
                option = Console.ReadKey(true);
                switch (option.KeyChar)
                {
                    case '1': language = MyFiles.ReadFile(english); exit = true; break;
                    case '2': language = MyFiles.ReadFile(spanish); exit = true; break;
                    case '3': language = MyFiles.ReadFile(chinese); exit = true; break;
                    case '4': language = MyFiles.ReadFile(french); exit = true; break;
                    case '5': language = MyFiles.ReadFile(portuguese); exit = true; break;
                    case '6': language = MyFiles.ReadFile(polish); exit = true; break;
                    case '7': language = MyFiles.ReadFile(russian); exit = true; break;
                    case '8': exit = true; break;
                        
                }
            } while (!exit);
            return language;
        }
        /// <summary>
        /// Muestra las opciones de idiomas en el menu
        /// </summary>
        private static void ShowMenuOptions()
        {           
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-            DATES/FECHAS               -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- Choose the language you wish to use:  -");
            Console.WriteLine("- Pulsa el idioma que quieres usar:     -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1. Ingles / English.                  -");
            Console.WriteLine("- 2. Español / Spanish.                 -");
            Console.WriteLine("- 3. Salir / Exit.                      -");
            Console.WriteLine("-----------------------------------------");
        }
    }
}
