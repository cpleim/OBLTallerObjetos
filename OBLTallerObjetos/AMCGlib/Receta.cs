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

    }
    }
