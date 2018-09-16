using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
  public  class Auto
    {
        public static void Rodar(string MensajeDeDespedida)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Estoy en mi auto  empezando el viaje  y les quiero decir que {0}", MensajeDeDespedida));
        }
    }
}
