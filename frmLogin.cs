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
    }
}
