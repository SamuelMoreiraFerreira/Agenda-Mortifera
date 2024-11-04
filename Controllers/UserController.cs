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

            try
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

                // Retornará a quantidade de linhas afetadas (ExecuteNonQuery)
                rowsAffected = cmdInsertInto.ExecuteNonQuery();

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

            // Evitando Crash
            catch (Exception)
            {
                return false;
            }
        }

        public bool UserExists(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.Connection();

                conexao.Open();

                MySqlCommand cmdVerificacao = new MySqlCommand(
                    "SELECT * FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario AND BINARY tb_usuarios.senha = @senha",
                    conexao
                );

                cmdVerificacao.Parameters.AddWithValue("@usuario", usuario);

                cmdVerificacao.Parameters.AddWithValue("@senha", senha);

                // O comando retornará algum valor (ExecuteReader)
                bool returnValue = cmdVerificacao.ExecuteReader().Read();

                conexao.Close();

                return returnValue;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
