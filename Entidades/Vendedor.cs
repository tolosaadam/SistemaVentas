using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor:Persona
    {
        public Vendedor(string nombre, string apellido, string dni,DatoContacto datoContacto):base(nombre,apellido,datoContacto)
        {
            DNI = dni;
        }

    
        public string DNI { get; set; }
    
    }
}
