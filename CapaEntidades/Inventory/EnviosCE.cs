using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class EnviosCE
    {
        private int id_Envio;
        private int id_Direccion;
        private string telefono;
        private int id_Producto;
        private int id_Transportista;

        public EnviosCE()
        {
        }

        public EnviosCE(int id_Envio, int id_Direccion, string telefono, int id_Producto, int id_Transportista)
        {
            this.Id_Envio = id_Envio;
            this.Id_Direccion = id_Direccion;
            Telefono = telefono;
            this.Id_Producto = id_Producto;
            this.Id_Transportista = id_Transportista;
        }

        public int Id_Envio { get => id_Envio; set => id_Envio = value; }
        public int Id_Direccion { get => id_Direccion; set => id_Direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public int Id_Transportista { get => id_Transportista; set => id_Transportista = value; }
    }
}
