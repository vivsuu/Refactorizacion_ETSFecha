using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ETSFecha
{
    class MyFiles
    {
        /// <summary>
        /// Lee un fichero con el idioma seleccionado
        /// </summary>
        /// <param name="fileName">El nombre fichero con el idioma</param>
        /// <returns>Las lineas de texto en el idioma elegido</returns>
        public static string[] ReadFile(string fileName)
        {
            string[] language = new string[0];
            try
            {
                StreamReader SRead = new StreamReader(fileName);
                while (!SRead.EndOfStream)
                {
                    Array.Resize(ref language, language.Length + 1);
                    language[language.Length - 1] = SRead.ReadLine();
                }
                SRead.Close();
            }
            catch(Exception error)
            {
                Array.Resize(ref language, 0);
                Console.WriteLine(error);
            }
            return language;
        }
        /// <summary>
        /// Muestra mensajes genericos
        /// </summary>
        public static void ShowMessage(string[] language, string[] result)
        {
            Console.WriteLine(language[15] + result[0] + language[16] + result[1]);
            Console.ReadKey();
        }
        /// <summary>
        /// Muestra mensajes genericos de salida
        /// </summary>
        public static void ShowMessage(string[] language)
        {
            Console.WriteLine(language[20]);
            Console.ReadKey();
        }
        /// <summary>
        /// Muestra mensajes genericos de error
        /// </summary>
        public static void ShowMessage()
        {
            Console.WriteLine("Error");
            Console.ReadKey();
        }
    }
}
