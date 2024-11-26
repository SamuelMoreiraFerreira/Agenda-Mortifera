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

        public bool CreateUser(string pecado, string nome, string usuario, string senha, string telefone)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
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
                    // Criar usuário na DB
                    if (this.CreateUserDB(usuario, senha))
                    {
                        return true;
                    }

                    else
                    {
                        this.DeleteUser(usuario);

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
            if (this.GetUser(,02usuario, senha) != null)
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
