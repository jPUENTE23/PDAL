using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONDICIONALES_y_CICLOS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // IF ELSE
            /*La condicional más común, nos permite realizar una estructura en la que, si ocurre una condición, se ejecuta un evento, y 
             * en caso contrario se ejecuta otro bloque de código, y puede tener más de una condicional 
             * en caso de ser necesario.
             *
             * La sintaxis es la siguiente:*/

            int numero = 10;

            if (numero >= 10){
                Console.WriteLine("El numero es mayot o igual a 10");
            }
            else
            {
                Console.WriteLine("El numero es menor a 10");
            }

            // SWITCH CASE

            /*Cuando tenemos “casos” o condiciones específicas, por ejemplo, días de la semana o meses del año, 
             * que sabemos que no van a variar, si no que siempre serán o mayormente conservaran su valor, 
             * o rango de valores, es mejor utilizar una estructura de casos.*/

            // EJEMPLOP DE SINTAXIS

            int caso;

            Console.WriteLine("[1] Caso 1");
            Console.WriteLine("[2] Caso 2");
            Console.WriteLine("[3] Caso 3");
            Console.WriteLine("Escoja un caso: ");
            caso = int.Parse(Console.ReadLine());

            switch(caso)
            {
                case 1:
                    Console.WriteLine("Ah seleccionado el caso 1");
                    //CADA CASO AL FINAL DEBE LLEVAR SU BREAK PARA QUE SE DETENGA SU EJECUCION
                    break;

                case 2:
                    Console.WriteLine("Ah seleccionado el caso 2");
                    break;

                case 3:
                    Console.WriteLine("Ah seleccionado el caso 3");
                    break;

                default:
                    Console.WriteLine("El caso no es valido");
                    break;
            }

            //CICLO FOR

            for (int variableInc = 1+1; variableInc<=20; variableInc+=2)
            {
                Console.WriteLine("Numero {0}", variableInc);
            }

            //CICLO WHILE
            /*A diferencia del For, el While tiene una variable externa, y el incremental va al final del 
             * código a ejecutar, la condicional puede ser de la misma forma*/

            int valor = 1 + 1;

            Console.WriteLine("\n");
            Console.WriteLine("CILCO WIILE");
            while (valor <= 20)
            {
                Console.WriteLine("Numero: {0}", valor);
                //valor++;
                valor+=2;
            }

            //CICLO DO WHILE
            /*El Do While es similar al While, pero la condicional va hasta el final.*/

            int nvoValor = 1 + 1;
            Console.WriteLine("\n");
            Console.WriteLine("CILCO DO WIILE");
            do
            {
                Console.WriteLine("Numero: {0}", nvoValor);
                //valor++;
                nvoValor += 2;
            }
            while (nvoValor <= 20);
        }
    }
}
