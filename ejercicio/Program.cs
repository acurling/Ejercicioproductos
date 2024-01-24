using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio
{
    internal class Program
       
    {


        static void Main(string[] args)
        {


            ClsProducto Articulo = new ClsProducto(1, "Mesa de oficina", 25, 5, 5000);
            Console.WriteLine(Articulo.Codigo + " " + Articulo.Descripcion);
            ClsMenu.menu();

            Console.Read();


        } 
    }
}
