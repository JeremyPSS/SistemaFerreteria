using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    
    public class FacturaLN
    {
        /*
        public List<FacturaCE> ViewFactura()
        {
            FacturaCE op;
            List<FacturaCE> Lista = new List<FacturaCE>();
            try
            {
                List<PROVEEDOR> aux = FacturaCD.ListarFactura();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new FacturaCE(prov.IdFactura, prov.CedFactura, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del FacturaCE", ex);
            }

            return Lista;
        }
        public List<FacturaCE> ViewFacturaFiltro(string valor)
        {
            FacturaCE op;
            List<FacturaCE> Lista = new List<FacturaCE>();
            try
            {
                List<cp_ListarFacturaFiltroResult> aux = FacturaCD.ListarFacturaFiltro(valor);
                foreach (cp_ListarFacturaFiltroResult prov in aux)
                {
                    op = new FacturaCE(prov.IdFactura, prov.CedFactura, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del FacturaCE", ex);
            }

            return Lista;
        }

        public bool CreateFactura(FacturaCE op)
        {
            try
            {
                FacturaCD.InsertarFactura(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del proveedor", ex);
            }
        }

        public bool UpdateFactura(FacturaCE op)
        {
            try
            {
                FacturaCD.ModificarFactura(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update proveedor", ex);
            }
        }

        public bool DeleteFactura(FacturaCE op)
        {
            try
            {
                FacturaCD.EliminarFactura(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete proveedor", ex);
            }
        }
        /*
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
