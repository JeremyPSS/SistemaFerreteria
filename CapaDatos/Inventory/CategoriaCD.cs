using CapaEntidades.Inventory;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Inventory
{
    public class CategoriaCD
    {
        private const string TABLE_NAME = "categoria";

        public static List<CategoriaCE> ListarCategoria()
        {
            string commandText = $"SELECT * FROM {TABLE_NAME};"; //query
            List<CategoriaCE> list = new List<CategoriaCE>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, CConexion.establecerConexion()))
            {
                //cmd.Parameters.AddWithValue("id", id);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        CategoriaCE op = ReadCategoria(reader); //we read each register and save as object
                        //return op;
                        list.Add(op); //we add the object to the list
                    }
                return list;
            }
            return null;

        }

        private static CategoriaCE ReadCategoria(NpgsqlDataReader reader)
        {
            int? id = reader["id_categoria"] as int?;
            string nombre = reader["nombre_categoria"] as string;
            string descripcion = reader["descripcion"] as string;

            CategoriaCE op = new CategoriaCE
            {
                Id_Categoria = id.Value,
                Nombre = nombre,
                Descripcion = descripcion
            };
            return op;
        }

        public static void InsertarCategoria(CategoriaCE op)
        {
            int columnaffected = 0;
            try
            {
                string commandText = $"INSERT INTO {TABLE_NAME} (id_categoria, nombre_categoria, descripcion) VALUES (@id, @name, @des);";
                using (var cmd = new NpgsqlCommand(commandText, CConexion.establecerConexion()))
                {

                    cmd.Parameters.AddWithValue("id", op.Id_Categoria);
                    cmd.Parameters.AddWithValue("name", op.Nombre);
                    cmd.Parameters.AddWithValue("des", op.Descripcion);
                    columnaffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Problemas al Insertar Categoria CapaCD" + columnaffected, ex);
            }
        }


    }
}
