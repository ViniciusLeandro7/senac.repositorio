using System.Diagnostics.Eventing.Reader;

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

        List<string> listaSenhas = new List<string>() { "neymar.jr", "vinicius.leandro", "sorriso" };
        List<string> listaUsuarios = new List<string>() { "bruna", "123456", "smile" };

        private void Entrar_Click(object sender, EventArgs e)
        {
            
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxsenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelresultado.Text = "Usuario é obrigatorio!!!";
                labelresultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                labelresultado.Text = "Senha é obrigatorio!!!";
                labelresultado.ForeColor = Color.Red;
                return;
            }

            int posicaousuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaousuarioEncontrado = i;
                }
            }

            if (posicaousuarioEncontrado > -1 && senha == listaSenhas[posicaousuarioEncontrado])
            {
                labelresultado.Text = "Autenticado com sucesso";
                labelresultado.ForeColor = Color.Green;
                return;
            }

            else
            {
                labelresultado.Text = "Usuario ou senha incorretos...";
                labelresultado.ForeColor = Color.Red;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String usuariocq = usuarioc.Text;
            String senhacq = senhac.Text;

            Boolean Usuario_encontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuariocq == listaUsuarios[i])
                {
                    Usuario_encontrado = true;
                }
            }
            if (!Usuario_encontrado)
            {
                listaUsuarios.Add(usuariocq);
                listaSenhas.Add(senhacq);
                resultado.Text = "Cadastrado com sucesso";
             
            }
            else
            {
                resultado.Text = "Usuario ja Cadastrado";
            }


        }
    }
}