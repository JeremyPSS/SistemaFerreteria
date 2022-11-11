using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class DetalleCE
    {
        private int numDetalle;
        private int id_Factura;
        private int id_Producto;
        private int cantidad;
        private double precio;

        public DetalleCE()
        {
        }

        public DetalleCE(int numDetalle, int id_Factura, int id_Producto, int cantidad, double precio)
        {
            this.NumDetalle = numDetalle;
            this.Id_Factura = id_Factura;
            this.Id_Producto = id_Producto;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public int NumDetalle { get => numDetalle; set => numDetalle = value; }
        public int Id_Factura { get => id_Factura; set => id_Factura = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
