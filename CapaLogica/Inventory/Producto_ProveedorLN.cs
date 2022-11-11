using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class Producto_ProveedorLN
    {
        /*
        public List<Producto_ProveedorCE> ViewProducto_Proveedor()
        {
            Producto_ProveedorCE op;
            List<Producto_ProveedorCE> Lista = new List<Producto_ProveedorCE>();
            try
            {
                List<Producto_ProveedorCE> aux = ProveedorCD.ListarProveedor();
                foreach (Producto_ProveedorCE prov in aux)
                {
                    op = new Producto_ProveedorCE(prov.IdProveedor, prov.CedProveedor, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del Producto_ProveedorCE", ex);
            }

            return Lista;
        }
        public List<Producto_ProveedorCE> ViewProducto_ProveedorFiltro(string valor)
        {
            Producto_ProveedorCE op;
            List<Producto_ProveedorCE> Lista = new List<Producto_ProveedorCE>();
            try
            {
                List<cp_ListarProveedorFiltroResult> aux = ProveedorCD.ListarProveedorFiltro(valor);
                foreach (cp_ListarProveedorFiltroResult prov in aux)
                {
                    op = new Producto_ProveedorCE(prov.IdProveedor, prov.CedProveedor, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del Producto_ProveedorCE", ex);
            }

            return Lista;
        }

        public bool CreateProducto_Proveedor(Producto_ProveedorCE op)
        {
            try
            {
                ProveedorCD.InsertarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del Producto_ProveedorCE", ex);
            }
        }

        public bool UpdateProducto_Proveedor(Producto_ProveedorCE op)
        {
            try
            {
                ProveedorCD.ModificarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update Producto_ProveedorCE", ex);
            }
        }

        public bool DeleteProducto_Proveedor(Producto_ProveedorCE op)
        {
            try
            {
                ProveedorCD.EliminarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete Producto_ProveedorCE", ex);
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
