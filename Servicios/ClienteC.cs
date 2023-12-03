using clientepaarmi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientepaarmi.Servicios
{
    internal class ClienteC : ClienteI
    {
        public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            string dniBuscar = pedirDni();
            ClienteDto aBorra = new ClienteDto();
            foreach(ClienteDto cliente in listaAntigua)
            {
                if(cliente.Dni.Equals(dniBuscar))
                {
                   aBorra = cliente;
                        break;
                }
            }
            listaAntigua.Remove(aBorra);
            /*
             int i ;
            bool a = false ;
            
            for( i= 0; i< listaAntigua.Count; i++)
            {
                if (listaAntigua[i].Dni.Equals(dniBuscar))
                {
                    a = true;   
                    break;
                }
            }
            if (a)
            {
                listaAntigua.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("no existe");
            }*/

        }

        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto nuevo = nuevocliente();
            listaAntigua.Add(nuevo);
        }
        private ClienteDto nuevocliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.Name = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.Apellidos = Console.ReadLine();

            Console.WriteLine("Introduzca el dni: ");
            nuevoCliente.Dni = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            nuevoCliente.FechaAlta = Console.ReadLine();

            return nuevoCliente;
        }

        

        public string pedirDni()
        {
            Console.WriteLine("Indica el DNI del cliente: ");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }
        public void modificarCliente(List<ClienteDto> listaAntigua)
         {
            string dniBuscar = pedirDni();
            foreach(ClienteDto cliente in listaAntigua)
            {
                if (cliente.Dni.Equals(dniBuscar))
                {
                    int eleccion = menumodificar();
                    bool abrir = true;
                    while(abrir)
                    {
                        abrir = modificarCliente(cliente,  eleccion);
                    }
                    
                }
            }

        }
        private int menumodificar()
        {
            Console.WriteLine("0. Cerrar menú");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Apellido");
            Console.WriteLine("4. fechanacimientyp");

            Console.WriteLine("4. Dni");
            
            int opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }
        private bool modificarCliente(ClienteDto clienteAModificar, int eleccion)
        {
            bool abrir = true;
            switch (eleccion) 
            {
                case 0:
                    abrir = false;
                    break;
                case 1:
                    Console.WriteLine("Escriba nuevo nombre: ");
                    clienteAModificar.Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Escriba nuevo apellido: ");
                    clienteAModificar.Apellidos = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Escriba nuevo fecha nacimiento: ");
                    clienteAModificar.FechaAlta = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Escriba nuevo dni: ");
                    clienteAModificar.Dni = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("no coincide");
                    break;
            }
            return abrir;   

        }
    }
}
