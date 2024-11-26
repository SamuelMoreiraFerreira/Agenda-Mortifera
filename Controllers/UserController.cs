using MySql.Data.MySqlClient;
using AgendaMortifera.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using AgendaMortifera.StructureDB;

namespace AgendaMortifera.Controllers
{
    internal class UserController
    {

        private bool CreateUserDB(string usuario, string senha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

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

        public bool CreateUser(string pecado, string nome, string usuario, string senha, string? telefone)
        {
            MySqlConnection connection = ConexaoDB.Connection();

            try
            {
                connection.Open();

                MySqlCommand cmdInsertUsuario = new MySqlCommand(
                    "INSERT INTO tb_usuarios VALUES (@pecado, @nome, @usuario, @telefone, @senha);",
                    connection
                );

                cmdInsertUsuario.Parameters.AddWithValue("@pecado", pecado);

                cmdInsertUsuario.Parameters.AddWithValue("@nome", nome);

                cmdInsertUsuario.Parameters.AddWithValue("@usuario", usuario);

                cmdInsertUsuario.Parameters.AddWithValue("@telefone", telefone);

                cmdInsertUsuario.Parameters.AddWithValue("@senha", senha);

                // Retornará a quantidade de linhas afetadas (ExecuteNonQuery)
                if (cmdInsertUsuario.ExecuteNonQuery() > 0)
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
                connection.Close();
            }
        }

        private bool DeleteUserDB(string usuario)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

                MySqlCommand cmdDeleteUserDB = new MySqlCommand(
                    $"DROP USER '{usuario}'@'%';",
                    conexao
                );

                cmdDeleteUserDB.ExecuteNonQuery();

                // Sucesso, usuário deletado na DB
                return true;
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

            try
            {
                conexao.Open();

                MySqlCommand cmdDeleteUser = new MySqlCommand(
                    "DELETE FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario;",
                    conexao
                );

                cmdDeleteUser.Parameters.AddWithValue("@usuario", usuario);

                if (this.DeleteUserDB(usuario))
                {
                    cmdDeleteUser.ExecuteNonQuery();

                    return true;
                }

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

        private bool ModifySenhaDB(string usuario, string novaSenha)
        {
            MySqlConnection conexao = UserSession.Conexao;

            if (conexao == null)
            {
                return false;
            }

            try
            {
                conexao.Open();

                MySqlCommand cmdModifySenhaDB = new MySqlCommand(
                    $"ALTER USER '{usuario}'@'%' IDENTIFIED BY '{novaSenha}'",
                    conexao
                );

                cmdModifySenhaDB.ExecuteNonQuery();

                // Sucesso, senha alterada na DB
                return true;
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

        public bool ModifySenha(string usuario, string novaSenha)
        {
            MySqlConnection conexao = UserSession.Conexao;

            if (conexao == null)
            {
                return false;
            }

            try
            {
                conexao.Open();

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
                    this.ModifySenhaDB(usuario, novaSenha);

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

        public DataTable GetContatos()
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlDataAdapter adpGetContatos = new MySqlDataAdapter(
                        "SELECT tb_contatos.id_contato AS 'ID', tb_contatos.nome AS 'Nome', tb_contatos.endereco AS 'Endereço', tb_contatos.email AS 'E-Mail' FROM tb_contatos WHERE tb_contatos.usuario = SUBSTRING_INDEX(USER(), '@', 1);",
                        connection
                    );

                    DataTable table = new DataTable();

                    adpGetContatos.Fill(table);

                    // Tabela contendo os contatos
                    return table;
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                    return new DataTable();
                }

                finally
                {
                    connection.Close();
                }
            }

            else
            {
                return new DataTable();
            }
        }

        public Dictionary<string, object>? GetUser(string usuario, string senha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

                MySqlCommand cmdGetUser = new MySqlCommand(
                    "SELECT tb_usuarios.pecado, tb_usuarios.nome, tb_usuarios.usuario, tb_usuarios.telefone, tb_usuarios.senha FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario AND BINARY tb_usuarios.senha = @senha;",
                    conexao
                );

                cmdGetUser.Parameters.AddWithValue("@usuario", usuario);

                cmdGetUser.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader result = cmdGetUser.ExecuteReader();

                if (result.Read())
                {
                    // Passando os dados do MySqlDataReader para um Dictionary para manter os dados após o fechamento da conexão.

                    // Object -> Armazena qualquer tipo de dado
                    Dictionary<string, object> returnValue = new Dictionary<string, object>();

                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        returnValue[result.GetName(i)] = result.GetValue(i);
                    }

                    return returnValue;
                }

                else
                {
                    return null;
                }
            }

            catch (Exception)
            {
                return null;
            }

            finally
            {
                conexao.Close();
            }
        }

        public bool ValidateUser(string usuario, string senha)
        {
            if (this.GetUser(usuario, senha) != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
