using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //RegistroNombres();

            //int filas = 1;
            

            int respuesta;


            do
            {
                int[,] resultados = new int[1, 4];
                //resultados = [filas, 4];
                Console.WriteLine("Ingresa el primer numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo numero: ");
                int num2 = int.Parse(Console.ReadLine());

                int suma = num1 + num2;
                int resta = num1 - num2;
                int multiplicacion = num1 * num2;
                int division = num1 * num2;

                for (int datoFilas = 0; datoFilas < 1; datoFilas++)
                {
                    resultados[datoFilas, 0] = suma;
                    resultados[datoFilas, 1] = resta;
                    resultados[datoFilas, 2] = multiplicacion;
                    resultados[datoFilas, 3] = division;
                }

                Console.WriteLine("\n");
                Console.WriteLine("Los resultados almcaenado en la matriz son los siguiente: ");

                for (int datoC = 0; datoC < 4; datoC++)
                {
                    Console.WriteLine("Resultados[{0}] = {1}", datoC, resultados[0,datoC]);
                }


                Console.WriteLine("\n");

                Console.WriteLine("Desea calcular mas operaciones?: 1-SI  2-NO: ");
                respuesta = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            }
            while (respuesta == 1);

        }

        static void RegistroNombres() {

            /*Realiza un programa que permita llenar los nombres de un grupo y sus matriculas hasta que el 
             * usuario diga que ya fueron todos los alumnos.*/

            int seguir;

            do
            {
                Console.WriteLine("Ingresa el nombre del alumno: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la matricula del alumno");
                int matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Nombre del Alumno: {0}\nMatricula del Alumno: {1}", nombre, matricula);

                Console.WriteLine("Continuar: ");
                seguir = int.Parse(Console.ReadLine());
            }
            while (seguir != 0);
        }
    }
}
