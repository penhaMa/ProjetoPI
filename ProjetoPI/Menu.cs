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
    public partial class Menu : Form
    {
        Retirar ret;
        Devolucao dev;
        Reservar res;
        Buscar bu;
        public Menu()
        {
            InitializeComponent();
            bu = new Buscar();
            ret = new Retirar();
            res = new Reservar();
            dev = new Devolucao();
        }

        private void Retirar_Click(object sender, EventArgs e)
        {
            ret.ShowDialog();
        }// Retirar

        private void Devolucao_Click(object sender, EventArgs e)
        {
            dev.ShowDialog();
        }//Devolução

        private void Reservar_Click(object sender, EventArgs e)
        {
            res.ShowDialog();
        }//Reservar

        private void Buscar_Click(object sender, EventArgs e)
        {
            bu.ShowDialog();
        }//Buscar

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Sair

    }//Fim da Classe
}//Fim do Projeto
