namespace AgendaMortifera
{
    public partial class frmLogin : Form
    {

        frmCadastrar screenCadastro = new frmCadastrar();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.screenCadastro.ShowDialog();
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            // Valida��o dos dados dos TextBox's

            if (tbxUser.Text != "" && tbxPassword.Text.Length > 8)
            {
                btnLogin.Enabled = true;
            }

            else
            {
                btnLogin.Enabled = false;
            }
        }
    }
}
