namespace ATIVIDADE6
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.btnInsereTexto = new System.Windows.Forms.Button();
            this.btnInsereAsterisco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(131, 36);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(199, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(46, 36);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 1;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(131, 101);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(199, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(46, 101);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(49, 159);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(281, 23);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verifica Igualdade";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // btnInsereTexto
            // 
            this.btnInsereTexto.Location = new System.Drawing.Point(49, 208);
            this.btnInsereTexto.Name = "btnInsereTexto";
            this.btnInsereTexto.Size = new System.Drawing.Size(281, 23);
            this.btnInsereTexto.TabIndex = 3;
            this.btnInsereTexto.Text = "Insere 1 em 2";
            this.btnInsereTexto.UseVisualStyleBackColor = true;
            this.btnInsereTexto.Click += new System.EventHandler(this.btnInsereTexto_Click);
            // 
            // btnInsereAsterisco
            // 
            this.btnInsereAsterisco.Location = new System.Drawing.Point(49, 260);
            this.btnInsereAsterisco.Name = "btnInsereAsterisco";
            this.btnInsereAsterisco.Size = new System.Drawing.Size(281, 23);
            this.btnInsereAsterisco.TabIndex = 4;
            this.btnInsereAsterisco.Text = "Insere * em 1";
            this.btnInsereAsterisco.UseVisualStyleBackColor = true;
            this.btnInsereAsterisco.Click += new System.EventHandler(this.btnInsereAsterisco_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 328);
            this.Controls.Add(this.btnInsereAsterisco);
            this.Controls.Add(this.btnInsereTexto);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Button btnInsereTexto;
        private System.Windows.Forms.Button btnInsereAsterisco;
    }
}