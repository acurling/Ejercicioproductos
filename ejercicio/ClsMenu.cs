using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class ClsMenu
    {

        public static int opcion;

        public static void menu()
        {
            ClsProducto articulo = new ClsProducto();
            do
            {
                Console.WriteLine("1- Agregar Productos");
                Console.WriteLine("2- Venta de Productos");
                Console.WriteLine("3- Actualizar Productos");
                Console.WriteLine("4- Actualizar Precio ");
                Console.WriteLine("5- Reporte ");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opcion...");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: articulo.Agregar(); break;
                    case 2: Console.WriteLine("opcion 2"); break;
                    case 3: Console.WriteLine("opcion 3");  break;
                    case 4: Console.WriteLine("opcion 4"); break;
                    case 5: Console.WriteLine("opcion 5"); break;
                    default: Console.WriteLine("Opcion incorrecta"); break;
                }

            } while (opcion!=6);
   
        }


    }
}
