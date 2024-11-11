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
    internal class CategoriaController
    { 
        public bool AddCategoria (int usuario, string categoria)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.Connection();

                conexao.Open();

                MySqlCommand cmdInsertInto = new MySqlCommand(
                    "INSERT INTO tb_categorias (id_usuario, categoria) VALUES (@id_usuario, @nome_categoria);",
                    conexao
                );

                cmdInsertInto.Parameters.AddWithValue("@nome_categoria", usuario);

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
    }
}
