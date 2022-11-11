using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class ProveedorCE
    {
        private int id_Proveedor;
        private string nombre;
        private int id_Direccion;
        private string telefono;
        private string email;

        public ProveedorCE()
        {
        }

        public ProveedorCE(int id_Proveedor, string nombre, int id_Direccion, string telefono, string email)
        {
            this.Id_Proveedor = id_Proveedor;
            this.Nombre = nombre;
            this.Id_Direccion = id_Direccion;
            this.Telefono = telefono;
            this.Email = email;
        }

        public int Id_Proveedor { get => id_Proveedor; set => id_Proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_Direccion { get => id_Direccion; set => id_Direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
