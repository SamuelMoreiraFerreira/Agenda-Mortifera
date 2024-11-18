using MySql.Data.MySqlClient;
using AgendaMortifera.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;

namespace AgendaMortifera.Controllers
{
    internal class UserController
    {

        private bool CreateUserDB(string usuario, string senha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {
                MySqlCommand cmdCreateUser = new MySqlCommand(
                   $@"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                      GRANT SELECT ON db_agenda.tb_categorias TO '{usuario}'@'%';",
                   conexao
                );

                cmdCreateUser.ExecuteNonQuery();

                // Sucesso, usuário criado na DB
                return true;
            }

            // Evitando crash
            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public bool CreateUser(string pecado, string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {
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
                    // Criar usuário na DB
                    if (this.CreateUserDB(usuario, senha))
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }

                // Erro
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

            finally
            {
                conexao.Close();
            }
        }

        public bool DeleteUser(string usuario)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {
                MySqlCommand cmdDeleteUser = new MySqlCommand(
                    "DELETE FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario;",
                    conexao
                );

                cmdDeleteUser.Parameters.AddWithValue("@usuario", usuario);

                int rowsAffected = 0;

                rowsAffected = cmdDeleteUser.ExecuteNonQuery();

                // Sucesso, usuário deletado
                if (rowsAffected > 0)
                {
                    return true;
                }

                // Erro
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

            finally
            {
                conexao.Close();
            }
        }

        public bool UserExists(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.Connection();

                conexao.Open();

                MySqlCommand cmdVerificacao = new MySqlCommand(
                    "SELECT * FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario AND BINARY tb_usuarios.senha = @senha;",
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

        public DataTable GetUsers()
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {
                MySqlDataAdapter adpGetUsers = new MySqlDataAdapter(
                    "SELECT tb_usuarios.usuario AS 'User' FROM tb_usuarios;",
                    conexao
                );

                DataTable tabela = new DataTable();

                adpGetUsers.Fill(tabela);

                return tabela;
            }

            // Evitando Crash
            catch (Exception)
            {
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
        }

        public bool ModifySenha(string usuario, string novaSenha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {
                MySqlCommand cmdModifySenha = new MySqlCommand(
                    "UPDATE tb_usuarios SET tb_usuarios.senha = @nova_senha WHERE tb_usuarios.usuario = @usuario",
                    conexao
                );

                cmdModifySenha.Parameters.AddWithValue("@usuario", usuario);

                cmdModifySenha.Parameters.AddWithValue("@nova_senha", novaSenha);

                int rowsAffected = 0;

                rowsAffected = cmdModifySenha.ExecuteNonQuery();

                // Sucesso, senha alterada
                if (rowsAffected > 0)
                {
                    return true;
                }

                // Erro
                else
                {
                    return false;
                }
            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}
