using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBLTallerObjetos
{
    public class Recetas
    {
        public int id;
        public string nombre;
        public string descripcion;
        public string elaboracionBody;
        public int tiempoCoccion;
        public int cantPorciones;
        public string imagen = "IMGtest.png"; //default
        public string urlVideo;
        public bool medidas = true; //True -> Metrico, Fasle -> Ingles

    }
}
