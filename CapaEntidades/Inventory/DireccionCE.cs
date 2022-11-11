using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class DireccionCE
    {
        private int id_Direccion;
        private string ciudad;
        private string calles;

        public DireccionCE()
        {
        }

        public DireccionCE(int id_Direccion, string ciudad, string calles)
        {
            this.Id_Direccion = id_Direccion;
            this.Ciudad = ciudad;
            this.Calles = calles;
        }

        public int Id_Direccion { get => id_Direccion; set => id_Direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Calles { get => calles; set => calles = value; }
    }
}
