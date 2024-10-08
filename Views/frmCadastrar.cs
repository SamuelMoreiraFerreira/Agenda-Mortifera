using AgendaMortifera.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMortifera
{
    public partial class frmCadastrar : Form
    {

        // String contendo as credencias para a conexão
        private readonly string token = "Server=localhost;Database=db_agenda;User ID=root;Password=root;";

        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            // Validação dos dados dos TextBox's

            if (

                tbxName.Text != ""

                && tbxEmail.Text != ""

                && tbxPhone.Text != ""

                && tbxPecado.Text != ""

                && tbxPassword.Text.Length >= 8

                && tbxRPassword.Text != ""

                && tbxPassword.Text == tbxRPassword.Text

            )

            {
                btnSign.Enabled = true;
            }

            else
            {
                btnSign.Enabled = false;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            MySqlCommand cmdVerificacao = new MySqlCommand(
                $"SELECT * FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario",
                conexao
            );

            cmdVerificacao.Parameters.AddWithValue("@usuario", tbxEmail.Text);

            if (!cmdVerificacao.ExecuteReader().Read())
            {
                // Cadastrando 

                MySqlCommand cmdInsertInto = new MySqlCommand(
                    "INSERT INTO tb_usuarios (pecado, nome, usuario, telefone, senha) VALUES (@pecado, @nome, @usuario, @telefone, @senha);",
                    conexao
                );

                cmdInsertInto.Parameters.AddWithValue("@pecado", tbxPecado.Text);

                cmdInsertInto.Parameters.AddWithValue("@nome", tbxName.Text);

                cmdInsertInto.Parameters.AddWithValue("@usuario", tbxEmail.Text);

                cmdInsertInto.Parameters.AddWithValue("@telefone", tbxPhone.Text);

                cmdInsertInto.Parameters.AddWithValue("@senha", tbxPassword.Text);

                try
                {
                    // O comando não retornará valor algum (ExecuteNonQuery)
                    cmdInsertInto.ExecuteNonQuery();

                    this.Close();

                    // Sucesso

                    MessageBox.Show("Você agora está cadastrado no livro do Diabo!", "Bem-Vindo ao Érebro");
                }

                catch
                {
                    // Erro

                    MessageBox.Show("Ocorreu um erro ao cadastrar. Tente novamente!", "Problemas Técnicos");
                }

            }

            else
            {
                // Email já cadastrado

                MessageBox.Show("Este email já está cadastrado no sistema do sub mundo.", "Tente Novamente!");
            }

            conexao.Close();
                      
        }
    }
}
