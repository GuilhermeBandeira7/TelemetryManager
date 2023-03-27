using NewTelemetryManager;


namespace TelemetryManager.Forms
{
    public partial class Frm_Login : Form
    {
        XmlHelperAuthentication authentication;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            authentication = new XmlHelperAuthentication(txb_usuario.Text, txb_senha.Text);
            if (authentication.isAuthenticated)
            {
                Frm_MainMenu mainMenu = new Frm_MainMenu();

                NewTelemetryManager.TelemetryManager.Instance.LoginForm = this;
                mainMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Senha ou Usuário inválidos", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
