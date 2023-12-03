using clientepaarmi;
using clientepaarmi.Dtos;
using clientepaarmi.Servicios;

class Program
{
     static void Main(string[] args)
    {
        List<ClienteDto> ClienteC = new List<ClienteDto>();

        MenuI mI = new MenuC();
        ClienteI ci = new ClienteC();
        int eleccion;
        bool abrir = false; 
        while(!abrir)
        {
            eleccion = mI.mostrarMenu();
            switch (eleccion)
            {
                case 0:
                    Console.WriteLine("cerrar");
                    abrir = true;
                    break;
                case 1:
                    Console.WriteLine("[INFO] - ALTA NUEVO CLIENTE");
                    ci.darAltaCliente(ClienteC);
                    break;
                case 2:
                    Console.WriteLine("[INFO] - MODIFICAR CLIENTE");
                    ci.modificarCliente(ClienteC);
                    break;
                case 3:
                    Console.WriteLine("[INFO] - ELIMINAR UN CLIENTE");
                    ci.borrarCliente(ClienteC);
                    break;
                case 4:
                    Console.WriteLine("[INFO] - VER CLIENTE");
                    foreach (ClienteDto cliente in ClienteC)
                    {
                        Console.WriteLine(cliente.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                    break;

            }
        }
    }
}
