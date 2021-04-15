using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito:DocumentoComercial
    {
        public Remito(string nombre,DateTime fecha,string cliente, string direccion, string condicionIVA,string condicionVenta,List<Item> detalle,DateTime fechaEntrega,decimal total):base (nombre, fecha,direccion,cliente,condicionIVA,condicionVenta,detalle,total)
        {
            Nombre = nombre;
            FechaEntrega = fechaEntrega;
        }
        public string Nombre { get; set; }
        public DateTime FechaEntrega { get; set; }
        
    }
}
