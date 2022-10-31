using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaAPIRestTest
{
    internal class Usuario
    {
        private string nombre;
        private string telefono;
        private string direccion;

        public Usuario(string nombre, string telefono, string direccion)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
