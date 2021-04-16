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
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (value.Trim().Length < 15 || value.Trim().Length > 100)
                {
                    throw new Exception("El campo direccion no puede estar vacio y  debe tener un minimo de 15 caracteres y un  máximo de 100");
                }
                direccion = value.Trim();
            }
        }
        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set
            {
                
                if(value.Trim().Length > 1)
                {
                    if (value.Trim().Length < 15 || value.Trim().Length > 15)
                    {
                        throw new Exception("El campo telefono debe tener 15 caracteres");
                    }
                }
                
                
                telefono = value.Trim();
            }
        }
    }
}
