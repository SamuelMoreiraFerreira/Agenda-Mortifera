using AgendaMortifera.Views;
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

        public required string usuario;

        public frmPerfil()
        {
            InitializeComponent();
        }

        private void AdicionarCategoria(object sender, EventArgs e)
        {
            frmAddCategoria screenAddCategoria = new frmAddCategoria
            {
                usuario = this.usuario
            };

            screenAddCategoria.Show();
        }

        private void AtualizarDgvCategorias()
        {
            dgvCategorias.DataSource = new CategoriaController().GetCategorias(this.usuario);
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();
        }

        private void btnRefreshCategorias_Click(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();
        }

        // Apagar Categoria
        private void dgvCategorias_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Executa a exclusão para cada linha selecionada no DataGridView
            foreach (DataGridViewRow selectedRow in dgvCategorias.SelectedRows)
            {
                _ = new CategoriaController().DeleteCategoria(selectedRow.Cells["ID"].Value.ToString()!);
            }
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = new UserController().GetUsers();
        }

        // Apagar Usuário
        private void dgvUsuarios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Executa a exclusão para cada linha selecionada no DataGridView
            foreach (DataGridViewRow selectedRow in dgvUsuarios.SelectedRows)
            {
                _ = new UserController().DeleteUser(selectedRow.Cells["User"].Value.ToString()!);
            }
        }
    }
}
