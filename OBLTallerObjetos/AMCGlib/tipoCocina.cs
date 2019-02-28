using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMCGlib
{
    public class tipoCocina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private List<string> tipoCocina_List = new List<string>();

        public List<string> TipoCocina_List
        {
            get { return tipoCocina_List; }
            set { tipoCocina_List = value; }
        }
        

    }
}
