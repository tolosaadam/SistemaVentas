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

        private string cuit;
        public string CUIT
        {
            get { return cuit; }
            set
            {
                if (value.Trim().Length < 11 || value.Trim().Length > 11)
                {
                    throw new Exception("El campo CUIT debe tener 11 caracteres");
                }
                cuit = value.Trim();
            }
        }
    }
}
