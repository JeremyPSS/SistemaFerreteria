using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class SucursalLN
    {
        /*
        public List<SucursalCE> ViewSucursal()
        {
            SucursalCE op;
            List<SucursalCE> Lista = new List<SucursalCE>();
            try
            {
                List<PROVEEDOR> aux = SucursalCD.ListarSucursal();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new SucursalCE(prov.IdSucursal, prov.CedSucursal, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del SucursalCE", ex);
            }

            return Lista;
        }
        public List<SucursalCE> ViewSucursalFiltro(string valor)
        {
            SucursalCE op;
            List<SucursalCE> Lista = new List<SucursalCE>();
            try
            {
                List<cp_ListarSucursalFiltroResult> aux = SucursalCD.ListarSucursalFiltro(valor);
                foreach (cp_ListarSucursalFiltroResult prov in aux)
                {
                    op = new SucursalCE(prov.IdSucursal, prov.CedSucursal, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del SucursalCE", ex);
            }

            return Lista;
        }

        public bool CreateSucursal(SucursalCE op)
        {
            try
            {
                SucursalCD.InsertarSucursal(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del proveedor", ex);
            }
        }

        public bool UpdateSucursal(SucursalCE op)
        {
            try
            {
                SucursalCD.ModificarSucursal(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update proveedor", ex);
            }
        }

        public bool DeleteSucursal(SucursalCE op)
        {
            try
            {
                SucursalCD.EliminarSucursal(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete proveedor", ex);
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
