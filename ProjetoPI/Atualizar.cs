using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoPI
{
    public partial class Atualizar : Form
    {
        DAO conec;
        public Atualizar()
        {
            InitializeComponent();
            conec = new DAO();//Conecta a DAO
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void sala_TextChanged(object sender, EventArgs e)
        {

        }

        private void unidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Batualizar_Click(object sender, EventArgs e)
        {
            conec.Atualizar(Convert.ToInt32(codigo.Text), "cadastrarKit", "codigo", codigo.Text);//Atualiza o Código
            conec.Atualizar(Convert.ToInt32(codigo.Text), "cadastrarKit", "sala", sala.Text);//Atualiza a Sala
            conec.Atualizar(Convert.ToInt32(codigo.Text), "cadastrarKit", "unidade", unidade.Text);//Atualiza a Unidade
            MessageBox.Show("Dados Atualizados com Sucesso!");//Mensagem para o úsuario 
        }//Atualizar

    }//Fim da Classe
}//Fim do Projeto
