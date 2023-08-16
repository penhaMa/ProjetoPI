namespace ProjetoPI
{
    partial class MenuAdm
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
            this.Excluir = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Excluir
            // 
            this.Excluir.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.Location = new System.Drawing.Point(331, 276);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(149, 45);
            this.Excluir.TabIndex = 15;
            this.Excluir.Text = "EXCLUIR";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(213, 191);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(175, 45);
            this.Cadastrar.TabIndex = 14;
            this.Cadastrar.Text = "CADASTRAR";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.Location = new System.Drawing.Point(423, 191);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(175, 45);
            this.Atualizar.TabIndex = 13;
            this.Atualizar.Text = "ATUALIZAR";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(674, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 45);
            this.button4.TabIndex = 16;
            this.button4.Text = "SAIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu Principal ADM";
            // 
            // MenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Atualizar);
            this.Name = "MenuAdm";
            this.Text = "MenuAdm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}