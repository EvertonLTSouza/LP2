using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double altura, raio;
            if (double.TryParse(txtAltura.Text, out altura) &&
                double.TryParse(txtRaio.Text, out raio))
                    txtVolume.Text = calcularVolume(raio, altura).ToString("N2");
            else
                MessageBox.Show("Entradas Inválidas");
        }

        public double calcularVolume(double raio, double altura)
        {
            double result;
            result = Math.PI * Math.Pow(raio,2) * altura;
            return result;
        }
    }
}
