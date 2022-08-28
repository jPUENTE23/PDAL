using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Nombres = new List<string>();

            Console.WriteLine("Ingresa tu primer nombre");
            string primerNombre = Console.ReadLine();
            Console.WriteLine("Ingresa tus apellidos");
            string apellidos = Console.ReadLine();
            Nombres.Add(primerNombre);
            Nombres.Add(apellidos);

            Console.WriteLine(Nombres);

            foreach (string valor in Nombres)
            {
                Console.WriteLine(valor);
                Console.ReadLine();
            }

            string[] arratNombres = Nombres.ToArray();
            Console.WriteLine(arratNombres);
            Console.ReadLine();
        }
    }
}
