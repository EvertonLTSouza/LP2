using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P30481923018
{
    public partial class frmProva : Form
    {
        private double[,] saida = new double[8,4];
        const string espacador = "-------------------------------------------------------------------";
        public frmProva()
        {
            InitializeComponent();
        }        
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var continuar = true;
            var totalMes = 0.0;
            var total = 0.0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    do
                    {
                        continuar = !Double.TryParse(
                            Interaction.InputBox($"informe a vendo da {j+1}° Semana do {i+1}° Mês", "Venda", XPos: 100, YPos:100), out saida[i,j]
                            );
                    } while (continuar);
                }
            }
            
            for (int i = 0; i < 8; i++)
            {
                lbSaida.Items.Add(espacador);
                for (int j = 0; j < 4; j++)
                {
                    lbSaida.Items.Add($"Totoal da {j + 1}° semana do {i + 1}° mês: R$ {saida[i,j].ToString("0.00")}");
                    totalMes += saida[i, j];
                }
                lbSaida.Items.Add(espacador);
                lbSaida.Items.Add($"Total do {i + 1}° Mês: R$ {totalMes.ToString("0.00")}");
                total += totalMes;
                totalMes = 0;
            }
            lbSaida.Items.Add(espacador);
            lbSaida.Items.Add($"Total: R$ {total.ToString("0.00")}");
        }
    }
}
