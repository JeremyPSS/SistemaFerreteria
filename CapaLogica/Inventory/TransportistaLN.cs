using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class TransportistaLN
    {
        /*
        public List<TransportistaCE> ViewTransportista()
        {
            TransportistaCE op;
            List<TransportistaCE> Lista = new List<TransportistaCE>();
            try
            {
                List<PROVEEDOR> aux = TransportistaCD.ListarTransportista();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new TransportistaCE(prov.IdTransportista, prov.CedTransportista, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del TransportistaCE", ex);
            }

            return Lista;
        }
        public List<TransportistaCE> ViewTransportistaFiltro(string valor)
        {
            TransportistaCE op;
            List<TransportistaCE> Lista = new List<TransportistaCE>();
            try
            {
                List<cp_ListarTransportistaFiltroResult> aux = TransportistaCD.ListarTransportistaFiltro(valor);
                foreach (cp_ListarTransportistaFiltroResult prov in aux)
                {
                    op = new TransportistaCE(prov.IdTransportista, prov.CedTransportista, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del TransportistaCE", ex);
            }

            return Lista;
        }

        public bool CreateTransportista(TransportistaCE op)
        {
            try
            {
                TransportistaCD.InsertarTransportista(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del TransportistaCE", ex);
            }
        }

        public bool UpdateTransportista(TransportistaCE op)
        {
            try
            {
                TransportistaCD.ModificarTransportista(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update TransportistaCE", ex);
            }
        }

        public bool DeleteTransportista(TransportistaCE op)
        {
            try
            {
                TransportistaCD.EliminarTransportista(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete TransportistaCE", ex);
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
