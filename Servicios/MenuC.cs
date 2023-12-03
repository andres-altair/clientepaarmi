using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientepaarmi.Servicios
{
    internal class MenuC : MenuI
    {
        public int mostrarMenu()
        {
            Console.WriteLine("#############################");
            Console.WriteLine("0. Cerra aplicacion");
            Console.WriteLine("1. Alta cliente");
            Console.WriteLine("2. Modificar cliente");
            Console.WriteLine("3. Eliminar cliente");
            Console.WriteLine("4. Ver clientes");
            Console.WriteLine("#############################");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            return eleccion;
        }
    }
}
