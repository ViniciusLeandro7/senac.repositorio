using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(txtRaio.Text);

            if (rbtnDiametro.Checked)
            {
                double diametro = 2 * raio;
                lblResultado.Text = "Diâmetro: " + diametro;
            }
            else if (rbtnPerimetro.Checked)
            {
                double perimetro = 2 * Math.PI * raio;
                lblResultado.Text = "Perímetro (Circunferência): " + perimetro;
            }
            else if (rbtnArea.Checked)
            {
                double area = Math.PI * Math.Pow(raio, 2);
                lblResultado.Text = "Área: " + area;
            }
            else if (rbtnVolume.Checked)
            {
                double volume = (4 / 3) * Math.PI * Math.Pow(raio, 3);
                lblResultado.Text = "Volume: " + volume;
            }
            else
            {
                lblResultado.Text = "Selecione uma operação.";
            }
        }
    }
}
