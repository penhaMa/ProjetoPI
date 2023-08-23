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
        public string[] sala;//Vetor que guarda a sala
        public string[] unidade;//Vetor que guarda a unidade
        public int[] cod;//Vetor que guarda a unidade

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

        public string Cadastrar(string login, string senha, string nome, string unidade, string nomeTabela)
        {
            string cadastrar = $"Insert into {nomeTabela}(login, senha, nome, unidade) values('{login}','{senha}','{nome}','{unidade}')";
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

        public string CadastrarKit(int codigo, string sala, string unidade, string nomeTabela)
        {
            string cadastrar = $"Insert into {nomeTabela}(codigo, sala, unidade) values('{codigo}','{sala}','{unidade}')";
            MySqlCommand sql = new MySqlCommand(cadastrar, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }//Fim do método Cadastrar

        //Método de Busca
        public void Busca(int codigo, string nomeTabela)
        {
            string query = $"Select * from {nomeTabela} where codigo = '{codigo}'";

            //Instanciar
            this.sala = new string[100];
            this.unidade = new string[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                sala[i] = leitura["sala"] + "";//Mostra o dado que deseja pegar
                unidade[i] = leitura["unidade"] + "";//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicaxão
            leitura.Close();
        }//Fim do método

        public string Atualizar(int codigo, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//fim do método Atualizar

        public string Excluir(int codigo, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluido";
            return resultado;
        }//Fim do método Excluir

        public void Devolver(int codigo, string nomeTabela)
        {
            string acessar = $"select * from {nomeTabela} where codigo = '{codigo}'";

            //Instanciar
            this.cod = new int[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(acessar, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cod[i] = Convert.ToInt32(leitura["cod"]);//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicasão
            leitura.Close();
        }//Fim do método Devolver

        public void Reservar(int codigo, string nomeTabela)
        {
            string acessar = $"select * from {nomeTabela} where codigo = '{codigo}'";

            //Instanciar
            this.cod = new int[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(acessar, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cod[i] = Convert.ToInt32(leitura["cod"]);//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicasão
            leitura.Close();
        }//Fim do método Reservar

        public void Retirar(int codigo, string nomeTabela)
        {
            string acessar = $"select * from {nomeTabela} where codigo = '{codigo}'";

            //Instanciar
            this.cod = new int[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(acessar, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cod[i] = Convert.ToInt32(leitura["cod"]);//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicasão
            leitura.Close();
        }//Fim do método Reservar

    }//Fim da Classe
}//Fim do Projeto
