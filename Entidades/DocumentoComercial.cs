using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocumentoComercial
    {
        public DocumentoComercial() { }
        public DocumentoComercial(string numero,DateTime fecha,string cliente,string direccion,string condicionIVA,string condicionVenta,List<Item> detalle,decimal total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIVA;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            Total = total;
        }


        private string numero;
        public string Numero
        {
            get { return numero; }
            set
            {
                if (value.Trim().Length < 13 || value.Trim().Length > 13)
                {
                    throw new Exception("El campo numero de Documento Comercial no puede estar vacio y debe tener 13 caracteres");
                }
                numero = value.Trim();
            }
        }
        public DateTime Fecha { get; set; }
        private string cliente;
        public string Cliente
        {
            get { return cliente; }
            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 100)
                {
                    throw new Exception("El campo cliente no puede estar vacio o superar los 100 caracteres");
                }
                cliente = value.Trim();
            }
        }
        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (value.Trim().Length < 15 || value.Trim().Length > 100)
                {
                    throw new Exception("El campo direccion no puede estar vacio o superar los 100 caracteres");
                }
                direccion = value.Trim();
            }
        }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public List<Item> Detalle { get; set; }
        public decimal Total { get;}
    }
}
