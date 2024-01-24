using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class ClsProducto
    {
        // Atributos
        public int Codigo;
        public string Descripcion;
        public int Existencia;
        public int Minimo;
        public float Precio;

        // Constructor
        public ClsProducto(int codigo, string descripcion, int existencia, int minimo, float precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Existencia = existencia;
            Minimo = minimo;
            Precio = precio;
        }

        // Constructor
        public ClsProducto(int codigo)
        {
            Codigo = codigo;
        }
        public ClsProducto() { }
        public void Agregar()
        {
            Console.WriteLine("Digite el codigo");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la Descripcion");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Digite La existencia");
            int existencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el minimo");
            int minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite precio");
            float precio = float.Parse(Console.ReadLine());

            var lista = new List<ClsProducto>();
            lista.Add (new ClsProducto(cod, descripcion,existencia,minimo,precio));

            
            Console.WriteLine("Elementos de la lista");
            foreach (var item in lista)
            {
                
                Console.WriteLine(item.Codigo + " " + item.Descripcion);
            }
            Console.Read();
        }


    }
}
