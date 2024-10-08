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

                && tbxUser.Text != ""

                && tbxEmail.Text != ""

                && tbxPecado.Text != ""

                && tbxPassword.Text.Length > 8

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
    }
}
