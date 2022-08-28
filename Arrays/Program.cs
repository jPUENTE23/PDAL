using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CREACION DE UN ARREGLO INDICANDO UNA LONGITUD

            int[] usuarios = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine(usuarios[2]);
            Console.ReadLine();


            // ASIGANAICON DE VALORES A UN ARREGLO SIN INDICAR LA LONGITUD
            string[] correo = new string[] { "correo1", "correo2", "correo2" };
            Console.WriteLine(correo[0]);
            Console.ReadLine();


            int[] tabla = new int[10];
            int valorA, valorB;

            for (valorA = 0; valorA < 10; valorA++)
            {
                tabla[valorA] = valorA + 100;
            }
            for (valorB = 0; valorB < 10; valorB++)
            {
                Console.WriteLine("Elemento[{0}] = {1}", valorB, tabla[valorB]);
            }
            Console.ReadKey();

            int[,] resultados = new int[5, 2] { { 0, 0 }, 
                                                { 1, 2 }, 
                                                { 2, 4 }, 
                                                { 3, 6 }, 
                                                { 4, 8 } };
            int filas, columnas;

            for (filas = 0; filas < 5; filas++)
            {
                for (columnas = 0; columnas<2; columnas++)
                {
                    Console.WriteLine("Resultados[{0},{1}] = {2}", filas, columnas, resultados[filas, columnas]);
                }
            }
            Console.ReadKey();
        }
    }
}
