using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class ADM : Form
    {
        MenuAdm adm;
        public ADM()
        {
            InitializeComponent();
            adm = new MenuAdm();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }//Login

        private void entrar_Click(object sender, EventArgs e)
        {
            string lo = "ADM";
            string se = "123";
            {
                if (login.Text == lo & senha.Text == se)//Verifica o login e a senha do adm
                {
                    MessageBox.Show("Login Bem sucedido");//Se der certo mostra essa mensagem 
                    this.Hide();
                    adm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou Senha Incorretos");//Se der errado mostra essa mensagem 
                }
            }//Fim do Método Login
        }//Entrar

        private void senha_TextChanged(object sender, EventArgs e)
        {
            
        }//Senha

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }//Fim da Classe
}//Fim do Projeto
