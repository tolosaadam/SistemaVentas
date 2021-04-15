﻿using System;
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


        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public List<Item> Detalle { get; set; }
        public decimal Total { get;}
    }
}
