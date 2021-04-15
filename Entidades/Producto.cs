﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto() { }
        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iva, Empresa proveedor, Categoria categoria, Categoria subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            Iva = iva;
            PrecioBruto = precioCosto + Convert.ToDecimal(margen);
            PrecioVenta = Convert.ToDecimal(iva) + PrecioBruto;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
            //El IVA y el margen de ganancia se considerarán en forma decimal. Por ejemplo, 0.21 equivale a un IVA del 21%.
            //PrecioBruto = PrecioCosto + Margen
            //PrecioVenta = PrecioBruto + IVA
            //Convert.ToDecimal(1 + this.IVA)
            //Verificar que tanto los atributos como las clases sean públicas.


        }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public static double Iva { get; set; }
        public decimal PrecioBruto { get; }
        public decimal PrecioVenta { get;}
        public Empresa Proveedor { get; set; }
        public Categoria Categoria { get; set; }
        public Categoria SubCategoria { get; set; }



    }
}
