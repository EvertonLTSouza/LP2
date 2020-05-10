namespace PesoIdeal
{
    partial class PesoIdeal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtCalcular = new System.Windows.Forms.Button();
            this.GbGenero = new System.Windows.Forms.GroupBox();
            this.RbtnFeminino = new System.Windows.Forms.RadioButton();
            this.RbtnMasculino = new System.Windows.Forms.RadioButton();
            this.LblPesoAtual = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtPesoAtual = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.GbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtCalcular
            // 
            this.BtCalcular.Location = new System.Drawing.Point(127, 108);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtCalcular.TabIndex = 0;
            this.BtCalcular.Text = "Calcular";
            this.BtCalcular.UseVisualStyleBackColor = true;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // GbGenero
            // 
            this.GbGenero.Controls.Add(this.RbtnFeminino);
            this.GbGenero.Controls.Add(this.RbtnMasculino);
            this.GbGenero.Location = new System.Drawing.Point(279, 10);
            this.GbGenero.Name = "GbGenero";
            this.GbGenero.Size = new System.Drawing.Size(119, 121);
            this.GbGenero.TabIndex = 1;
            this.GbGenero.TabStop = false;
            this.GbGenero.Text = "Gênero";
            // 
            // RbtnFeminino
            // 
            this.RbtnFeminino.AutoSize = true;
            this.RbtnFeminino.Location = new System.Drawing.Point(19, 74);
            this.RbtnFeminino.Name = "RbtnFeminino";
            this.RbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.RbtnFeminino.TabIndex = 0;
            this.RbtnFeminino.Text = "Feminino";
            this.RbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // RbtnMasculino
            // 
            this.RbtnMasculino.AutoSize = true;
            this.RbtnMasculino.Checked = true;
            this.RbtnMasculino.Location = new System.Drawing.Point(19, 34);
            this.RbtnMasculino.Name = "RbtnMasculino";
            this.RbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.RbtnMasculino.TabIndex = 0;
            this.RbtnMasculino.TabStop = true;
            this.RbtnMasculino.Text = "Masculino";
            this.RbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // LblPesoAtual
            // 
            this.LblPesoAtual.AutoSize = true;
            this.LblPesoAtual.Location = new System.Drawing.Point(9, 12);
            this.LblPesoAtual.Name = "LblPesoAtual";
            this.LblPesoAtual.Size = new System.Drawing.Size(58, 13);
            this.LblPesoAtual.TabIndex = 2;
            this.LblPesoAtual.Text = "Peso Atual";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(9, 56);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(34, 13);
            this.LblAltura.TabIndex = 2;
            this.LblAltura.Text = "Altura";
            // 
            // TxtPesoAtual
            // 
            this.TxtPesoAtual.Location = new System.Drawing.Point(127, 12);
            this.TxtPesoAtual.Name = "TxtPesoAtual";
            this.TxtPesoAtual.Size = new System.Drawing.Size(118, 20);
            this.TxtPesoAtual.TabIndex = 3;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(127, 56);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(118, 20);
            this.TxtAltura.TabIndex = 3;
            // 
            // PesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 153);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtPesoAtual);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblPesoAtual);
            this.Controls.Add(this.GbGenero);
            this.Controls.Add(this.BtCalcular);
            this.Name = "PesoIdeal";
            this.Text = "Peso Ideal";
            this.GbGenero.ResumeLayout(false);
            this.GbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCalcular;
        private System.Windows.Forms.GroupBox GbGenero;
        private System.Windows.Forms.RadioButton RbtnFeminino;
        private System.Windows.Forms.RadioButton RbtnMasculino;
        private System.Windows.Forms.Label LblPesoAtual;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtPesoAtual;
        private System.Windows.Forms.TextBox TxtAltura;
    }
}

