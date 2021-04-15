using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo:Persona
    {
        
        public ClienteIndividuo() { }
        public ClienteIndividuo (string nombre,string apellido,string cuit,DatoContacto datoContacto):base (nombre,apellido,datoContacto)
        {
            CUIT = cuit;
        }
  
        public string CUIT { get; set; }
    
    }
}
