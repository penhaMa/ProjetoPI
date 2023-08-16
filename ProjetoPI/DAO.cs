using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoPI
{
    class DAO
    {
        public MySqlConnection conexao;//Conexao com o banco de dados
        public string[] login;//Vetor que guarda o login
        public string[] senha;//Vetor que guarda o senha
        public int i;//Variavel do Vetor
        public int contador;//Contador do i

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;database=projetoPI;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão com o banco de dados
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do construtor
        }//Fim da DAO

        public int QuatidadeDados()
        {
            return contador;
        }//Fim do método Quantidade de Dados

        public string Cadastrar(string login, string senha, string nomeTabela)
        {
            string cadastrar = $"Insert into {nomeTabela}(login, senha) values('{login}','{senha}')";
            MySqlCommand sql = new MySqlCommand(cadastrar, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }//Fim do método Cadastrar

        public void Acessar(string verificaLogin, string verificaSenha, string nomeTabela)
        {
            string acessar = $"select * from {nomeTabela} where login = '{verificaLogin}' and senha = '{verificaSenha}'";
            //Acessa os dados do banco de dados

            //Instanciar
            this.login = new string[100];
            this.senha = new string[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(acessar, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();


            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                login[i] = leitura["login"] + "";//Mostra o dado que deseja pegar
                senha[i] = leitura["senha"] + "";//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicasão
            leitura.Close();
        }//Fim do Public DAO

    }//Fim da Classe
}//Fim do Projeto
