using CapaEntidades.Inventory;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Inventory
{
    public class ProductoCD
    {
        /*
        public List<>
        NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        conexion.Open();
        NpgsqlCommand comand = new NpgsqlCommand("SELECT * FROM public.crudtb", conexion);
        NpgsqlDataAdapter ad = new NpgsqlDataAdapter(comand);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        grilla.DataSource = dt;
        grilla.DataBind();
        conexion.Close();
        */
        private const string TABLE_NAME = "producto";

        //CConexion conexion = new CConexion();

        public static void InsertarProducto(ProductoCE op)
        {
            int columnaffected = 0;
            try
            {
                string commandText = $"INSERT INTO {TABLE_NAME} (id_producto, nombre_producto, precio, stock, id_categoria) VALUES (@id, @name, @pre, @sto, @idc);";
                using (var cmd = new NpgsqlCommand(commandText, CConexion.establecerConexion()))
                {
                 
                    cmd.Parameters.AddWithValue("id", op.Id_Producto);
                    cmd.Parameters.AddWithValue("name", op.Nombre);
                    cmd.Parameters.AddWithValue("pre", (decimal) op.Precio);
                    cmd.Parameters.AddWithValue("sto", op.Stock);
                    cmd.Parameters.AddWithValue("idc", op.Id_Categoria);
                    columnaffected = cmd.ExecuteNonQuery(); //Execute the query if the conexion is open, else return 0
                }
            }
            catch(Exception ex)
            {
                throw new DatosExcepciones("Problemas al Insertar Producto CapaCD"+columnaffected, ex);
            }
        }

        public static List<ProductoCE> ListarProducto()
        {
            string commandText = $"SELECT * FROM {TABLE_NAME};"; //query
            List<ProductoCE> list = new List<ProductoCE>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, CConexion.establecerConexion()))
            {
                    //cmd.Parameters.AddWithValue("id", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        ProductoCE op = ReadProducto(reader); //we read each register and save as object
                        //return op;
                        list.Add(op); //we add the object to the list
                    }
                return list;
            }
            return null;

        }

        private static ProductoCE ReadProducto(NpgsqlDataReader reader)
        {
            int? id = reader["id_producto"] as int?; //read param from db and save on a local param
            string nombre_producto = reader["nombre_producto"] as string;
            decimal? precio = reader["precio"] as decimal?;
            int? stock = reader["stock"] as int?;
            int? id_categoria = reader["id_categoria"] as int?;

            ProductoCE op = new ProductoCE
            {
                Id_Producto = id.Value,
                Nombre = nombre_producto,
                Precio = (double) precio.Value,
                Stock = stock.Value,
                Id_Categoria = id_categoria.Value
            };
            return op;
        }

        public static void EliminarProducto(int id)
        {
            string commandText = $"DELETE FROM {TABLE_NAME} WHERE id_producto=(@p);";
            using (var cmd = new NpgsqlCommand(commandText, CConexion.establecerConexion()))
            {
                cmd.Parameters.AddWithValue("p", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificarProducto(int id, ProductoCE op)
        {
            var commandText = $@"UPDATE {TABLE_NAME}
                SET nombre_producto = @nom, precio = @pre, stock = @sto, id_categoria = @idc
                WHERE id_producto = @id;";

            using (var cmd = new NpgsqlCommand(commandText, CConexion.establecerConexion()))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nom", op.Nombre);
                cmd.Parameters.AddWithValue("pre", (decimal) op.Precio);
                cmd.Parameters.AddWithValue("sto", op.Stock);
                cmd.Parameters.AddWithValue("idc", op.Id_Categoria);

                cmd.ExecuteNonQuery();
            }
        }

        public static ProductoCE ObtenerProducto(int id)
        {
            ProductoCE empty;
            string commandText = $"SELECT * FROM {TABLE_NAME} WHERE id_producto = @id;";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, CConexion.establecerConexion()))
            {
                cmd.Parameters.AddWithValue("id_producto", id);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                if(reader.Read()==true)
                 {
                        ProductoCE op = ReadProducto(reader); 
                        return op;
                 }
                else
                {
                        return  empty = new ProductoCE();
                }
                
            }
            return null;

        }


    }
}
