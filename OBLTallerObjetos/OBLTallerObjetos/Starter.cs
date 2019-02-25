using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AMCGlib;

namespace OBLTallerObjetos
{
    class Starter
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();
            //Console.SetWindowSize(60, 100);
            //var recetasList = new List<Receta>();

            var receta = new Receta();
            // Inicializa el objeto y mete 2 recetas como preset

            //TODO
            /*
             * Mover el for al metodo "Crear Receta"
             * Convertirlo a objeto y meterlo en una lista
             */
            for (int i = 0; i < 2; i++)
            {
                receta.Id = rnd.Next(100);
                receta.Nombre = "Receta" + rnd.Next(100);
                receta.Descripcion = "DescripcionReceta";
                receta.ElaboracionBody = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua";
                receta.TiempoCoccion = rnd.Next(1, 16);
                receta.CantPorciones = rnd.Next(1, 9);
                receta.Imagen = "Imagen" + rnd.Next(100) +".png";
                receta.UrlVideo = "youtube.com";
                receta.Medidas = true;

            }

            int selectedOption = 0;
            do
            {
                selectedOption = showMainMenu();
            } while (selectedOption != 3); //num de opciones, si la opcion es 3 -> exit 
        }

        static public int showMainMenu()
        {
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
