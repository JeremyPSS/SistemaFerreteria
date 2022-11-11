using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Inventory
{
    /**
     * This Class help us to connected to Postgres through drive NpgsqlConnection
     * NpgsqlConnection -> has the conection
     * NpgsqlConnection -> cannot be declare two times
     * @Author: Jeremy Prieto
     * @Date: 28/08/2022
     */
    public class CConexion
    {
        public static NpgsqlConnection conexion = new NpgsqlConnection();
        static string server = "localhost";
        static string bd = "Ferreteria";
        static string user ="postgres";
        static string pass = "sqldbjeremy";
        static string port = "5432";

        static String cadenaConexion = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + pass + ";" + "database=" + bd + ";";

        //private  NpgsqlConnection connection;

       // public NpgsqlConnection Connection { get => connection; set => connection = value; }

        /*
        public  CConexion()
        {
            Connection = new NpgsqlConnection(cadenaConexion);
            Connection.Open();
        }
        */
        

        public static NpgsqlConnection establecerConexion()
        {

            try
            {
                //this 'if' u can remove when the method is not static
                //this 'if' help us to control the conexion open just once time
                //thats mean, meanwhile the program is running the conection is already open all the time
                //OTHER FORM TO USE THE CONEXION IS JUST USING THE STATIC VARIABLE DIRECTLY, BUT THINKING WELL, ON FOR THE FIRST TIME WE HAVE TO CREATE WITH THIS METHOD, shit...
                if(conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.ConnectionString = cadenaConexion;
                    conexion.Open();
                }
                Console.WriteLine("Se conectó correctamente a la Base de datos");

            }

            catch (NpgsqlException e)
            {
                throw new DatosExcepciones ("No se pudo conectar a la base de datos de PostgreSQL, error: " + e.ToString());

            }
            /*
            finally
            {
                conexion.Close(); //delete if produce a error
            }
            */

            return conexion;
        }
        

    }
}
