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
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; }
    }  
}
