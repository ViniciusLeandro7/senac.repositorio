namespace Calculadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            string valorRaio = txtRaio.Text;


            if (string.IsNullOrWhiteSpace(valorRaio))
            {
                lblErro.Text = "Valor obrigatório";
                return false;
            }

            try
            {
                Convert.ToDouble(valorRaio);
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
            double valorRaio = Convert.ToDouble(txtRaio.Text);


            if (radioPer.Checked)
            {
                lblRes.Text = $"Perímetro: {2 * Math.PI * valorRaio:F2} ";
                return;
            }

            if (radioDia.Checked)
            {
                lblRes.Text = $"Diametro: {2 * valorRaio} ";
                return;
            }

            if (radioArea.Checked)
            {
                lblRes.Text = $"Área: {Math.PI * Math.Pow(valorRaio, 2):F2}";
                return;
            }

            if (radioVol.Checked)
            {
                lblRes.Text = $"Volume: {(4.0 / 3.0) * Math.PI * Math.Pow(valorRaio, 3):F2} ";
                return;
            }
        }



        private void radioPer_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void radioDia_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void radioArea_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void radioVol_CheckedChanged(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";
            if (!Validar())
            {
                return;
            }
            Calcular();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void quadradoRetânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
