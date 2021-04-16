using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {

        public Empresa() { }
        public Empresa(string nombre, string cuit, Persona contacto,DatoContacto datoContacto)
        {
            Nombre = nombre;
            CUIT = cuit;
            Contacto = contacto;
            DatoContacto = datoContacto;
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre de la empresa no puede estar vacio o superar los 50 caracteres");
                }
                nombre = value.Trim();
            }
        }
        public string CUIT { get; set; }
        public Persona Contacto { get; set; }
        public DatoContacto DatoContacto { get; set; }
        
    }
    


}
