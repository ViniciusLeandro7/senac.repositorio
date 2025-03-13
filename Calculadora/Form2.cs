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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            try
            {
                // Obter os valores dos TextBoxes como strings
                string areaq = area.Text;
                string perimetroq = perimetro.Text;
                string volumeq = volume.Text;
                string resq = resultado.Text;

                // Converter as strings para valores numéricos (double)
                double areaqq = Convert.ToDouble(area.Text);        // A área (ou outra medida relevante)
                double perimetroqq = Convert.ToDouble(perimetro.Text);  // O perímetro ou outra medida relevante
                double volumeqq = Convert.ToDouble(volume.Text);    // O volume (para o caso de cubo ou outras figuras 3D)
                double res = 0;                                     // Variável para armazenar o resultado final

                // Verificar se o ComboBox está vazio ou se nenhuma forma foi selecionada
                if (cmbForma.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione uma forma geométrica.");
                    return;
                }

                // Lógica de cálculo baseada na forma selecionada
                switch (cmbForma.SelectedItem.ToString())
                {
                    case "Quadrado":
                        // Para o quadrado, se tivermos a área, podemos calcular o perímetro.
                        double ladoQuadrado = Math.Sqrt(areaqq);           // Lado do quadrado a partir da área
                        perimetroqq = (4 * ladoQuadrado).ToString();       // Perímetro = 4 * lado
                        areaqq = ladoQuadrado * ladoQuadrado;              // Área = lado²
                        res = Convert.ToDouble(perimetroqq);                // Resultado final: Perímetro
                        resultado.Text = $"Perímetro: {perimetroqq} | Área: {areaqq}";
                        break;

                    case "Retângulo":
                        // Para o retângulo, podemos calcular o comprimento e a largura usando área e perímetro.
                        double comprimentoRetangulo = perimetroqq / 2;     // Metade do perímetro para o comprimento
                        double larguraRetangulo = areaqq / comprimentoRetangulo; // Largura = área / comprimento
                        perimetroqq = (2 * (comprimentoRetangulo + larguraRetangulo)).ToString(); // Perímetro = 2 * (comprimento + largura)
                        areaqq = comprimentoRetangulo * larguraRetangulo;   // Área = comprimento * largura
                        res = Convert.ToDouble(perimetroqq);                 // Resultado final: Perímetro
                        resultado.Text = $"Perímetro: {perimetroqq} | Área: {areaqq}";
                        break;

                    case "Cubo":
                        // Para o cubo, usamos o volume para calcular o lado.
                        double ladoCubo = Math.Cbrt(volumeqq);               // Lado do cubo a partir do volume
                        perimetroqq = (12 * ladoCubo).ToString();            // Perímetro do cubo = 12 * lado
                        volumeqq = Math.Pow(ladoCubo, 3);                    // Volume = lado³
                        res = Convert.ToDouble(perimetroqq);                 // Resultado final: Perímetro
                        resultado.Text = $"Perímetro: {perimetroqq} | Volume: {volumeqq}";
                        break;

                    default:
                        MessageBox.Show("Forma geométrica desconhecida. Por favor, selecione uma forma válida.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
