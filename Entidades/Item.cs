using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Item
    {
        public Item (int cantidad,string descripcion,decimal precioUnitario,decimal importe)
        {
            Cantidad = cantidad;
            Descripcion = descripcion;
            PrecioUnitario = precioUnitario;
            Importe = importe;
        }
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value  < 1)
                {
                    throw new Exception("La cantidad de items no puede ser menor a 1 ");
                }
                cantidad = value;
            }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set 
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El campo Descripcion del item es obligatorio y no puede tener mas de 50 caracter");
                }
                descripcion = value.Trim();
            }
        }
        private decimal precioUnitario;
        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set
            {
                if (value < Convert.ToDecimal(0.1))
                {
                    throw new Exception("El valor del precio unitario no puede ser menor a 0.1");
                }
                precioUnitario = value;
            }
        }
        public decimal Importe { get; }
    }  
}
