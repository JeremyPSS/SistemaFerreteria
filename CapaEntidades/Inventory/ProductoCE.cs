using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class ProductoCE
    {
        private int id_Producto;
        private string nombre;
        private double precio;
        private int stock;
        private int id_Categoria;

        public ProductoCE()
        {
        }

        public ProductoCE(int id_Producto, string nombre, double precio, int stock, int id_Categoria)
        {
            this.Id_Producto = id_Producto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.Id_Categoria = id_Categoria;
        }

        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id_Categoria { get => id_Categoria; set => id_Categoria = value; }
    }
}
