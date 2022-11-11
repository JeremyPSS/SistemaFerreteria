using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class ClienteCE
    {
        private int id_Cliente;
        private string nombre;
        private string apellido;
        private int id_Direccion;
        private string telefono;
        private string email;

        public ClienteCE()
        {
        }

        public ClienteCE(int id_Cliente, string nombre, string apellido, int id_Direccion, string telefono, string email)
        {
            this.Id_Cliente = id_Cliente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Id_Direccion = id_Direccion;
            this.Telefono = telefono;
            this.Email = email;
        }

        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id_Direccion { get => id_Direccion; set => id_Direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
