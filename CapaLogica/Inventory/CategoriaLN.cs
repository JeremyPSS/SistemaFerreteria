using CapaDatos.Inventory;
using CapaEntidades.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Inventory
{
    public class CategoriaLN
    {

        public List<CategoriaCE> ViewCategoria()
        {
            //CategoriaCE op;
            List<CategoriaCE> Lista = new List<CategoriaCE>();
            try
            {
                return CategoriaCD.ListarCategoria();
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar datos del CategoriaCE", ex);
            }
        }


        public bool CreateCategoria(CategoriaCE op)
        {
            try
            {
                CategoriaCD.InsertarCategoria(op);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insert datos del Categoria CapaLN", ex);
            }
        }



       


    }
}
