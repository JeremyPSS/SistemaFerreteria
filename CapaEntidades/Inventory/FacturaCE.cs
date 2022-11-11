using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class FacturaCE
    {
        private int num_Factura;
        private int id_Cliente;
        private DateTime fecha;
        private int id_Producto;
        private int num_Pago;
        private int id_Empleado;

        public FacturaCE()
        {
        }

        public FacturaCE(int num_Factura, int id_Cliente, DateTime fecha, int id_Producto, int num_Pago, int id_Empleado)
        {
            this.Num_Factura = num_Factura;
            this.Id_Cliente = id_Cliente;
            this.Fecha = fecha;
            this.Id_Producto = id_Producto;
            this.Num_Pago = num_Pago;
            this.Id_Empleado = id_Empleado;
        }

        public int Num_Factura { get => num_Factura; set => num_Factura = value; }
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public int Num_Pago { get => num_Pago; set => num_Pago = value; }
        public int Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
    }
}
