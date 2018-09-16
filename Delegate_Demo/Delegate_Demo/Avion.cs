using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
   public class Avion
    {
        public static void Volar(string MensajeDeDespedida)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Format("Estoy en un avion empezando el vuelo y les quiero decir que {0}", MensajeDeDespedida));
        }
    }
}
