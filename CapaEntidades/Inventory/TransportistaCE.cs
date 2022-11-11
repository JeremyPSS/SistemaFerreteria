using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class TransportistaCE
    {
        private int id_Transportista;
        private string cedula;
        private string nombre;
        private int id_Direccion;
        private string telefono;

        public TransportistaCE()
        {
        }

        public TransportistaCE(int id_Transportista, string cedula, string nombre, int id_Direccion, string telefono)
        {
            this.Id_Transportista = id_Transportista;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Id_Direccion = id_Direccion;
            this.Telefono = telefono;
        }

        public int Id_Transportista { get => id_Transportista; set => id_Transportista = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_Direccion { get => id_Direccion; set => id_Direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
