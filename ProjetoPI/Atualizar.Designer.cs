namespace ProjetoPI
{
    partial class Atualizar
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
            this.unidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Batualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // unidade
            // 
            this.unidade.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidade.Location = new System.Drawing.Point(320, 218);
            this.unidade.Name = "unidade";
            this.unidade.Size = new System.Drawing.Size(268, 42);
            this.unidade.TabIndex = 35;
            this.unidade.TextChanged += new System.EventHandler(this.unidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "Unidade";
            // 
            // sala
            // 
            this.sala.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sala.Location = new System.Drawing.Point(320, 162);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(268, 42);
            this.sala.TabIndex = 33;
            this.sala.TextChanged += new System.EventHandler(this.sala_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 35);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sala";
            // 
            // Batualizar
            // 
            this.Batualizar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batualizar.Location = new System.Drawing.Point(302, 328);
            this.Batualizar.Name = "Batualizar";
            this.Batualizar.Size = new System.Drawing.Size(199, 44);
            this.Batualizar.TabIndex = 31;
            this.Batualizar.Text = "ATUALIZAR";
            this.Batualizar.UseVisualStyleBackColor = true;
            this.Batualizar.Click += new System.EventHandler(this.Batualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código";
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(320, 108);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(268, 42);
            this.codigo.TabIndex = 30;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Batualizar);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label1);
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.Atualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Batualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo;
    }
}