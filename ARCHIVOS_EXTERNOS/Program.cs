using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;


namespace ARCHIVOS_EXTERNOS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ESCRITURA EN ARCHIVOS EXTERNOS
            //Creacion de una ruta para el almacenamiento de archivo 
            string path = @"C:\Users\jorge\source\repos\PROGRAMACION DE APLICACIONES LOCALES\PROBLEMAS\Operaciones\ARCHIVOS_EXTERNOS\characters.txt";

            // *El nombre del archivo puede ser cualquiera, así como la ruta.
            // *Si no existe el archive, el Código lo va a generar en la ruta indicada.
            string character = "";
            Console.WriteLine("Select the character you want to add to your party" +
                "\n Cloud" +
                "\n Tifa" +
                "\n Barret"
                );
            character = Console.ReadLine();

            File.AppendAllText(path, character + "\n");

            /*var data = new Character[]
            {
                new Character() { Level = 15, Name = "Cloud", Job = "Ex-Soldier" },
                new Character() { Level = 12, Name = "Tifa", Job = "Monk" },
            };

            data.ExportToTextFile(@"C:\Users\User1\Desktop\PAL\Characters.txt", ' ');*/

        }


        /*class Character
        {
            public int Level { get; set; }
            public string Name { get; set; }
            public string Job { get; set; }

            static void ExportToTextFile<T>(this IEnumerable<T> data, string FileName, char ColumnSeperator)
            {
                using (var sw = File.CreateText(FileName))
                {
                    var plist = typeof(T).GetProperties().Where(p => p.CanRead && (p.PropertyType.IsValueType || p.PropertyType == typeof(string)) && p.GetIndexParameters().Length == 0).ToList();
                    if (plist.Count > 0)
                    {
                        var seperator = ColumnSeperator.ToString();
                        sw.WriteLine(string.Join(seperator, plist.Select(p => p.Name)));
                        foreach (var item in data)
                        {
                            var values = new List<object>();
                            foreach (var p in plist) values.Add(p.GetValue(item, null));
                            sw.WriteLine(string.Join(seperator, values));
                        }
                    }
                }
            }
        }*/

    }
}
