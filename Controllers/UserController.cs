using MySql.Data.MySqlClient;
using AgendaMortifera.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AgendaMortifera.Controllers
{
    internal class UserController
    {

        public bool AddUser(string pecado, string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            MySqlCommand cmdInsertInto = new MySqlCommand(
                "INSERT INTO tb_usuarios VALUES (@pecado, @nome, @usuario, @telefone, @senha);",
                conexao
            );

            cmdInsertInto.Parameters.AddWithValue("@pecado", pecado);

            cmdInsertInto.Parameters.AddWithValue("@nome", nome);

            cmdInsertInto.Parameters.AddWithValue("@usuario", usuario);

            cmdInsertInto.Parameters.AddWithValue("@telefone", telefone);

            cmdInsertInto.Parameters.AddWithValue("@senha", senha);

            int rowsAffected = 0;

            // Evitando crash em caso de erro
            try
            {
                // Retornará a quantidade de linhas afetadas (ExecuteNonQuery)
                rowsAffected = cmdInsertInto.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            conexao.Close();

            // Sucesso, usuário inserido
            if (rowsAffected > 0)
            {
                return true;
            }

            // Algum erro
            else
            {
                return false;
            }
        }

    }
}
