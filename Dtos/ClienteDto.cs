using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientepaarmi.Dtos
{
    internal class ClienteDto
    {
        int id;
        string name;
        string apellidos;
        string fechaAlta;
        string dni;
        string fechaBaja;

        

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }

        public ClienteDto(int id, string name, string apellidos, string fechaAlta, string dni, string fechaBaja)
                {
                    this.id = id;
                    this.name = name;
                    this.apellidos = apellidos;
                    this.fechaAlta = fechaAlta;
                    this.dni = dni;
                    this.fechaBaja = fechaBaja;
                }
         public ClienteDto() { }

        override
        public string ToString()
        {
            string cliente = "Nombre;  " + this.name
                + "Apellidos;  " + this.apellidos
                + "Dni;  " + this.dni
                + "FAlta;" + this.fechaAlta
                + "fBaja;  " + this.fechaBaja;
            return cliente; 
        }
    }
}
