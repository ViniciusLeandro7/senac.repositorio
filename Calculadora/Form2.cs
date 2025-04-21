using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            string valor1 = txtLado1.Text;
            string valor2 = txtLado2.Text;
            string valor3 = txtLado3.Text;

            if (TipoFigura() == 0) //QUADRADO
            {
                if (string.IsNullOrWhiteSpace(valor1))
                {
                    lblErro.Text = "Valor obrigatório";
                    return false;
                }
            }

            if (TipoFigura() == 1) //RETÂNGULO
            {
                if (string.IsNullOrWhiteSpace(valor1) || string.IsNullOrWhiteSpace(valor2) || string.IsNullOrWhiteSpace(valor3))
                {
                    lblErro.Text = "Valor obrigatório";
                    return false;
                }
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

        private int Tipo()
        {

            if (radioPer.Checked)
            {
                return 0;
            }
            else if (radioArea.Checked)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private int TipoFigura()
        {
            if (radioQuad.Checked) // QUADRADO SELECIONADO
            {
                return 0;
            }
            else // RETANGULO SELECIONADO
            {
                return 1;
            }
        }

        private void Calcular()
        {
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);

            switch (Tipo()) // 
            {
                case 0: // Perímetro
                    if (TipoFigura() == 0) // Quadrado
                    {
                        lblRes.Text = $"Perímetro: {lado1 * 4}";
                    }
                    else // Retângulo
                    {
                        lblRes.Text = $"Perímetro: {2 * (lado1 + lado2)}";
                    }
                    break;
                case 1: // Área
                    if (TipoFigura() == 0) // Quadrado
                    {
                        lblRes.Text = $"Área: {lado1 * lado1}";
                    }
                    else // Retângulo
                    {
                        lblRes.Text = $"Área: {lado1 * lado2}";
                    }
                    break;
                case 2: // Volume
                    if (TipoFigura() == 0) // Cubo
                    {
                        lblRes.Text = $"Volume: {lado1 * lado1 * lado1}";
                    }
                    else // Paralelepípedo
                    {
                        lblRes.Text = $"Volume: {lado1 * lado2 * lado3}";
                    }
                    break;
                default:
                    break;
            }




        }

        private void radioQuad_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Text = "";
            txtLado2.Hide(); // TEXT BOX 2 SOME
            txtLado3.Hide(); // TEXT BOX 3 SOME
        }

        private void radioRet_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Text = "";
            txtLado2.Show(); // TEXT BOX 2 APARECE
            txtLado3.Show(); // TEXT BOX 3 APARECE
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";
            if (Validar())
            {
                Calcular();
            }

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
