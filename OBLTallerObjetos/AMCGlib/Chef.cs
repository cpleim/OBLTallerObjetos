using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMCGlib
{
    public class Chef
    {
        private string nombre;
        private string pais;
        private string email;
        private string password;
        //El tipo de cocina se encuentra en la clase "tipoCocina"

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static Chef buscarChef()
        {
            throw new NotImplementedException();
        }
    }
}
