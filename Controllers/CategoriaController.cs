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
        public bool AddCategoria (string usuario, string categoria)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.Connection();

                conexao.Open();

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

        public DataTable GetCategorias (string usuario)
        {

            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            try
            {

                // Ponte entre a aplicação e a database, permite trabalhar com dados em memória (MySqlDataAdapter)
                MySqlDataAdapter adpGetCategorias = new MySqlDataAdapter(
                    "SELECT id_categoria AS 'Código', categoria AS 'Categoria' FROM tb_categorias WHERE tb_categorias.usuario = @usuario",
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
