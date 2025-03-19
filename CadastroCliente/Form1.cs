using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<ClassCliente> Cliente = [];

        public Form1()
        {
            InitializeComponent();
            ClassEndereco enderecoVinicius = new ClassEndereco() { longradouro = "casa", numero = "667", complemento = "apt102", bairro = "vila clementino", cep = "040250130", estado = "São Paulo", municipio = "SP" };
            ClassCliente Vinicius = new ClassCliente() { Id = 0, Nome = "vinicius", dataNascimento = "22/09/2004", etnia = Etnia.Preto, Tipo = TipoCliente.PF };
            Cliente.Add(Vinicius);


            ClassEndereco enderecoSebastiana = new ClassEndereco() { longradouro = "casa", numero = "25", complemento = "casa", bairro = "sao jose", cep = "04843510", estado = "São Paulo", municipio = "SP" };
            ClassCliente Sebastiana = new ClassCliente() { Id = 1, Nome = "sebastiana", dataNascimento = "01/07/1966", etnia = Etnia.Branco, Tipo = TipoCliente.PF };
            Cliente.Add(Sebastiana);

            ClassEndereco enderecoHermogenes = new ClassEndereco() { longradouro = "casa", numero = "25", complemento = "casa", bairro = "sao jose", cep = "04843510", estado = "São Paulo", municipio = "SP" };
            ClassCliente Hermogenes = new ClassCliente() { Id = 1, Nome = "sebastiana", dataNascimento = "01/07/1966", etnia = Etnia.Branco, Tipo = TipoCliente.PF };
            Cliente.Add(Hermogenes);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DADOS

            string nome = textBox1.Text;
            string telefone = maskedTextBox3.Text;
            string datanascimento = maskedTextBox1.Text;
            string nomesocial = textBox5.Text;
            string genero = comboBox1.Text;
            string email = textBox4.Text;

            //ENDEREÇO

            string cep = maskedTextBox2.Text;
            string longradouro = textBox6.Text;
            string complemento = textBox8.Text;
            string bairro = textBox9.Text;
            string numero = textBox7.Text;
            string municipio = textBox10.Text;
            string estado = comboBox3.Text;

            // CATEGORIA

            bool PF = radioButton2.Checked;
            bool PJ = radioButton1.Checked;
            bool estrangeiro = checkBox1.Checked;

            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(telefone))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(datanascimento))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(genero))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nomesocial))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                label8.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                label8.ForeColor = Color.Red;
                return;
            }

        }
    }
}
