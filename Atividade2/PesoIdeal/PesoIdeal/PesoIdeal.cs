using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class PesoIdeal : Form
    {
        public PesoIdeal()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            double altura, pesoAtual, pesoIdeal = 0;
            if (
                !Double.TryParse(TxtPesoAtual.Text, out pesoAtual) ||
                !Double.TryParse(TxtAltura.Text, out altura)
                ) { MessageBox.Show("Peso e altura devem ser números válidos."); }
            else if (RbtnMasculino.Checked)
            {
                pesoIdeal = calPesoIdeal('m', altura);
            } else
            {
                pesoIdeal = calPesoIdeal('f', altura);
            }

            if (pesoIdeal > pesoAtual)
            {
                MessageBox.Show("Pode comer, está abaixo");
            } else if (pesoIdeal < pesoAtual) {
                MessageBox.Show("Está na hora de fazer um regime!!");
            } else
            {
                MessageBox.Show("Está no peso certo, não se mexa e não coma nada!!");
            }
        }

        private double calPesoIdeal(char v, double altura)
        {
            if (v == 'm')
            {
                return (72.7 * altura) - 58;
            }
            else if (v == 'f')
            {
                return (62.1 * altura) - 44.7;
            } else
            {
                return 0;
            }
        }
    }
}
