using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class ClienteLN
    {
        /*
        public List<ClienteCE> ViewCliente()
        {
            ClienteCE op;
            List<ClienteCE> Lista = new List<ClienteCE>();
            try
            {
                List<PROVEEDOR> aux = ProveedorCD.ListarProveedor();
                foreach (PROVEEDOR prov in aux)
                {
                    op = new ClienteCE(prov.Id_Cliente, prov.Nombre, prov.Apellido, prov.Id_Direccion, prov.Telefono, prov.Email);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del Cliente", ex);
            }

            return Lista;
        }
        public List<ClienteCE> ViewClienterFiltro(string valor)
        {
            ClienteCE op;
            List<ClienteCE> Lista = new List<ClienteCE>();
            try
            {
                List<cp_ListarProveedorFiltroResult> aux = ProveedorCD.ListarProveedorFiltro(valor);
                foreach (cp_ListarProveedorFiltroResult prov in aux)
                {
                    op = new ClienteCE((prov.Id_Cliente, prov.Nombre, prov.Apellido, prov.Id_Direccion, prov.Telefono, prov.Email);
                    Lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos filtrados del Cliente", ex);
            }

            return Lista;
        }

        public bool CreateCliente(ClienteCE op)
        {
            try
            {
                ProveedorCD.InsertarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del cliente", ex);
            }
        }

        public bool UpdateCliente(ClienteCE op)
        {
            try
            {
                ProveedorCD.ModificarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error update proveedor", ex);
            }
        }

        public bool DeleteProveedor(ClienteCE op)
        {
            try
            {
                ProveedorCD.EliminarProveedor(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error delete cliente", ex);
            }
        }
        public bool ExisteCliente(int Id_Cliente)
        {
            bool estado = false;
            List<ClienteCE> aux = ViewGuia();
            foreach (ClienteCE ob in aux)
            {
                if (ob.Id_Cliente == Id_Cliente)
                {
                    estado = true;
                    break;
                }
            }
            return estado;
        }

        public ClienteCE GetCliente(int Id_Cliente)
        {
            ClienteCE resu = null;
            List<ClienteCE> aux = ViewGuia();
            foreach (ClienteCE ob in aux)
            {
                if (ob.Id_Cliente == Id_Cliente)
                {
                    return ob;
                }
            }
            return resu;
        }
        */
    }
}
