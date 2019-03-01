using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMCGlib
{
    public class Receta
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string elaboracionBody;
        private int tiempoCoccion;
        private int cantPorciones;
        private string imagen;
        private string urlVideo;
        private bool medidas = true; //True -> Metrico, Fasle -> Ingles
        private List<Receta> recetasList = new List<Receta>();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public string ElaboracionBody
        {
            get { return elaboracionBody; }
            set { elaboracionBody = value; }
        }
        
        public int TiempoCoccion
        {
            get { return tiempoCoccion; }
            set { tiempoCoccion = value; }
        }
        
        public int CantPorciones
        {
            get { return cantPorciones; }
            set { cantPorciones = value; }
        }
        
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        
        public string UrlVideo
        {
            get { return urlVideo; }
            set { urlVideo = value; }
        }

        public bool Medidas
        {
            get { return medidas; }
            set { medidas = value; }
        }

        public List<Receta> RecetasList
        {
            get { return recetasList; }
            set { recetasList = value; }
        }

        public static Receta crearReceta()
        {
            Receta recetaTemp = new Receta();
            Receta recetas = new Receta();
            Random rnd = new Random();

            recetaTemp.Id = rnd.Next(1000);
            recetaTemp.Nombre = "PAPITAS AL HORNO";
            recetaTemp.Descripcion = "PAPITAS AL RE HORNO";
            recetaTemp.ElaboracionBody = "TE METES LAS PAPITAS BIEN EN EL HORNO";
            recetaTemp.TiempoCoccion = 33;
            recetaTemp.CantPorciones = 5;
            recetaTemp.Imagen = "Imagen" + rnd.Next(1000) + ".png";
            recetaTemp.UrlVideo = "youtube.com";
            recetaTemp.Medidas = true;
            recetas.RecetasList.Add(recetaTemp);
            Console.WriteLine();
            Console.WriteLine("\nReceta agregada!");
            Console.WriteLine("Presione cualquier tecla para volver al menu.");
            Console.ReadKey();

            return recetaTemp;
        }

    }
    }
