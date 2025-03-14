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
            string operacao = label2.Text;
            double res;

            if (!valor1q.All(char.IsNumber))
            {
                Resultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            if (string.IsNullOrEmpty(valor1q) || string.IsNullOrEmpty(valor2q))
            {
                Resultado.Text = "digite um numero";
                return;
            }

            double doubleValor1 = Convert.ToDouble(valor1q);
            double doubleValor2 = Convert.ToDouble(valor2q);

            switch (operacao)
            {
                case "+":
                    res = doubleValor1 + doubleValor2;
                    Resultado.Text = Convert.ToString(res);
                    break;
                case "-":
                    res = doubleValor1 - doubleValor2;
                    Resultado.Text = Convert.ToString(res);
                    break;
                case "*":
                    res = doubleValor1 * doubleValor2;
                    Resultado.Text = Convert.ToString(res);
                    break;
                case "/":
                    res = doubleValor1 / doubleValor2;
                    Resultado.Text = Convert.ToString(res);
                    break;
                default:
                    MessageBox.Show("Selecine uma operação");
                    return;
                    break;
            }

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

            if (string.IsNullOrEmpty(valor1q) || string.IsNullOrEmpty(valor2q))
            {
                Resultado.Text = "digite um numero";
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

            if (string.IsNullOrEmpty(valor1q) || string.IsNullOrEmpty(valor2q))
            {
                Resultado.Text = "digite um numero";
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

            if (string.IsNullOrEmpty(valor1q) || string.IsNullOrEmpty(valor2q))
            {
                Resultado.Text = "digite um numero";
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

        private void Soma_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "/";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "*";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valor1q = valor1.Text;
            string valor2q = valor2.Text;

            if (!valor1q.All(char.IsNumber))
            {
                Resultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            if (string.IsNullOrEmpty(valor1q) || string.IsNullOrEmpty(valor2q))
            {
                Resultado.Text = "digite um numero";
                return;
            }

            double doubleValor1 = Convert.ToDouble(valor1q);
            double doubleValor2 = Convert.ToDouble(valor2q);

            double resultadoq = doubleValor1 + doubleValor2;

            Resultado.Text = resultadoq.ToString();
        }

        private void formatosQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }

}
