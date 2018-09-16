using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
    class Program
    {
       public delegate void Midelegado(string M);
        static void Main(string[] args)
        {
            Midelegado delegado = new Midelegado(Avion.Volar);
            delegado("Nos vemos cuidense mucho");

            delegado = new Midelegado(Auto.Rodar);
            delegado("Empieza la gira yeii");
            Console.ReadLine();
        }
    }
}
