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
            //SUMMARY
           /*
            * Inicializador
            */

           //TODO
            /*
             * Mover el for al metodo "Crear Receta".
             * Mover la lista de tipos de receta a la clase Receta, renombrarla como "presetTiposCocina" e instanciarla en el metodo Main de la clase Starter.
             */

           //FIXME
           /*
            * El random se manda cualquiera y genera numeros repetidos para cada objeto generado por el For (Ya se por que es).
            */
           var tiposCocina = new List<string> { "Internacional", "Mexicana", "Oriental", "Italiana", "Reposteria Alemana" }; //Lista con presets de tipos de recetas
           int indexTipos;
           string tipoChosed;

           Random rnd = new Random();
           Receta receta = new Receta();
           tipoCocina tipos = new tipoCocina();

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
                //Para elegir el tipo de cocina
                indexTipos = rnd.Next(tiposCocina.Count); //Elige un nro random de indice de la lista
                tipoChosed = tiposCocina[indexTipos];
                tipos.TipoCocina_List.Add(tipoChosed);//Lo agrega a la lista de la clase tipoCocina
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
            Console.WriteLine("------- Usuario no administrativo ------"); //FIXME
            Console.WriteLine();
            Console.WriteLine("1. Ingreso de recetas"); //Solo si el rol es administrador. Establecer este control.
            Console.WriteLine("2. Ver recetas");
            Console.WriteLine("3. Salir");
            Console.WriteLine();
            var result = Console.ReadLine();
            var option = Convert.ToInt32(result);

            switch (option)
            {
                case 1:
                   var objtemp = Receta.crearReceta();
                   recetas.RecetasList.Add(objtemp);
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
