using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class Producto_ProveedorCE
    {
        private int id_Producto;
        private int id_Proveedor;
        private DateTime fecha_Entrega;

        public Producto_ProveedorCE()
        {
        }

        public Producto_ProveedorCE(int id_Producto, int id_Proveedor, DateTime fecha_Entrega)
        {
            this.Id_Producto = id_Producto;
            this.Id_Proveedor = id_Proveedor;
            this.Fecha_Entrega = fecha_Entrega;
        }

        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public int Id_Proveedor { get => id_Proveedor; set => id_Proveedor = value; }
        public DateTime Fecha_Entrega { get => fecha_Entrega; set => fecha_Entrega = value; }
    }
}
