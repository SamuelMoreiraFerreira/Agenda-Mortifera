using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMortifera.Data
{
    internal static class ConexaoDB
    {
        public static MySqlConnection Connection()
        {
            // String contendo as credencias para a conexão SQL
            string token = "Server=localhost;Database=db_agenda;User ID=root;Password=root;";

            // Estabelecendo a conexão
            MySqlConnection connection = new MySqlConnection(token);

            return connection;
        }

        public static MySqlConnection Connection(string usuario, string senha)
        {
            string token = $"Server=localhost;Database=db_agenda;User ID={usuario};Password={senha};";

            MySqlConnection connection = new MySqlConnection(token);

            try
            {
                // Validando a conexão
                connection.Open();

                return connection;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
