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
    public partial class Cadastrar : Form
    {
        DAO conectar;
        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();//Conecta com a DAO 
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }//Tela de Fundo

        private void login_TextChanged(object sender, EventArgs e)
        {

        }//Login

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }//Senha

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Adiciona Dados
                string result = conectar.Cadastrar(login.Text, senha.Text, "entrar"); ;
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                //Mostra se der Erro
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch
        }//Cadastrar

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Sair

    }//Fim da Classe
}//Fim do Projeto
