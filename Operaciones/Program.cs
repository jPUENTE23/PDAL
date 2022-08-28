using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer valor: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicacion es: " + (num1 * num2));
            Console.WriteLine("La division es: " + (num1 / num2));

        }
    }
}
