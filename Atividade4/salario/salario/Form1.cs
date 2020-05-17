using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double salBrut, salLiq, salFam, inss, irpf;
            int numFilhos;
            String[] genero = rbF.Checked? 
                new string[] {"da Sra.", cbCasado.Checked? "Casada" : "Solteira"}: 
                new string[] {"do Sr.", cbCasado.Checked ? "Casado" : "Solteiro"};

            if(Double.TryParse(txtSalBruto.Text, out salBrut) &&
                int.TryParse(txtNumFilhos.Text, out numFilhos))
            {
                String[] aliquotas = new string[] {
                    salBrut <= 800.47 ? "7,65%" :
                    salBrut <= 1050.00 ? "8,65%" :
                    salBrut <= 1400.77 ? "9%" :
                    salBrut <= 2801.56 ? "11%" : "valor máximo atingido",

                    salBrut <= 1257.12 ? "0%" : 
                    salBrut <= 2512.08 ? "15%" : "27,5%"
            };
                String filho = numFilhos == 0 ? "sem filhos" : numFilhos > 1 ? $"e tem {numFilhos} filhos" : "e tem 1 filho";
                inss = calcInss(salBrut);
                irpf = calcIrpf(salBrut);
                salFam = calcSalFam(salBrut, numFilhos);
                salLiq = salBrut - inss - irpf + salFam;

                txtINSS.Text = aliquotas[0];
                txtDescINSS.Text = "R$ " + Convert.ToString(inss);
                txtIRPF.Text = aliquotas[1];
                txtDescIRPF.Text = "R$ " + Convert.ToString(irpf);
                txtSalFam.Text = "R$ " + Convert.ToString(salFam);
                txtSalLiq.Text = "R$ " + Convert.ToString(salLiq);
                lblDados.Text = $"Os descontos do salário {genero[0]} {txtNomeFunc.Text}, que é {genero[1]} {filho}, são de:";
            } 
            else
            {
                lblDados.Text = "Erro de conversão";
            }
        }

        private double calcSalFam(double salBrut, int numFilhos)
        {
            double salFam = salBrut <= 435.52 ? numFilhos * 22.33 : salBrut <= 654.61 ? numFilhos * 15.74 : 0;
            return salFam;
        }

        private double calcIrpf(double salBrut)
        {
            double irpf = salBrut <= 1257.12 ? 0 : salBrut <= 2512.08 ? salBrut * 0.15 : salBrut * 0.275;
            return irpf;
        }

        private double calcInss(double salBrut)
        {
            double inss = salBrut <= 800.47 ? salBrut * 0.0765 :
            salBrut <= 1050.00 ? salBrut * 0.0865 :
            salBrut <= 1400.77 ? salBrut * 0.09 :
            salBrut <= 2801.56 ? salBrut * 0.11 :
            308.17;
            return inss;
        }
    }
}
