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
    public partial class Devolucao : Form
    {
        DAO conec;
        public Devolucao()
        {
            InitializeComponent();
            conec = new DAO();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bdevolver_Click(object sender, EventArgs e)
        {
            conec.Devolver(Convert.ToInt32(codigo.Text), "cadastrarKit");
            for (int i = 0; i < conec.QuatidadeDados(); i++)
            {
                if (Convert.ToInt32(codigo.Text) == Convert.ToInt32(conec.cod[i]))//Verifica o codigo Digitado
                {
                    MessageBox.Show("Devolvido");//Se der certo mostra essa mensagem 
                }
                else
                {
                    MessageBox.Show("Código Incorreto");//Se der errado mostra essa mensagem 
                }
            }//Fim do Método Devolver
        }//Botão Devolver

    }//Fim da Classe
}//Fim do Projeto
