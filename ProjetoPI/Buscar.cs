using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class Buscar : Form
    {
        DAO conec;
        public Buscar()
        {
            InitializeComponent();
            conec = new DAO();
            ConfigurarDataGrid();//Configura o DataGrid
            NomeColunas();//Nomear os títulos das colunas  
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Sala";//Adiciona um nome a coluna 0
            dataGridView1.Columns[1].Name = "Unidade";//Adiciona um nome a coluna 1

        }//Fim do método consultar

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Deletar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Redimensionar Linhas

            dataGridView1.ColumnCount = 2;//Número de Colunas
        }

        public void AdicionarDados()
        {
            conec.Busca(Convert.ToInt32(codigo.Text), "cadastrarKit");
            for (int i = 0; i < conec.QuatidadeDados(); i++)
            {
                dataGridView1.Rows.Add(conec.sala[i], conec.unidade[i]);
            }//Adicionando dados no dataGridView1
        }//Fim do método

        private void Buscar_Load(object sender, EventArgs e)
        {

        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            AdicionarDados();
        }
    }//Fim da Classe
}//Fim do Projeto
