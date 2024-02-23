using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entradaSalida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("hola: " + nombre);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
