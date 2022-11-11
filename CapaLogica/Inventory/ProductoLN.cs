using CapaDatos.Inventory;
using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class ProductoLN
    {
        
        public List<ProductoCE> ViewProducto()
        {
            //ProductoCE op;
            List<ProductoCE> Lista = new List<ProductoCE>();
            try
            {
                /*
                List<PROVEEDOR> aux = ProductoCD.ListarProducto();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new ProductoCE(prov.IdProducto, prov.CedProducto, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
                */
                return ProductoCD.ListarProducto();
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del ProductoCE", ex);
                //return Lista;
            }

            //return Lista;
        }
        
        /*
        public List<ProductoCE> ViewProductoFiltro(string valor)
        {
            ProductoCE op;
            List<ProductoCE> Lista = new List<ProductoCE>();
            try
            {
                List<cp_ListarProductoFiltroResult> aux = ProductoCD.ListarProductoFiltro(valor);
                foreach (cp_ListarProductoFiltroResult prov in aux)
                {
                    op = new ProductoCE(prov.IdProducto, prov.CedProducto, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del ProductoCE", ex);
            }

            return Lista;
        }
        */

        //public static ProductoCD pcd = new ProductoCD();

        public bool CreateProducto(ProductoCE op)
        {
            try
            {
                ProductoCD.InsertarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del Producto CapaLN", ex);
            }
        }
        
        public bool UpdateProducto(ProductoCE op, int id)
        {
            try
            {
                ProductoCD.ModificarProducto(id,op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update producto LN", ex);
            }
        }
        
        public bool DeleteProducto(int op)
        {
            try
            {
                ProductoCD.EliminarProducto(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete producto CapaLN", ex);
            }
        }

        
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
        */
        public ProductoCE GetProducto(int id)
        {
            ProductoCE nulo = null;
            List<ProductoCE> aux = ViewProducto();
            foreach (ProductoCE ob in aux)
            {
                if (ob.Id_Producto == id)
                {
                    return ob;
                }
            }
            return nulo;
        }
        



    }
}
