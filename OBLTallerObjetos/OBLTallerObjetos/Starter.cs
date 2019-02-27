using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AMCGlib;

namespace OBLTallerObjetos
{
    class Starter
    {
       public static void Main(string[] args){
        
            // Inicializa el objeto y mete 5 recetas como preset

            //TODO
            /*
             * Mover el for al metodo "Crear Receta"
             */

           //FIXME
           /*
            * El random se manda cualquiera y genera numeros repetidos para cada objeto generado por el For (Ya se por que es).
            */

           Random rnd = new Random();
           Receta receta = new Receta();
            for (int i = 0; i < 5; i++)
            {
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
                selectedOption = showMainMenu(receta, rnd); //Se le pasa como parametro el objeto random y receta a showMainMenu();
            } while (selectedOption != 3); //num de opciones, si la opcion es 3 -> exit 
        }

        static public int showMainMenu(Receta recetas, Random rnd) //Toma los objetos recetas y random
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
                case 1:
                    Receta recetaTemp = new Receta();
                    recetaTemp.Id = rnd.Next(1000); //Le asigna un numero autonumerico
                    Console.Clear();
                    Console.WriteLine("--------- AMCG - Ingresar Recetas ---------");
                    Console.WriteLine("\nIngrese el nombre de la receta: ");
                    recetaTemp.Nombre = Console.ReadLine();
                    Console.WriteLine("\nIngrese la descripcion: ");
                    recetaTemp.Descripcion = Console.ReadLine();
                    Console.WriteLine("\nIngrese la elaboracion de la receta: ");
                    recetaTemp.ElaboracionBody = Console.ReadLine();
                    Console.WriteLine("\nIngrese el tiempo de coccion: ");
                    recetaTemp.TiempoCoccion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nIngrese la cantidad de porciones :");
                    recetaTemp.CantPorciones = Convert.ToInt32(Console.ReadLine());
                    recetaTemp.Imagen = "Imagen" + rnd.Next(1000) + ".png";
                    recetaTemp.UrlVideo = "youtube.com";
                    Console.WriteLine("\nIngrese el sitema de medidas: ");
                    Console.WriteLine("1- Imperial (Sistema Ingles)");
                    Console.WriteLine("2- Sistema Metrico.");
                    int tempOpt = Convert.ToInt32(Console.ReadLine());
                    if (tempOpt == 1)
                    {
                        recetaTemp.Medidas = false;
                    }
                    if (tempOpt == 2)
                    {
                        recetaTemp.Medidas = true;
                    }
                    else {
                        Console.WriteLine("Ingrese una opcion correcta!");
                    }
                    recetas.RecetasList.Add(recetaTemp);
                    Console.WriteLine();
                    Console.WriteLine("\nReceta agregada!");
                    Console.WriteLine("Presione cualquier tecla para volver al menu.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("--------- AMCG - Ver Recetas ---------");
                    for (var i = 0; i < recetas.RecetasList.Count; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("----------Receta Nro."+i+"------------");
                        Console.WriteLine("* Nombre de receta: "+recetas.RecetasList[i].Nombre);
                        Console.WriteLine("* ID de receta: " + recetas.RecetasList[i].Id);
                        Console.WriteLine("----------------------------------");
                    }

                    Console.WriteLine("\nPresione cualquier tecla para volver al menu.");
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
