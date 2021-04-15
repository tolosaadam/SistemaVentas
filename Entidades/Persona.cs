using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public Persona() { }
        public Persona(string nombre,string apellido,DatoContacto datoContacto)
        {
            Nombre = nombre;
            Apellido = apellido;
            DatoContacto = datoContacto;
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if(value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede estar vacio o superar los 50 caracteres");
                }
                nombre = value.Trim();
            }
        }
        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El apellido no puede estar vacio o superar los 50 caracteres");
                }
                apellido = value.Trim();
            }
        }
        public  DatoContacto DatoContacto { get; set; }

        
    }
}
