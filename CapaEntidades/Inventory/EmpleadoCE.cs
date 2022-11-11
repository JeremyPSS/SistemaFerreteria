using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Inventory
{
    public class EmpleadoCE
    {
        private int id_Empleado;
        private int cedula;
        private string nombre;
        private string apellido;
        private string telefono;
        private int id_Direccion;
        private string email;
        private int id_Tipo;

        public EmpleadoCE()
        {
        }

        public EmpleadoCE(int id_Empleado, int cedula, string nombre, string apellido, string telefono, int id_Direccion, string email, int id_Tipo)
        {
            this.Id_Empleado = id_Empleado;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Id_Direccion = id_Direccion;
            this.Email = email;
            this.Id_Tipo = id_Tipo;
        }

        public int Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Id_Direccion { get => id_Direccion; set => id_Direccion = value; }
        public string Email { get => email; set => email = value; }
        public int Id_Tipo { get => id_Tipo; set => id_Tipo = value; }
    }
}
