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
    public partial class MenuAdm : Form
    {
        CadastrarKit cad;
        Excluir exc;
        Atualizar atu;
        public MenuAdm()
        {
            InitializeComponent();
            cad = new CadastrarKit();
            exc = new Excluir();        
            atu = new Atualizar();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//Cadastrar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//Atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }//Excluir

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Sair

    }//Fim da Classe
}//Fim do Projeto
