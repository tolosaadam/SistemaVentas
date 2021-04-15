using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura:DocumentoComercial
    {
  
        public Factura(DateTime fecha, string tipo, string numero, string cliente, string direccion, string condicionIVA, string condicionVenta, List<Item> detalle, decimal total):base (numero, fecha,cliente,direccion,condicionIVA,condicionVenta,detalle,total)
        {
            Tipo = tipo;
        }
        public string Tipo { get; set; }

    }
}
