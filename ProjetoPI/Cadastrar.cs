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
                string result = conectar.Cadastrar(login.Text, senha.Text, nome.Text, unidade.Text, "entrar"); ;
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

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void unidade_TextChanged(object sender, EventArgs e)
        {

        }//Unidade

    }//Fim da Classe
}//Fim do Projeto
