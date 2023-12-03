using clientepaarmi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientepaarmi.Servicios
{
    internal interface ClienteI
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua);

       
        public void borrarCliente(List<ClienteDto> listaAntigua);

        
        public void modificarCliente(List<ClienteDto> listaAntigua);

        public string pedirDni();

    }
}
