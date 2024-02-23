using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero = int.Parse(Console.ReadLine());
            if (numeroEntero == 7)
                Console.WriteLine("numero entero es 7.");
            else if (numeroEntero < 0)
                Console.WriteLine("numero entero es negativo");
            else
                Console.WriteLine("numeroEntero no es ninguno de los casos programados");
            Console.ReadLine();
        }
    }
}
