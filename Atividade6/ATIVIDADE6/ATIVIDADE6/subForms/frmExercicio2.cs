using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE6
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if(txtPalavra1.Text.CompareTo(txtPalavra2.Text) == 0)
            {
                MessageBox.Show("Palavra 1 é igual à Palavra 2");
            } else {
                MessageBox.Show("Palavra 1 é diferente de Palavra 2");
            }
        }

        private void btnInsereTexto_Click(object sender, EventArgs e)
        {
            var meioTexto2 = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Insert(meioTexto2, txtPalavra1.Text);
        }

        private void btnInsereAsterisco_Click(object sender, EventArgs e)
        {
            var meioTexto2 = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meioTexto2, "**");
        }
    }
}
