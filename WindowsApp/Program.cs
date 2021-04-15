using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;



namespace WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Categoria categoria1 = new Categoria("Lacteo");
            Categoria categoria2 = new Categoria("light");
            DatoContacto datoContacto1 = new DatoContacto("Juan@gmail.com", "Altamira 111", "45454545");
            Persona persona1 = new Persona("Juan", "Perez", datoContacto1);
            Empresa empresa1 = new Empresa("Sancor", "20304589", persona1, datoContacto1);

            Producto producto1 = new Producto("Leche","Light verde",3,1.25,21,empresa1,categoria1,categoria2);
            var a = producto1.PrecioBruto;

            Console.WriteLine(a);
            
            
            Console.WriteLine(producto1.Nombre);
        }
    }
}
