﻿namespace ProjetoPI
{
    partial class Retirar
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
            this.Bretirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(314, 158);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(317, 42);
            this.codigo.TabIndex = 43;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 35);
            this.label3.TabIndex = 42;
            this.label3.Text = "Código do Kit";
            // 
            // Bretirar
            // 
            this.Bretirar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bretirar.Location = new System.Drawing.Point(314, 332);
            this.Bretirar.Name = "Bretirar";
            this.Bretirar.Size = new System.Drawing.Size(161, 44);
            this.Bretirar.TabIndex = 41;
            this.Bretirar.Text = "RETIRAR";
            this.Bretirar.UseVisualStyleBackColor = true;
            this.Bretirar.Click += new System.EventHandler(this.Bretirar_Click);
            // 
            // Retirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bretirar);
            this.Name = "Retirar";
            this.Text = "Retirar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bretirar;
    }
}