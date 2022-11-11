using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class DireccionLN
    {
        /*
        public List<DireccionCE> ViewDireccion()
        {
            DireccionCE op;
            List<DireccionCE> Lista = new List<DireccionCE>();
            try
            {
                List<PROVEEDOR> aux = DireccionCD.ListarDireccion();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new DireccionCE(prov.IdDireccion, prov.CedDireccion, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del Direccion", ex);
            }

            return Lista;
        }
        public List<DireccionCE> ViewDireccionFiltro(string valor)
        {
            DireccionCE op;
            List<DireccionCE> Lista = new List<DireccionCE>();
            try
            {
                List<cp_ListarDireccionFiltroResult> aux = DireccionCD.ListarDireccionFiltro(valor);
                foreach (cp_ListarDireccionFiltroResult prov in aux)
                {
                    op = new DireccionCE(prov.IdDireccion, prov.CedDireccion, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del Direccion", ex);
            }

            return Lista;
        }

        public bool CreateDireccion(DireccionCE op)
        {
            try
            {
                DireccionCD.InsertarDireccion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del Direccion", ex);
            }
        }

        public bool UpdateDireccion(DireccionCE op)
        {
            try
            {
                DireccionCD.ModificarDireccion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update Direccion", ex);
            }
        }

        public bool DeleteDireccion(DireccionCE op)
        {
            try
            {
                DireccionCD.EliminarDireccion(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete Direccion", ex);
            }
        }

        */
        /*
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
