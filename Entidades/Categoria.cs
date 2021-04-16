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
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre de la categoria no puede estar vacio o superar los 50 caracteres");
                }
                nombre = value.Trim();
            }
        }
    }
}
