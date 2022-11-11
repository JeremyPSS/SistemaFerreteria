using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class TipoLN
    {
        /*
        public List<TipoCE> ViewTipo()
        {
            TipoCE op;
            List<TipoCE> Lista = new List<TipoCE>();
            try
            {
                List<PROVEEDOR> aux = TipoCD.ListarTipo();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new TipoCE(prov.IdTipo, prov.CedTipo, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del TipoCE", ex);
            }

            return Lista;
        }
        public List<TipoCE> ViewTipoFiltro(string valor)
        {
            TipoCE op;
            List<TipoCE> Lista = new List<TipoCE>();
            try
            {
                List<cp_ListarTipoFiltroResult> aux = TipoCD.ListarTipoFiltro(valor);
                foreach (cp_ListarTipoFiltroResult prov in aux)
                {
                    op = new TipoCE(prov.IdTipo, prov.CedTipo, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del TipoCE", ex);
            }

            return Lista;
        }

        public bool CreateTipo(TipoCE op)
        {
            try
            {
                TipoCD.InsertarTipo(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del TipoCE", ex);
            }
        }

        public bool UpdateTipo(TipoCE op)
        {
            try
            {
                TipoCD.ModificarTipo(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update TipoCE", ex);
            }
        }

        public bool DeleteTipo(TipoCE op)
        {
            try
            {
                TipoCD.EliminarTipo(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete TipoCE", ex);
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
