using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public Categoria(string nombre)
        {
            Nombre = nombre;
        }
        public string Nombre { get; set; }
    }
}
