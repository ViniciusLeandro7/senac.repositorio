using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<ClassCliente> Cliente = [];
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Endereco> listaEnderecos = new List<Endereco>();
        private int contadorId = 1;

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
            if (!ValidarCampos())
                return;

            
            Cliente novoCliente = new Cliente
            {
                Id = contadorId++, 
                Nome = textBox1.Text,
                Telefone = maskedTextBox3.Text,
                DataNascimento = maskedTextBox1.Text,
                NomeSocial = textBox5.Text,
                Genero = comboBox1.Text,
                Email = textBox4.Text,
                CategoriaPF = radioButton2.Checked,
                CategoriaPJ = radioButton1.Checked,
                Estrangeiro = checkBox1.Checked
            };

            
            Endereco novoEndereco = new Endereco
            {
                Cep = maskedTextBox2.Text,
                Logradouro = textBox6.Text,
                Complemento = textBox8.Text,
                Bairro = textBox9.Text,
                Numero = textBox7.Text,
                Municipio = textBox10.Text,
                Estado = comboBox3.Text
            };

            
            listaClientes.Add(novoCliente);
            listaEnderecos.Add(novoEndereco);

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
        }

        
        private bool ValidarCampos()
        {
            string mensagemErro = ""; 

            if (string.IsNullOrWhiteSpace(textBox1.Text))
                mensagemErro += "- O campo Nome é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
                mensagemErro += "- O campo Gênero é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(textBox4.Text) || !textBox4.Text.Contains("@"))
                mensagemErro += "- O campo Email é obrigatório e deve ser válido.\n";

            if (string.IsNullOrWhiteSpace(comboBox3.Text))
                mensagemErro += "- O campo Estado é obrigatório.\n";

            if (!ValidarCep(maskedTextBox2.Text))
                mensagemErro += "- O campo CEP deve estar no formato válido do Brasil.\n";

            if (!ValidarTelefone(maskedTextBox3.Text))
                mensagemErro += "- O campo Telefone deve estar no formato válido do Brasil.\n";

            if (!ValidarData(maskedTextBox1.Text))
                mensagemErro += "- O campo Data de Nascimento deve estar no formato válido (dia/mês/Ano).\n";

            
            if (!string.IsNullOrEmpty(mensagemErro))
            {
                
                label8.Text = mensagemErro;
                label8.ForeColor = System.Drawing.Color.Red;
                return false; 
            }

            
            label8.Text = "";
            return true; 
        }


        private bool ValidarCep(string cep)
        {
            if (cep.Length == 9 && cep.Contains("-"))
            {
                // Divide o CEP em duas partes (antes e depois do hífen) e verifica se são números
                string[] partesCep = cep.Split('-');
                if (partesCep.Length == 2 && partesCep[0].Length == 5 && partesCep[1].Length == 3)
                {
                    // Verifica se ambas as partes são números
                    return int.TryParse(partesCep[0], out _) && int.TryParse(partesCep[1], out _);
                }
            }
            return false;
        }


        private bool ValidarTelefone(string telefone)
        {
            if (telefone.Length == 14 && telefone.StartsWith("()") && telefone.Contains("()") && telefone.Contains("-"))
            {

                string numerosTelefone = telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                return numerosTelefone.Length == 11 && long.TryParse(numerosTelefone, out _);
            }
            return false;
        }

        
        private bool ValidarData(string data)
        {
            DateTime temp;
            return DateTime.TryParse(data, out temp);
        }

        
        private void LimparCampos()
        {
            textBox1.Clear();
            maskedTextBox3.Clear();
            maskedTextBox1.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();
            maskedTextBox2.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox7.Clear();
            textBox10.Clear();
            comboBox3.SelectedIndex = -1;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            checkBox1.Checked = false;

            
            label8.Text = "";
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

}
