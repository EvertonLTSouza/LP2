using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double A, B, C;
            if (Double.TryParse(TxtLadoA.Text, out A) &&
                Double.TryParse(TxtLadoB.Text, out B) &&
                Double.TryParse(TxtLadoC.Text, out C))
            {
                if (eTriangulo(A, B, C))
                {
                    MessageBox.Show("É um triângulo " + tipoTriangulo(A, B, C));
                }
                else
                {
                    MessageBox.Show("Valores não fazem um triângulo.");
                }
            }
            else
            {
                MessageBox.Show("Devem ser digitadso valores numéricos.");
            }
        }

        private string tipoTriangulo(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "equilatero";
            }
            else if (a == b || b == c)
            {
                return "escaleno";
            }
            else { return "isoseles"; }
        }

        private bool eTriangulo(double a, double b, double c)
        {
            bool ba = ((Math.Abs(b - c) < a) && (a < (b + c)));

            bool bb = ((Math.Abs(a - c) < b) && (b < (a + c)));

            bool bc = ((Math.Abs(b - a) < c) && (c < (b + a)));

            return ba && bb && bc;

        }
    }
}
