using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnQuadrado.Checked)
            {
                double lado = double.Parse(txtLado1.Text);
                double perimetro = 4 * lado;
                lblResultado.Text = "O perímetro do quadrado é: " + perimetro;
            }
            else if (rbtnRetangulo.Checked)
            {
                double comprimento = double.Parse(txtLado1.Text);
                double largura = double.Parse(txtLado2.Text);
                double perimetro = 2 * (comprimento + largura);
                lblResultado.Text = "O perímetro do retângulo é: " + perimetro;
            }
            else if (rbtnTriangulo.Checked)
            {
                double lado1 = double.Parse(txtLado1.Text);
                double lado2 = double.Parse(txtLado2.Text);
                double lado3 = double.Parse(txtLado3.Text);
                double perimetro = lado1 + lado2 + lado3;
                lblResultado.Text = "O perímetro do triângulo é: " + perimetro;
            }
            else
            {
                lblResultado.Text = "Selecione uma forma geométrica.";
            }
        }
    }
}
