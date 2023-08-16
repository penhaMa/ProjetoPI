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
            this.senha.Location = new System.Drawing.Point(305, 188);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(283, 42);
            this.senha.TabIndex = 12;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(305, 135);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(283, 42);
            this.login.TabIndex = 9;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // entrar
            // 
            this.entrar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Location = new System.Drawing.Point(335, 274);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(149, 45);
            this.entrar.TabIndex = 7;
            this.entrar.Text = "ENTRAR";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(684, 394);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(104, 44);
            this.sair.TabIndex = 13;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrar);
            this.Name = "ADM";
            this.Text = "ADM";
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