using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMCGlib
{
    class Ingrediente
    {
        // Val = porcentaje cada 100 gramos. 
        private string nombre;
        private int valCalorias;
        private int valTrans;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int ValCalorias
        {
            get { return valCalorias; }
            set { valCalorias = value; }
        }

        public int ValTrans
        {
            get { return valTrans; }
            set { valTrans = value; }
        }
    }
}
