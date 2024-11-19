using AgendaMortifera.StructureDB;
using AgendaMortifera.Views;
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

namespace AgendaMortifera.Controllers
{
    public partial class frmPerfil : Form
    {

        readonly string usuario = UserSession.Usuario;

        readonly MySqlConnection conexao = UserSession.Conexao;

        public frmPerfil()
        {
            InitializeComponent();
        }

        private void AdicionarCategoria(object sender, EventArgs e)
        {
            frmAddCategoria screenAddCategoria = new frmAddCategoria();
            screenAddCategoria.Show();
        }

        private void AtualizarDgvCategorias()
        {
            dgvCategorias.DataSource = new CategoriaController().GetCategorias(this.usuario);
        }

        private void AtualizarDgvUsuarios()
        {
            dgvUsuarios.DataSource = new UserController().GetUsers();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();
            
            this.AtualizarDgvUsuarios();
        }

        private void btnRefreshCategorias_Click(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            this.AtualizarDgvUsuarios();
        }

        private void tbxAlterarSenha_TextChanged(object sender, EventArgs e)
        {
            // Mínimo para a senha é 8 caractéres

            if (tbxAlterarSenha.Text.Length >= 8)
            {
                btnConfirmarSenha.Enabled = true;
            }

            else
            {
                btnConfirmarSenha.Enabled = false;
            }
        }

        // Apagar Categoria
        private void dgvCategorias_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Executa a exclusão para cada linha selecionada no DataGridView
            foreach (DataGridViewRow selectedRow in dgvCategorias.SelectedRows)
            {
                _ = new CategoriaController().DeleteCategoria(selectedRow.Cells["ID"].Value.ToString()!);

                this.AtualizarDgvCategorias();
            }
        }

        // Apagar Usuário
        private void dgvUsuarios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvUsuarios.SelectedRows)
            {
                _ = new UserController().DeleteUser(selectedRow.Cells["User"].Value.ToString()!);

                this.AtualizarDgvUsuarios();
            }
        }

        // Alterar Senha
        private void btnConfirmarSenha_Click(object sender, EventArgs e)
        {
            if (new UserController().ModifySenha(this.usuario, tbxAlterarSenha.Text))
            {
                this.Close();

                MessageBox.Show("Sua senha foi alterada com sucesso! Entre novamente.", "Sucesso!");
            }

            else
            {
                MessageBox.Show("Ocorreu um erro ao alterar sua senha. Tente novamente!", "Problemas Técnicos");
            }
        }
    }
}
