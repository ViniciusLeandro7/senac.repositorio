namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxsenha.Text;

            if (usuario == null || usuario == "")
            {
                labelresultado.Text = "Usuario é obrigatorio!!!";
                labelresultado.ForeColor = Color.Red;
            }

            else if (usuario == "vinicius.leandro" && senha == "12345")
            {
                labelresultado.Text = "Autenticado com sucesso";
                labelresultado.ForeColor = Color.Green;
            }
            else
            {
                labelresultado.Text = "Usuario ou senha incorretos...";
                labelresultado.ForeColor = Color.Red;
            }


        }
    }
}