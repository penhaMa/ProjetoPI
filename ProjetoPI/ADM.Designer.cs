namespace ProjetoPI
{
    partial class ADM
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
            this.senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entrar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(229, 153);
            this.senha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(213, 35);
            this.senha.TabIndex = 12;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(229, 110);
            this.login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(213, 35);
            this.login.TabIndex = 9;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.MediumBlue;
            this.entrar.FlatAppearance.BorderSize = 0;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.entrar.ForeColor = System.Drawing.Color.Transparent;
            this.entrar.Location = new System.Drawing.Point(251, 223);
            this.entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(112, 37);
            this.entrar.TabIndex = 7;
            this.entrar.Text = "ENTRAR";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.MediumBlue;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.sair.ForeColor = System.Drawing.Color.Transparent;
            this.sair.Location = new System.Drawing.Point(513, 320);
            this.sair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(78, 36);
            this.sair.TabIndex = 13;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADM";
            this.Load += new System.EventHandler(this.ADM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button sair;
    }
}