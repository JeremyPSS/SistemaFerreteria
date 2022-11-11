using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class SucursalCE
    {
        private int id_Sucursal;
        private string nombre;
        private int id_Direccion;

        public SucursalCE()
        {
        }

        public SucursalCE(int id_Sucursal, string nombre, int id_Direccion)
        {
            this.Id_Sucursal = id_Sucursal;
            this.Nombre = nombre;
            this.Id_Direccion = id_Direccion;
        }

        public int Id_Sucursal { get => id_Sucursal; set => id_Sucursal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_Direccion { get => id_Direccion; set => id_Direccion = value; }
    }
}
