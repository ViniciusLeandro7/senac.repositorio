namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private bool Validar()
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;

            if (string.IsNullOrWhiteSpace(valor1) || string.IsNullOrWhiteSpace(valor2))
            {
                lblErro.Text = "Valor obrigatório";
                return false;
            }

            try
            {
                Convert.ToDouble(valor1);
                Convert.ToDouble(valor2);
                return true;
            }
            catch
            {
                lblErro.Text = "Digite somente números";
                return false;
            }
        }

        private void Calcular()
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;
            string Operacao = lblOperacao.Text;
            double v1 = Convert.ToDouble(valor1);
            double v2 = Convert.ToDouble(valor2);
            double calc;

            switch (Operacao)
            {
                case "+":
                    calc = v1 + v2;
                    lblRes.Text = Convert.ToString(calc);
                    break;
                case "-":
                    calc = v1 - v2;
                    lblRes.Text = Convert.ToString(calc);
                    break;
                case "*":
                    calc = v1 * v2;
                    lblRes.Text = Convert.ToString(calc);
                    break;
                case "/":
                    calc = v1 / v2;
                    lblRes.Text = Convert.ToString(calc);
                    break;
                default:
                    MessageBox.Show("Selecione uma operação");
                    break;
            }

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;


            if (Validar())
            {
                double calcular = Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
                lblRes.Text = $"{calcular}";
                return;
            }


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;

            if (Validar())
            {
                double calcular = Convert.ToDouble(valor1) - Convert.ToDouble(valor2);
                lblRes.Text = $"{calcular}";
                return;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;

            if (Validar())
            {
                double calcular = Convert.ToDouble(valor1) * Convert.ToDouble(valor2);
                lblRes.Text = $"{calcular}";
                return;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string Res = lblRes.Text;

            if (Validar())
            {
                double calcular = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
                lblRes.Text = $"{calcular}";
                return;
            }
        }

        private void radioSoma_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacao.Text = "+";
        }

        private void radioSub_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacao.Text = "-";
        }

        private void radioMult_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacao.Text = "*";
        }

        private void radioDiv_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacao.Text = "/";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";
            if (Validar())
            {
                Calcular();
            }

        }

        private void perimetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 novaAba = new Form1();
            //this.Hide();
            novaAba.Show();
        }

        private void esferasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 novaAbaEsfera = new Form3();
            novaAbaEsfera.Show();
        }
    }
}
