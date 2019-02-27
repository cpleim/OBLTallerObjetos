using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AMCGlib;

namespace OBLTallerObjetos
{
    class Starter
    {
       public static void Main(string[] args)
        {

            //Console.SetWindowSize(60, 100);
            // Inicializa el objeto y mete 2 recetas como preset

            //TODO
            /*
             * Mover el for al metodo "Crear Receta"
             * Convertirlo a objeto y meterlo en una lista
             */
            Random rnd = new Random();
            Receta receta = new Receta();
            for (int i = 0; i < 2; i++)
            {
                // rnd = new Random();
                receta.Id = rnd.Next(100);
                receta.Nombre = "Receta" + rnd.Next(100);
                receta.Descripcion = "DescripcionReceta";
                receta.ElaboracionBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua";
                receta.TiempoCoccion = rnd.Next(1, 16);
                receta.CantPorciones = rnd.Next(1, 9);
                receta.Imagen = "Imagen" + rnd.Next(100) + ".png";
                receta.UrlVideo = "youtube.com";
                receta.Medidas = true;
                receta.RecetasList.Add(receta);
            }
            int selectedOption = 0;
            do
            {
                selectedOption = showMainMenu(receta);
            } while (selectedOption != 3); //num de opciones, si la opcion es 3 -> exit 
        }

        static public int showMainMenu(Receta recetas)
        {
            Console.Clear();
            Console.WriteLine("--------- AMCG - Menu Principal---------");
            Console.WriteLine();
            Console.WriteLine("1. Ingreso de recetas");
            Console.WriteLine("2. Ver recetas");
            Console.WriteLine("3. Salir");
            Console.WriteLine();
            var result = Console.ReadLine();
            var option = Convert.ToInt32(result);

            switch (option)
            {
                case 2:
                    Console.Clear();
                    Console.WriteLine("--------- AMCG - Ver Recetas---------");
                    for (var i = 0; i < recetas.RecetasList.Count; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("----------Receta Nro."+i+"------------");
                        Console.WriteLine("Nombre de receta: "+recetas.RecetasList[i].Nombre);
                        Console.WriteLine("ID de receta: " + recetas.RecetasList[i].Id);
                        Console.WriteLine("----------------------------------");
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    break;
            }

            return option;

        }

    }
}
