using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBLTallerObjetos
{
    class Starter
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(60, 100);
            Console.WriteLine("--------- AMCG - Menu Principal---------");
            int selectedOption = 0;
            do
            {
                selectedOption = showMainMenu();
            } while (selectedOption != 3); //num de opciones, si la opcion es 3 -> exit 
        }

        static public int showMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Ingreso de recetas");
            Console.WriteLine("2. Ver recetas");
            Console.WriteLine("3. Salir");
            Console.WriteLine();
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
