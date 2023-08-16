namespace ProjetoPI
{
    partial class Menu
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
            this.Devolucao = new System.Windows.Forms.Button();
            this.Reservar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.Retirar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Devolucao
            // 
            this.Devolucao.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devolucao.Location = new System.Drawing.Point(328, 214);
            this.Devolucao.Name = "Devolucao";
            this.Devolucao.Size = new System.Drawing.Size(180, 45);
            this.Devolucao.TabIndex = 9;
            this.Devolucao.Text = "DEVOLUÇÃO";
            this.Devolucao.UseVisualStyleBackColor = true;
            this.Devolucao.Click += new System.EventHandler(this.Devolucao_Click);
            // 
            // Reservar
            // 
            this.Reservar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservar.Location = new System.Drawing.Point(337, 280);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(160, 45);
            this.Reservar.TabIndex = 10;
            this.Reservar.Text = "RESERVAR";
            this.Reservar.UseVisualStyleBackColor = true;
            this.Reservar.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(674, 393);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(114, 45);
            this.Sair.TabIndex = 11;
            this.Sair.Text = "SAIR";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Retirar
            // 
            this.Retirar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retirar.Location = new System.Drawing.Point(316, 146);
            this.Retirar.Name = "Retirar";
            this.Retirar.Size = new System.Drawing.Size(208, 45);
            this.Retirar.TabIndex = 11;
            this.Retirar.Text = "RETIRAR O KIT";
            this.Retirar.UseVisualStyleBackColor = true;
            this.Retirar.Click += new System.EventHandler(this.Retirar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu Principal";
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(343, 347);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(149, 45);
            this.Buscar.TabIndex = 15;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Retirar);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Reservar);
            this.Controls.Add(this.Devolucao);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Devolucao;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Retirar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
    }
}