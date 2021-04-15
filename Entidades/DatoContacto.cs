using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatoContacto
    {
        public DatoContacto(string email,string direccion,string telefono)
        {
            Email = email;
            Direccion = direccion;
            Telefono = telefono;
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Trim().Length < 6 || value.Trim().Length > 50)
                {
                    throw new Exception("El campo mail no puede estar vacio y  debe tener un minimo de 6 caracteres y un  máximo de 50");
                }
                email = value.Trim();
            }
        }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
