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
            this.codigo.Location = new System.Drawing.Point(323, 158);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(317, 42);
            this.codigo.TabIndex = 37;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 35);
            this.label3.TabIndex = 36;
            this.label3.Text = "Código do Kit";
            // 
            // Bdevolver
            // 
            this.Bdevolver.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdevolver.Location = new System.Drawing.Point(323, 332);
            this.Bdevolver.Name = "Bdevolver";
            this.Bdevolver.Size = new System.Drawing.Size(161, 44);
            this.Bdevolver.TabIndex = 35;
            this.Bdevolver.Text = "DEVOLVER";
            this.Bdevolver.UseVisualStyleBackColor = true;
            this.Bdevolver.Click += new System.EventHandler(this.Bdevolver_Click);
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bdevolver);
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