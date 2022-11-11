using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class Modo_PagoCE
    {
        private int num_Pago;
        private string nombre;
        private string detalles;

        public Modo_PagoCE()
        {
        }

        public Modo_PagoCE(int num_Pago, string nombre, string detalles)
        {
            this.Num_Pago = num_Pago;
            this.Nombre = nombre;
            this.Detalles = detalles;
        }

        public int Num_Pago { get => num_Pago; set => num_Pago = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Detalles { get => detalles; set => detalles = value; }
    }
}
