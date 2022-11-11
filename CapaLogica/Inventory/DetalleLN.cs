using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class DetalleLN
    {
        /*
        public List<DetalleCE> ViewDetalle()
        {
            DetalleCE op;
            List<DetalleCE> Lista = new List<DetalleCE>();
            try
            {
                List<PROVEEDOR> aux = DetalleCD.ListarDetalle();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new DetalleCE(prov.NumDetalle, prov.Id_Factura, prov.Id_Producto, prov.Cantidad, prov.Precio);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del Detalle", ex);
            }

            return Lista;
        }
        public List<DetalleCE> ViewDetalleFiltro(string valor)
        {
            DetalleCE op;
            List<DetalleCE> Lista = new List<DetalleCE>();
            try
            {
                List<cp_ListarDetalleFiltroResult> aux = DetalleCD.ListarDetalleFiltro(valor);
                foreach (cp_ListarDetalleFiltroResult prov in aux)
                {
                    op = new DetalleCE(prov.NumDetalle, prov.Id_Factura, prov.Id_Producto, prov.Cantidad, prov.Precio);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del Detalle", ex);
            }

            return Lista;
        }

        public bool CreateDetalle(DetalleCE op)
        {
            try
            {
                DetalleCD.InsertarDetalle(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del Detalle", ex);
            }
        }

        public bool UpdateDetalle(DetalleCE op)
        {
            try
            {
                DetalleCD.ModificarDetalle(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update DetalleLN", ex);
            }
        }

        public bool DeleteDetalle(DetalleCE op)
        {
            try
            {
                DetalleCD.EliminarDetalle(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete DetalleCE", ex);
            }
        }
        public bool ExisteDetalle(int idDetalle)
        {
            bool estado = false;
            List<DetalleCE> aux = ViewDetalle();
            foreach (DetalleCE ob in aux)
            {
                if (ob.numDetalle == idDetalle)
                {
                    estado = true;
                    break;
                }
            }
            return estado;
        }

        public DetalleCE GetDetalle(int numDetalle)
        {
            DetalleCE resu = null;
            List<DetalleCE> aux = ViewDetalle();
            foreach (DetalleCE ob in aux)
            {
                if (ob.numDetalle == numDetalle)
                {
                    return ob;
                }
            }
            return resu;
        }
        */
    }
}
