using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoPI
{
    public partial class Log : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeighEllipse
    );

        ADM co;
        DAO conec;
        Cadastrar cad;
        Menu menu;
        public Log()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            conec = new DAO();//Conecta a DAO
            cad = new Cadastrar();//Conecta a Cadastrar
            co = new ADM();
            menu = new Menu();
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }//Tela de Fundo

        private void login_TextChanged(object sender, EventArgs e)
        {

        }//Login

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }//Senha

        private void entrar_Click(object sender, EventArgs e)
        {
            conec.Acessar(login.Text, senha.Text, "entrar");
            for (int i = 0; i < conec.QuatidadeDados(); i++)
            {
                if (login.Text == conec.login[i] & senha.Text == conec.senha[i])//Verifica o login e a senha já cadastrado no banco de dados
                {
                    MessageBox.Show("Login Bem sucedido");//Se der certo mostra essa mensagem 
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou Senha Incorretos");//Se der errado mostra essa mensagem 
                }
            }//Fim do Método Login
        }//Entrar

        private void cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//Cadastrar

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Sair

        private void adm_Click(object sender, EventArgs e)
        {
            this.Hide();
            co.ShowDialog();
        }//Adm 

    }//Fim da Classe
}//Fim do Projeto
