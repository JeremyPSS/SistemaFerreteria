using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class TipoCE
    {
        private int id_Tipo;
        private string rol;
        private string estado;

        public TipoCE()
        {
        }

        public TipoCE(int id_Tipo, string rol, string estado)
        {
            this.Id_Tipo = id_Tipo;
            this.Rol = rol;
            this.Estado = estado;
        }

        public int Id_Tipo { get => id_Tipo; set => id_Tipo = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
