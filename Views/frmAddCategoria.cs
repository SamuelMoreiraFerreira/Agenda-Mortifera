using AgendaMortifera.Controllers;
using AgendaMortifera.Data;
using AgendaMortifera.StructureDB;
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

namespace AgendaMortifera.Views
{
    public partial class frmAddCategoria : Form
    {

        public frmAddCategoria()
        {
            InitializeComponent();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            // Inserindo Categoria

            bool addCategoria = new CategoriaController().CreateCategoria(tbxNomeCategoria.Text);

            if (addCategoria)
            {

                this.Close();

                // Sucesso

                MessageBox.Show("Categoria cadastrada no Banco de Dados do Inferno!", "Sucesso");

            }

            else
            {
                // Erro

                MessageBox.Show("Ocorreu um erro ao inserir. Tente novamente!", "Problemas Técnicos");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
