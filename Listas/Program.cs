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

            //CREACION DE UNA LISTA
            List<string> Nombres = new List<string>();

            Console.WriteLine("Ingresa tu primer nombre");
            string primerNombre = Console.ReadLine();
            Console.WriteLine("Ingresa tus apellidos");
            string apellidos = Console.ReadLine();

            // AGREGAR DATOS A UNA LISTA
            Nombres.Add(primerNombre);
            Nombres.Add(apellidos);

            // RECORREO UNA LISTA
            foreach (string valor in Nombres)
            {
                Console.WriteLine(valor);
            }

            /*También podemos crear una lista con datos previos, para ello, utilizamos 
             * la sintaxis similar a los arreglos:*/
            List<string> personajes = new List<string>() 
            { 
                "Cecil",
                "Rosa",
                "Kayn"
            
            };

            foreach(string datos in personajes)
            {
                Console.WriteLine("Nombre: {0}", datos);
            }


            //LISTAS COMPLEJAS

            /*Así como los arreglos bidimensionales, también podemos utilizar listas para 
            almacenar múltiples datos de un mismo tipo, para ello, necesitamos crear una instancia del 
            objeto del tipo de la lista en cuestión, veamos un ejemplo.*/
            List<Player> party = new List<Player>()
            {
                new Player() {name = "Cecil", level = 42},
                new Player() {name = "New", level = 42}
            };


            // Recorremos la lisya mediante un foreach
            foreach (Player dato in party)
            {
                Console.WriteLine(dato.name);
            }

        }

        //Creamos un clase tipo Player en la que contendra los items/identificadores que alamacenara los datos de la
        //collecion "party"
        class Player
        {
            // "get" nos ayudara para que pueda leer los datos que se ingresen en la coleccion party de tipo Player
            // "set" nos ayudara a mostrar los datos cuando queramos acceder a la coleccion party de tipo Player
            public string name { get; set; }
            public int level { get; set; }
        }
    }
}
