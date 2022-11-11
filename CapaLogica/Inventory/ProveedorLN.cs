using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class ProveedorLN
    {
        /*
        public List<ProductoCE> ViewProveedor()
        {
            ProductoCE op;
            List<ProductoCE> Lista = new List<ProductoCE>();
            try
            {
                List<ProductoCE> aux = ProveedorCD.ListarProveedor();
                foreach (ProductoCE prov in aux)
                {
                    op = new ProductoCE(prov.IdProveedor, prov.CedProveedor, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del ProductoCE", ex);
            }

            return Lista;
        }
        public List<ProductoCE> ViewProveedorFiltro(string valor)
        {
            ProductoCE op;
            List<ProductoCE> Lista = new List<ProductoCE>();
            try
            {
                List<cp_ListarProveedorFiltroResult> aux = ProveedorCD.ListarProveedorFiltro(valor);
                foreach (cp_ListarProveedorFiltroResult prov in aux)
                {
                    op = new ProductoCE(prov.IdProveedor, prov.CedProveedor, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del ProductoCE", ex);
            }

            return Lista;
        }

        public bool CreateProveedor(ProductoCE op)
        {
            try
            {
                ProveedorCD.InsertarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del ProductoCE", ex);
            }
        }

        public bool UpdateProveedor(ProductoCE op)
        {
            try
            {
                ProveedorCD.ModificarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update ProductoCE", ex);
            }
        }

        public bool DeleteProveedor(ProductoCE op)
        {
            try
            {
                ProveedorCD.EliminarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete ProductoCE", ex);
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
