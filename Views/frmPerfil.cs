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

        private void AtualizarDataGrid()
        {
            dgvCategorias.DataSource = new CategoriaController().GetCategorias(this.usuario);
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = this.usuario;

            this.AtualizarDataGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.AtualizarDataGrid();
        }
    }
}
