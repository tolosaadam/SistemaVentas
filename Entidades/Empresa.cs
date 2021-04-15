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
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public Persona Contacto { get; set; }
        public DatoContacto DatoContacto { get; set; }
        
    }
    


}
