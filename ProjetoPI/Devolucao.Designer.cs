namespace ProjetoPI
{
    partial class Devolucao
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
            this.codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bdevolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(242, 128);
            this.codigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(239, 35);
            this.codigo.TabIndex = 37;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Código do Kit";
            // 
            // Bdevolver
            // 
            this.Bdevolver.BackColor = System.Drawing.Color.MediumBlue;
            this.Bdevolver.FlatAppearance.BorderSize = 0;
            this.Bdevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bdevolver.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdevolver.ForeColor = System.Drawing.Color.Transparent;
            this.Bdevolver.Location = new System.Drawing.Point(242, 270);
            this.Bdevolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bdevolver.Name = "Bdevolver";
            this.Bdevolver.Size = new System.Drawing.Size(127, 36);
            this.Bdevolver.TabIndex = 35;
            this.Bdevolver.Text = "DEVOLVER";
            this.Bdevolver.UseVisualStyleBackColor = false;
            this.Bdevolver.Click += new System.EventHandler(this.Bdevolver_Click);
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bdevolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Devolucao";
            this.Text = "Devolucao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bdevolver;
    }
}