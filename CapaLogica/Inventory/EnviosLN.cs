using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class EnviosLN
    {
        /*
        public List<EnviosCE> ViewEnvios()
        {
            EnviosCE op;
            List<EnviosCE> Lista = new List<EnviosCE>();
            try
            {
                List<PROVEEDOR> aux = EnviosCD.ListarEnvios();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new EnviosCE(prov.IdEnvios, prov.CedEnvios, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del EnviosCE", ex);
            }

            return Lista;
        }
        public List<EnviosCE> ViewEnviosFiltro(string valor)
        {
            EnviosCE op;
            List<EnviosCE> Lista = new List<EnviosCE>();
            try
            {
                List<cp_ListarEnviosFiltroResult> aux = EnviosCD.ListarEnviosFiltro(valor);
                foreach (cp_ListarEnviosFiltroResult prov in aux)
                {
                    op = new EnviosCE(prov.IdEnvios, prov.CedEnvios, prov.Nombre, prov.Representante, prov.Direccion, prov.Ciudad, prov.Telefono, prov.Fax);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del EnviosCE", ex);
            }

            return Lista;
        }

        public bool CreateEnvios(EnviosCE op)
        {
            try
            {
                EnviosCD.InsertarEnvios(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del EnviosCE", ex);
            }
        }

        public bool UpdateEnvios(EnviosCE op)
        {
            try
            {
                EnviosCD.ModificarEnvios(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update EnviosCE", ex);
            }
        }

        public bool DeleteEnvios(EnviosCE op)
        {
            try
            {
                EnviosCD.EliminarEnvios(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete EnviosCE", ex);
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
