using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<ClassCliente> Cliente = [];
        private readonly BindingSource BindingSource = [];
        private int contadorId = 1;

        public Form1()
        {
            InitializeComponent();
            InicializarClientes();
            ConfigurarDataGridView();
        }

        private void InicializarClientes()
        {
            Cliente.Add(new ClassCliente
            {
                Id = contadorId++,
                Nome = "Vinicius",
                dataNascimento = "22/09/2004",
                telefone = "11954842582",
                email = "vinicius@email.com",
                Endereco = new ClassEndereco
                {
                    longradouro = "Dupret",
                    numero = "667",
                    complemento = "apt102",
                    bairro = "Vila Clementino",
                    cep = "040250130",
                    estado = "São Paulo",
                    municipio = "SP"
                }
            });

            Cliente.Add(new ClassCliente
            {
                Id = contadorId++,
                Nome = "Sebastiana",
                dataNascimento = "01/07/1966",
                telefone = "11954842583",
                email = "sebastiana@email.com",
                Endereco = new ClassEndereco
                {
                    longradouro = "Lister",
                    numero = "25",
                    complemento = "Casa",
                    bairro = "São José",
                    cep = "04843510",
                    estado = "São Paulo",
                    municipio = "SP"
                }
            });


        }

        private void ConfigurarDataGridView()
        {
            BindingSource.DataSource = Cliente;
            dataGridView1.DataSource = BindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (Cliente.Exists(c => c.email == textBox4.Text || c.telefone == maskedTextBox3.Text))
            {
                MessageBox.Show("O e-mail ou telefone já está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novoCliente = new ClassCliente
            {
                Id = contadorId++,
                Nome = textBox1.Text,
                dataNascimento = maskedTextBox1.Text,
                telefone = maskedTextBox3.Text,
                email = textBox4.Text,
                Endereco = new ClassEndereco
                {
                    longradouro = textBox6.Text,
                    numero = textBox7.Text,
                    complemento = textBox8.Text,
                    bairro = textBox9.Text,
                    cep = maskedTextBox2.Text,
                    estado = comboBox3.Text,
                    municipio = textBox10.Text
                }
            };

            Cliente.Add(novoCliente);
            BindingSource.ResetBindings(false);
            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private bool ValidarCampos()
        {
            var erros = new List<string>();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
                erros.Add("- Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
                erros.Add("- Data de nascimento é obrigatória.");

            if (!textBox4.Text.Contains("@"))
                erros.Add("- E-mail inválido.");

            if (erros.Any())
            {
                MessageBox.Show(string.Join("\n", erros), "Erros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox4.Clear();
            maskedTextBox3.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            comboBox3.SelectedIndex = -1;
        }
    }

}


public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string DataNascimento { get; set; }
    public string NomeSocial { get; set; }
    public string Genero { get; set; }
    public string Email { get; set; }
    public bool CategoriaPF { get; set; }
    public bool CategoriaPJ { get; set; }
    public bool Estrangeiro { get; set; }
}


public class Endereco
{
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }
    public string Municipio { get; set; }
    public string Estado { get; set; }
}
