using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("suma de dos numeros");
            Console.WriteLine("Ingresa numero 1: ");
            //los datos se leen como cadena
            string dato = Console.ReadLine();
            //convertir a numero con int.Parse
            int n1 = int.Parse(dato);
            Console.WriteLine("inggresa numero 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("el resultaod es: {0}", suma);
            Console.ReadLine();
        }
    }
}
