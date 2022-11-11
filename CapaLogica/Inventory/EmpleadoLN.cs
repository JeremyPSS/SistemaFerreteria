using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class EmpleadoLN
    {
        /*
        public List<EmpleadoCE> ViewEmpleado()
        {
            EmpleadoCE op;
            List<EmpleadoCE> Lista = new List<EmpleadoCE>();
            try
            {
                List<PROVEEDOR> aux = EmpleadoCD.ListarEmpleado();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new EmpleadoCE(prov.IdEmpleado, prov.CedEmpleado, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del EmpleadoCE", ex);
            }

            return Lista;
        }
        public List<EmpleadoCE> ViewEmpleadoFiltro(string valor)
        {
            EmpleadoCE op;
            List<EmpleadoCE> Lista = new List<EmpleadoCE>();
            try
            {
                List<cp_ListarEmpleadoFiltroResult> aux = EmpleadoCD.ListarEmpleadoFiltro(valor);
                foreach (cp_ListarEmpleadoFiltroResult prov in aux)
                {
                    op = new EmpleadoCE(prov.IdEmpleado, prov.CedEmpleado, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del EmpleadoCE", ex);
            }

            return Lista;
        }

        public bool CreateEmpleado(EmpleadoCE op)
        {
            try
            {
                EmpleadoCD.InsertarEmpleado(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del EmpleadoCE", ex);
            }
        }

        public bool UpdateEmpleado(EmpleadoCE op)
        {
            try
            {
                EmpleadoCD.ModificarEmpleado(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update EmpleadoCE", ex);
            }
        }

        public bool DeleteEmpleado(EmpleadoCE op)
        {
            try
            {
                EmpleadoCD.EliminarEmpleado(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete EmpleadoCE", ex);
            }
        }
        public bool ExisteGuia(int idGuia)
        {
            bool estado = false;
            List<Guia> aux = ViewGuia();
            foreach (Guia ob in aux)
            {
                if (ob.IdGuia == idGuia)
                {
                    estado = true;
                    break;
                }
            }
            return estado;
        }

        public Guia GetGuia(int IdGuia)
        {
            Guia resu = null;
            List<Guia> aux = ViewGuia();
            foreach (Guia ob in aux)
            {
                if (ob.IdGuia == IdGuia)
                {
                    return ob;
                }
            }
            return resu;
        }
        */
    }
}
