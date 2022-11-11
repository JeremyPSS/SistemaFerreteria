using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    
    public class Modo_PagoLN
    {
        /*
        public List<Modo_PagoCE> ViewModo_Pago()
        {
            Modo_PagoCE op;
            List<Modo_PagoCE> Lista = new List<Modo_PagoCE>();
            try
            {
                List<PROVEEDOR> aux = Modo_PagoCD.ListarModo_Pago();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new Modo_PagoCE(prov.IdModo_Pago, prov.CedModo_Pago, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del Modo_PagoCE", ex);
            }

            return Lista;
        }
        public List<Modo_PagoCE> ViewModo_PagoFiltro(string valor)
        {
            Modo_PagoCE op;
            List<Modo_PagoCE> Lista = new List<Modo_PagoCE>();
            try
            {
                List<cp_ListarModo_PagoFiltroResult> aux = Modo_PagoCD.ListarModo_PagoFiltro(valor);
                foreach (cp_ListarModo_PagoFiltroResult prov in aux)
                {
                    op = new Modo_PagoCE(prov.IdModo_Pago, prov.CedModo_Pago, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del Modo_PagoCE", ex);
            }

            return Lista;
        }

        public bool CreateModo_Pago(Modo_PagoCE op)
        {
            try
            {
                Modo_PagoCD.InsertarModo_Pago(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del Modo_PagoCE", ex);
            }
        }

        public bool UpdateModo_Pago(Modo_PagoCE op)
        {
            try
            {
                Modo_PagoCD.ModificarModo_Pago(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update Modo_PagoCE", ex);
            }
        }

        public bool DeleteModo_Pago(Modo_PagoCE op)
        {
            try
            {
                Modo_PagoCD.EliminarModo_Pago(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete Modo_PagoCE", ex);
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
