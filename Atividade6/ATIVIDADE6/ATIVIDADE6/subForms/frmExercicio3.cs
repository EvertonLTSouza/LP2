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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void frmExercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove1De2_Click(object sender, EventArgs e)
        {            
            var index = -1;
            do
            {
                index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
                if (index != -1) txtPalavra2.Text = txtPalavra2.Text.Substring(0, index) + txtPalavra2.Text.Substring(index + txtPalavra1.Text.Length);
            } while (index != -1);
        }

        private void btnRemove1De2Replace_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnReverter_Click(object sender, EventArgs e)
        {
            var list = txtPalavra1.Text.ToList();
            list.Reverse();
            foreach (var c in list)
            {
                txtPalavra2.Text += c;
            }
        }
    }
}
