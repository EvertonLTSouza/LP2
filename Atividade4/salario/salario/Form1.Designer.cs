namespace salario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.gpbCasado = new System.Windows.Forms.GroupBox();
            this.cbCasado = new System.Windows.Forms.CheckBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFam = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFam = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.gpbSexo.SuspendLayout();
            this.gpbCasado.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(43, 30);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(90, 13);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(43, 58);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(66, 13);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Salário bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(43, 84);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblFilhos.TabIndex = 0;
            this.lblFilhos.Text = "Numero de filhos";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbM);
            this.gpbSexo.Controls.Add(this.rbF);
            this.gpbSexo.Location = new System.Drawing.Point(394, 12);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(145, 89);
            this.gpbSexo.TabIndex = 1;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 2;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Checked = true;
            this.rbF.Location = new System.Drawing.Point(29, 28);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(31, 17);
            this.rbF.TabIndex = 0;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(29, 54);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(34, 17);
            this.rbM.TabIndex = 0;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // gpbCasado
            // 
            this.gpbCasado.Controls.Add(this.cbCasado);
            this.gpbCasado.Location = new System.Drawing.Point(394, 107);
            this.gpbCasado.Name = "gpbCasado";
            this.gpbCasado.Size = new System.Drawing.Size(145, 70);
            this.gpbCasado.TabIndex = 1;
            this.gpbCasado.TabStop = false;
            // 
            // cbCasado
            // 
            this.cbCasado.AutoSize = true;
            this.cbCasado.Location = new System.Drawing.Point(29, 33);
            this.cbCasado.Name = "cbCasado";
            this.cbCasado.Size = new System.Drawing.Size(62, 17);
            this.cbCasado.TabIndex = 0;
            this.cbCasado.Text = "Casado";
            this.cbCasado.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(176, 140);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(133, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar Descontos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtSalLiq);
            this.gpbDados.Controls.Add(this.txtSalFam);
            this.gpbDados.Controls.Add(this.txtIRPF);
            this.gpbDados.Controls.Add(this.txtDescIRPF);
            this.gpbDados.Controls.Add(this.txtDescINSS);
            this.gpbDados.Controls.Add(this.txtINSS);
            this.gpbDados.Controls.Add(this.lblSalLiq);
            this.gpbDados.Controls.Add(this.lblDescIRPF);
            this.gpbDados.Controls.Add(this.lblSalFam);
            this.gpbDados.Controls.Add(this.lblDescINSS);
            this.gpbDados.Controls.Add(this.lblIRPF);
            this.gpbDados.Controls.Add(this.lblINSS);
            this.gpbDados.Location = new System.Drawing.Point(46, 217);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(493, 153);
            this.gpbDados.TabIndex = 1;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(6, 16);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(73, 13);
            this.lblINSS.TabIndex = 1;
            this.lblINSS.Text = "Aliquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(6, 44);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(72, 13);
            this.lblIRPF.TabIndex = 1;
            this.lblIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalFam
            // 
            this.lblSalFam.AutoSize = true;
            this.lblSalFam.Location = new System.Drawing.Point(6, 73);
            this.lblSalFam.Name = "lblSalFam";
            this.lblSalFam.Size = new System.Drawing.Size(76, 13);
            this.lblSalFam.TabIndex = 1;
            this.lblSalFam.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(6, 106);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(75, 13);
            this.lblSalLiq.TabIndex = 1;
            this.lblSalLiq.Text = "SalárioLíquido";
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(102, 13);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(133, 20);
            this.txtINSS.TabIndex = 3;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Location = new System.Drawing.Point(102, 41);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(133, 20);
            this.txtIRPF.TabIndex = 3;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Location = new System.Drawing.Point(102, 70);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.Size = new System.Drawing.Size(133, 20);
            this.txtSalFam.TabIndex = 3;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Location = new System.Drawing.Point(102, 103);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(133, 20);
            this.txtSalLiq.TabIndex = 3;
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(258, 16);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescINSS.TabIndex = 1;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Location = new System.Drawing.Point(354, 13);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(133, 20);
            this.txtDescINSS.TabIndex = 3;
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(258, 44);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescIRPF.TabIndex = 1;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Location = new System.Drawing.Point(354, 41);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(133, 20);
            this.txtDescIRPF.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 398);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.gpbCasado);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbCasado.ResumeLayout(false);
            this.gpbCasado.PerformLayout();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gpbCasado;
        private System.Windows.Forms.CheckBox cbCasado;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.TextBox txtSalFam;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label lblSalFam;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblINSS;
    }
}

