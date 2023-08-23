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
    public partial class Excluir : Form
    {
        DAO conec;
        public Excluir()
        {
            InitializeComponent();
            conec = new DAO();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bexcluir_Click(object sender, EventArgs e)
        {
            string result = conec.Excluir(Convert.ToInt32(codigo.Text), "cadastrarKit");
            MessageBox.Show(result);
        }//Excluir

    }//Fim da Classe
}//Fim do Projeto
