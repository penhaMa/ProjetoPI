﻿namespace ProjetoPI
{
    partial class Log
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.adm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.MediumBlue;
            this.entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrar.FlatAppearance.BorderSize = 0;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.entrar.ForeColor = System.Drawing.Color.Transparent;
            this.entrar.Location = new System.Drawing.Point(176, 245);
            this.entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(112, 37);
            this.entrar.TabIndex = 0;
            this.entrar.Text = "ENTRAR";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(242, 135);
            this.login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(213, 35);
            this.login.TabIndex = 3;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.MediumBlue;
            this.cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrar.FlatAppearance.BorderSize = 0;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.cadastrar.Location = new System.Drawing.Point(298, 245);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(155, 37);
            this.cadastrar.TabIndex = 4;
            this.cadastrar.Text = "CADASTRAR";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(242, 178);
            this.senha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(213, 35);
            this.senha.TabIndex = 6;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.MediumBlue;
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.sair.ForeColor = System.Drawing.Color.Transparent;
            this.sair.Location = new System.Drawing.Point(529, 364);
            this.sair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(78, 36);
            this.sair.TabIndex = 7;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // adm
            // 
            this.adm.BackColor = System.Drawing.Color.MediumBlue;
            this.adm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adm.FlatAppearance.BorderSize = 0;
            this.adm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adm.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.adm.ForeColor = System.Drawing.Color.Transparent;
            this.adm.Location = new System.Drawing.Point(11, 363);
            this.adm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(112, 37);
            this.adm.TabIndex = 8;
            this.adm.Text = "ADM";
            this.adm.UseVisualStyleBackColor = false;
            this.adm.Click += new System.EventHandler(this.adm_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(618, 411);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button adm;
    }
}

