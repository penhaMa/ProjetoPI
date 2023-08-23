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
    public partial class CadastrarKit : Form
    {
        DAO conec;
        public CadastrarKit()
        {
            InitializeComponent();
            conec = new DAO();
        }

        private void CadastrarKit_Load(object sender, EventArgs e)
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

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Adiciona Dados
                string result = conec.CadastrarKit(Convert.ToInt32(codigo.Text), sala.Text, unidade.Text, "cadastrarKit"); ;
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                //Mostra se der Erro
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch
        }

    }//Fim da Classe    
}//Fim do Projeto
