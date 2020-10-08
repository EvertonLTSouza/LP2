namespace ATIVIDADE6
{
    partial class frmExercicio3
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
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnReverter = new System.Windows.Forms.Button();
            this.btnRemove1De2Replace = new System.Windows.Forms.Button();
            this.btnRemove1De2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(44, 100);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 4;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(44, 35);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(129, 100);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(199, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(129, 35);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(199, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // btnReverter
            // 
            this.btnReverter.Location = new System.Drawing.Point(47, 270);
            this.btnReverter.Name = "btnReverter";
            this.btnReverter.Size = new System.Drawing.Size(281, 23);
            this.btnReverter.TabIndex = 4;
            this.btnReverter.Text = "Reverter";
            this.btnReverter.UseVisualStyleBackColor = true;
            this.btnReverter.Click += new System.EventHandler(this.btnReverter_Click);
            // 
            // btnRemove1De2Replace
            // 
            this.btnRemove1De2Replace.Location = new System.Drawing.Point(47, 218);
            this.btnRemove1De2Replace.Name = "btnRemove1De2Replace";
            this.btnRemove1De2Replace.Size = new System.Drawing.Size(281, 23);
            this.btnRemove1De2Replace.TabIndex = 3;
            this.btnRemove1De2Replace.Text = "Remove 1 de 2 Replace";
            this.btnRemove1De2Replace.UseVisualStyleBackColor = true;
            this.btnRemove1De2Replace.Click += new System.EventHandler(this.btnRemove1De2Replace_Click);
            // 
            // btnRemove1De2
            // 
            this.btnRemove1De2.Location = new System.Drawing.Point(47, 169);
            this.btnRemove1De2.Name = "btnRemove1De2";
            this.btnRemove1De2.Size = new System.Drawing.Size(281, 23);
            this.btnRemove1De2.TabIndex = 2;
            this.btnRemove1De2.Text = "Remove 1 de 2";
            this.btnRemove1De2.UseVisualStyleBackColor = true;
            this.btnRemove1De2.Click += new System.EventHandler(this.btnRemove1De2_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 331);
            this.Controls.Add(this.btnReverter);
            this.Controls.Add(this.btnRemove1De2Replace);
            this.Controls.Add(this.btnRemove1De2);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.Load += new System.EventHandler(this.frmExercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnReverter;
        private System.Windows.Forms.Button btnRemove1De2Replace;
        private System.Windows.Forms.Button btnRemove1De2;
    }
}