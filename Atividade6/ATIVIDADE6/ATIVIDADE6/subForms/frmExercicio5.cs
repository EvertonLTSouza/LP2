using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE6.subForms
{
    public partial class frmExercicio5 : Form
    {
        public List<char> caracteresPermitidos = new List<char>{
            (char)Keys.D0,
            (char)Keys.D1,
            (char)Keys.D2,
            (char)Keys.D3,
            (char)Keys.D4,
            (char)Keys.D5,
            (char)Keys.D6,
            (char)Keys.D7,
            (char)Keys.D8,
            (char)Keys.D9,
            (char)Keys.Back};
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.caracteresPermitidos.Contains(e.KeyChar)) e.KeyChar = (char)Keys.None;
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.caracteresPermitidos.Contains(e.KeyChar)) e.KeyChar = (char)Keys.None;
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var num1 = Int32.Parse(txtNumero1.Text);
            var num2 = Int32.Parse(txtNumero2.Text);

            var result = num1 < num2 ? rnd.Next(num1, num2) : rnd.Next(num2, num1);

            MessageBox.Show($"Numero sorteado: {result}");
        }
    }
}
