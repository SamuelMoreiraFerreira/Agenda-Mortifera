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
    internal class CategoriaController
    { 
        public bool CreateCategoria (string usuario, string categoria)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {
                MySqlCommand cmdInsertInto = new MySqlCommand(
                    "INSERT INTO tb_categorias (usuario, categoria) VALUES (@usuario, @nome_categoria);",
                    conexao
                );

                cmdInsertInto.Parameters.AddWithValue("@usuario", usuario);

                cmdInsertInto.Parameters.AddWithValue("@nome_categoria", categoria);

                int rowsAffected = 0;

                // Retornará a quantidade de linhas afetadas (ExecuteNonQuery)
                rowsAffected = cmdInsertInto.ExecuteNonQuery();

                // Sucesso, categoria inserida
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

        public bool DeleteCategoria (string idCategoria)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {
                MySqlCommand cmdDelete = new MySqlCommand(
                    "DELETE FROM tb_categorias WHERE tb_categorias.id_categoria = @id_categoria;",
                    conexao
                );

                cmdDelete.Parameters.AddWithValue("@id_categoria", idCategoria);

                int rowsAffected = 0;

                // Retornará a quantidade de linhas afetadas (ExecuteNonQuery)
                rowsAffected = cmdDelete.ExecuteNonQuery();

                // Sucesso, categoria excluida
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

        public DataTable GetCategorias (string usuario)
        {

            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {

                // Ponte entre a aplicação e a database, permite trabalhar com dados em memória (MySqlDataAdapter)
                MySqlDataAdapter adpGetCategorias = new MySqlDataAdapter(
                    "SELECT id_categoria AS 'ID', categoria AS 'Categoria' FROM tb_categorias WHERE tb_categorias.usuario = @usuario;",
                    conexao
                );

                adpGetCategorias.SelectCommand.Parameters.AddWithValue("@usuario", usuario);

                // Cria uma tabela vazia
                DataTable tabela = new DataTable();

                // Preenche a tabela anteriormente criada
                adpGetCategorias.Fill(tabela);

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
    }
}
