namespace ATIVIDADE6.subForms
{
    partial class frmExercicio4
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
            this.btnQtdCaracterAlfabetico = new System.Windows.Forms.Button();
            this.btnPrimeiroBranco = new System.Windows.Forms.Button();
            this.btnQtdCaracterNumerico = new System.Windows.Forms.Button();
            this.rtxtPrincipal = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnQtdCaracterAlfabetico
            // 
            this.btnQtdCaracterAlfabetico.Location = new System.Drawing.Point(57, 213);
            this.btnQtdCaracterAlfabetico.Name = "btnQtdCaracterAlfabetico";
            this.btnQtdCaracterAlfabetico.Size = new System.Drawing.Size(281, 23);
            this.btnQtdCaracterAlfabetico.TabIndex = 3;
            this.btnQtdCaracterAlfabetico.Text = "Quantidade caracter alfabético";
            this.btnQtdCaracterAlfabetico.UseVisualStyleBackColor = true;
            this.btnQtdCaracterAlfabetico.Click += new System.EventHandler(this.btnQtdCaracterAlfabetico_Click);
            // 
            // btnPrimeiroBranco
            // 
            this.btnPrimeiroBranco.Location = new System.Drawing.Point(57, 161);
            this.btnPrimeiroBranco.Name = "btnPrimeiroBranco";
            this.btnPrimeiroBranco.Size = new System.Drawing.Size(281, 23);
            this.btnPrimeiroBranco.TabIndex = 2;
            this.btnPrimeiroBranco.Text = "1° caracter branco";
            this.btnPrimeiroBranco.UseVisualStyleBackColor = true;
            this.btnPrimeiroBranco.Click += new System.EventHandler(this.btnPrimeiroBranco_Click);
            // 
            // btnQtdCaracterNumerico
            // 
            this.btnQtdCaracterNumerico.Location = new System.Drawing.Point(57, 112);
            this.btnQtdCaracterNumerico.Name = "btnQtdCaracterNumerico";
            this.btnQtdCaracterNumerico.Size = new System.Drawing.Size(281, 23);
            this.btnQtdCaracterNumerico.TabIndex = 1;
            this.btnQtdCaracterNumerico.Text = "Quantidade caracter numérico";
            this.btnQtdCaracterNumerico.UseVisualStyleBackColor = true;
            this.btnQtdCaracterNumerico.Click += new System.EventHandler(this.btnQtdCaracterNumerico_Click);
            // 
            // rtxtPrincipal
            // 
            this.rtxtPrincipal.Location = new System.Drawing.Point(57, 42);
            this.rtxtPrincipal.Name = "rtxtPrincipal";
            this.rtxtPrincipal.Size = new System.Drawing.Size(281, 43);
            this.rtxtPrincipal.TabIndex = 0;
            this.rtxtPrincipal.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 275);
            this.Controls.Add(this.rtxtPrincipal);
            this.Controls.Add(this.btnQtdCaracterAlfabetico);
            this.Controls.Add(this.btnPrimeiroBranco);
            this.Controls.Add(this.btnQtdCaracterNumerico);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQtdCaracterAlfabetico;
        private System.Windows.Forms.Button btnPrimeiroBranco;
        private System.Windows.Forms.Button btnQtdCaracterNumerico;
        private System.Windows.Forms.RichTextBox rtxtPrincipal;
    }
}