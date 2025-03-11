namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            string valor1q = valor1.Text;
            string valor2q = valor2.Text;

            if (!valor1q.All(char.IsNumber))
            {
                Resultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleValor1 = Convert.ToDouble(valor1q);
            double doubleValor2 = Convert.ToDouble(valor2q);

            double resultadoq = doubleValor1 + doubleValor2;

            Resultado.Text = resultadoq.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor1q = valor1.Text;
            string valor2q = valor2.Text;

            if (!valor1q.All(char.IsNumber))
            {
                Resultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleValor1 = Convert.ToDouble(valor1q);
            double doubleValor2 = Convert.ToDouble(valor2q);

            double resultadoq = doubleValor1 - doubleValor2;

            Resultado.Text = resultadoq.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor1q = valor1.Text;
            string valor2q = valor2.Text;

            if (!valor1q.All(char.IsNumber))
            {
                Resultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleValor1 = Convert.ToDouble(valor1q);
            double doubleValor2 = Convert.ToDouble(valor2q);

            double resultadoq = doubleValor1 * doubleValor2;

            Resultado.Text = resultadoq.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1q = valor1.Text;
            string valor2q = valor2.Text;

            if (!valor1q.All(char.IsNumber))
            {
                Resultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleValor1 = Convert.ToDouble(valor1q);
            double doubleValor2 = Convert.ToDouble(valor2q);

            double resultadoq = doubleValor1 / doubleValor2;

            Resultado.Text = resultadoq.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 novaAba = new Form1();
            this.Hide();
            novaAba.Show();
        }
    }
}
