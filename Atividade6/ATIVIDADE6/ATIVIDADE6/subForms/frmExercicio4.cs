using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE6.subForms
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnQtdCaracterNumerico_Click(object sender, EventArgs e)
        {
            var list = rtxtPrincipal.Text.ToList();
            var qtdCaracterNumerico = 0;
            for (int i = 0; i < list.Count; i++)
                if (Char.IsNumber(list[i]))
                    qtdCaracterNumerico++;
            MessageBox.Show($"Foram encontrados {qtdCaracterNumerico} caracteres numéricos.");
        }

        private void btnPrimeiroBranco_Click(object sender, EventArgs e)
        {
            var list = rtxtPrincipal.Text.ToList();
            var posBranco = 0;
            var continuar = true;
            
            while (continuar)
            {
                if (posBranco < list.Count) { 
                    if (Char.IsWhiteSpace(list[posBranco])) continuar = false;
                } else
                {
                    continuar = false;
                }
                posBranco++;
            }
            var msg = posBranco > list.Count ? "Não há espaços em branco" : $"O pirmeiro caracter em branco está na {posBranco + 1}° posição.";
            MessageBox.Show(msg);
        }

        private void btnQtdCaracterAlfabetico_Click(object sender, EventArgs e)
        {
            var list = rtxtPrincipal.Text.ToList();
            var qtdCaracterAlfabetico = 0;
            foreach (var c in list)
                if (Char.IsLetter(c))
                    qtdCaracterAlfabetico++;
            MessageBox.Show($"Foram encontrados {qtdCaracterAlfabetico} caracteres numéricos.");
        }
    }
}
