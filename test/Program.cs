using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria categoria1 = new Categoria("Lacteo");
            Categoria categoria2 = new Categoria("light");
            DatoContacto datoContacto2 = new DatoContacto("Juan@gmail.com", "Altamira 1111111111111111111", "");          //Comprando que no es obligatorio que le pase un telefono, y si le paso debe tener 15 caracteres
            Console.WriteLine(datoContacto2.Telefono);
            try
            {
                DatoContacto datoContacto1 = new DatoContacto("Juan@gmail.com", "Altamira 111", "45454545");
                Console.WriteLine(datoContacto1.Direccion);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Persona persona1 = new Persona("Juan", "Perez",datoContacto2);
            Empresa empresa1 = new Empresa("Sancor", "20304589", persona1, datoContacto2);
            Producto producto1 = new Producto("Leche", "Light verde", 3, 1.25, 21,empresa1, categoria1,categoria2);

            // ----------------------------------------------------------------------------------------------------------- Proyecto 06
            try
            {
                Persona persona3 = new Persona("", "Tolosa", datoContacto2);     //   La comento porque sino tira error (Es para validar la excepcion que puse del nombre en la clase Persona)
                Console.WriteLine(persona3.Nombre);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Persona persona4 = new Persona("Adam", "Tolosa", datoContacto2);
            Console.WriteLine(persona4.Nombre + " " +  persona4.DatoContacto.Telefono + " "  + persona4.DatoContacto.Direccion);
            string a;
            a = Console.ReadLine();
            Console.WriteLine(producto1.PrecioBruto);
        }
    }
}
