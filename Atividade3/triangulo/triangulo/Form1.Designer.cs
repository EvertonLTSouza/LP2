namespace triangulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLadoA = new System.Windows.Forms.TextBox();
            this.TxtLadoB = new System.Windows.Forms.TextBox();
            this.TxtLadoC = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lado C";
            // 
            // TxtLadoA
            // 
            this.TxtLadoA.Location = new System.Drawing.Point(97, 23);
            this.TxtLadoA.Name = "TxtLadoA";
            this.TxtLadoA.Size = new System.Drawing.Size(123, 20);
            this.TxtLadoA.TabIndex = 1;
            // 
            // TxtLadoB
            // 
            this.TxtLadoB.Location = new System.Drawing.Point(97, 84);
            this.TxtLadoB.Name = "TxtLadoB";
            this.TxtLadoB.Size = new System.Drawing.Size(123, 20);
            this.TxtLadoB.TabIndex = 1;
            // 
            // TxtLadoC
            // 
            this.TxtLadoC.Location = new System.Drawing.Point(97, 153);
            this.TxtLadoC.Name = "TxtLadoC";
            this.TxtLadoC.Size = new System.Drawing.Size(123, 20);
            this.TxtLadoC.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(78, 235);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 306);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.TxtLadoC);
            this.Controls.Add(this.TxtLadoB);
            this.Controls.Add(this.TxtLadoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLadoA;
        private System.Windows.Forms.TextBox TxtLadoB;
        private System.Windows.Forms.TextBox TxtLadoC;
        private System.Windows.Forms.Button btnExecutar;
    }
}

