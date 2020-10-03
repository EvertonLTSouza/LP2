using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(txtNome.Text != "")
            //{
            //    if(cbNoturno.CheckState == CheckState.Checked)
            //    {
            //        MessageBox.Show("Aluno: " + txtNome.Text + " estuda no período noturno", "*Mensagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //    } else if (cbNoturno.CheckState == CheckState.Unchecked)
            //    {
            //        MessageBox.Show("Aluno: " + txtNome.Text + " estuda no período vespertino", "*Mensagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //    } else
            //    {
            //        MessageBox.Show("Aluno: " + txtNome.Text + " estuda no período indeterminado", "*Mensagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //    }              
            //} 
            //else
            //{
            //    MessageBox.Show("Nome deve estar preenchido", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //}

            //if (comboBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Não escolheu semestre");
            //}
            //else
            //{
            //    MessageBox.Show("Semestre selecionado " + comboBox1.SelectedItem);
            //}

            //if (listBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Cidade não selecionada");
            //}
            //else
            //{
            //    MessageBox.Show(listBox1.SelectedItem.ToString());
            //}

            //string mensagem = radioButton1.Checked ? "Norturno" : "diurno";
            //MessageBox.Show("Periodo " + mensagem);

            //string textaoDeFacebook = "\n";

            //for (int i = 0; i < checkedListBox1.SelectedItems.Count; i++)            
            //    textaoDeFacebook+= checkedListBox1.SelectedItems[i] + "\n";
            //MessageBox.Show("Selecionado" + textaoDeFacebook);

            //textaoDeFacebook = "\n";

            //for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            //    textaoDeFacebook += checkedListBox1.CheckedItems[i] + "\n";
            //MessageBox.Show("Selecionado" + textaoDeFacebook);



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("São Paulo");
            listBox1.Items.Add("Sorocaba");
            listBox1.Items.Add("Votorantim");
            listBox1.Items.Add("Campinas");
            listBox1.Items.Add("Cubatão");
            listBox1.Items.Add("Curitiba");

            listBox1.Sorted = true;

        }
    }
}
