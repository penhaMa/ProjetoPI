namespace ProjetoPI
{
    partial class Cadastrar
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
            this.sair = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(684, 394);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(104, 44);
            this.sair.TabIndex = 14;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(326, 136);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(268, 42);
            this.senha.TabIndex = 13;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Senha";
            // 
            // bCadastrar
            // 
            this.bCadastrar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCadastrar.Location = new System.Drawing.Point(303, 325);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(199, 44);
            this.bCadastrar.TabIndex = 11;
            this.bCadastrar.Text = "CADASTRAR";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(326, 84);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(268, 42);
            this.login.TabIndex = 10;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // unidade
            // 
            this.unidade.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidade.Location = new System.Drawing.Point(326, 242);
            this.unidade.Name = "unidade";
            this.unidade.Size = new System.Drawing.Size(268, 42);
            this.unidade.TabIndex = 18;
            this.unidade.TextChanged += new System.EventHandler(this.unidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unidade";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(326, 190);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(268, 42);
            this.nome.TabIndex = 16;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label4;
    }
}