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
    public partial class Retirar : Form
    {
        DAO conec;
        public Retirar()
        {
            InitializeComponent();
            conec = new DAO();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bretirar_Click(object sender, EventArgs e)
        {
            conec.Retirar(Convert.ToInt32(codigo.Text), "cadastrarKit");
            for (int i = 0; i < conec.QuatidadeDados(); i++)
            {
                if (Convert.ToInt32(codigo.Text) == Convert.ToInt32(conec.cod[i]))//Verifica o codigo Digitado
                {
                    MessageBox.Show("Retirado");//Se der certo mostra essa mensagem 
                }
                else
                {
                    MessageBox.Show("Código Incorreto");//Se der errado mostra essa mensagem 
                }
            }//Fim do Método Retirar
        }//Botão Retirar

    }//Fim da Classe
}//Fim do Projeto
