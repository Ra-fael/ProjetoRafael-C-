using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace ProjetoRafael.Model {
    class ClientDAO {
        //Propriedades necessárias para conexão e criação/execução das consultas SQL
        private Conection Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ClientDAO() {
            Con = new Conection();  //Instancia um objeto Conexao, viabilizando o uso de seus métodos.
            Cmd = new SqlCommand(); //Instancia um objeto SqlCommand, viabilizando o uso de seus métodos.
        }
        public bool Inserir(Client cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"INSERT INTO TBCliente VALUES (@nome, @cpf, @telefone, @veiculo, @modelo, @email)";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@nome", cAux.Nome);
            Cmd.Parameters.AddWithValue("@cpf", cAux.CPF);
            Cmd.Parameters.AddWithValue("@telefone", cAux.Telefone);
            Cmd.Parameters.AddWithValue("@veiculo", cAux.Veiculo);
            Cmd.Parameters.AddWithValue("@modelo", cAux.Modelo);
            Cmd.Parameters.AddWithValue("@email", cAux.Email);


            //Cmd.Parameters.Clear();

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
       

        public List<Client> ListarClientes() {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM TBCliente";

            SqlDataReader rd = Cmd.ExecuteReader();

            List<Client> listaRetornar = new List<Client>();

            while (rd.Read()) {
                Client cli = new Client((string)rd["Nome"], (string)rd["CPF"],
                                          (string)rd["Telefone"], (string)rd["Veiculo"],
                                          (string)rd["Modelo"],(string)rd["Email"]);
                listaRetornar.Add(cli);
            }

            return listaRetornar;
        }
        public Client ConsultaCliente(string cpf) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = "SELECT * FROM TBCliente WHERE  CPF = @cpf";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@cpf", cpf);
            //Executa o comando SQL previamente definido e armazena os resultado no objeto SqlDataReader.
            SqlDataReader rd = Cmd.ExecuteReader();

            //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
            while (rd.Read()) {
                //Instancia um objeto cliente com as informações da linha retornada do banco de dados.
                Client cli = new Client((string)rd["Nome"], (string)rd["CPF"],
                                          (string)rd["Telefone"], (string)rd["Veiculo"],
                                          (string)rd["Modelo"], (string)rd["Email"]);
                rd.Close(); //"Fecha" o SqlDataReader que foi criado para receber o retorno da consulta SQL.
                return cli;
            }
            return null;
        }


        public bool AtualizarCliente(Client cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"UPDATE TBCliente SET Nome = @nome, CPF = @cpf, Telefone = @telefone, Veiculo = @veiculo, Modelo = @modelo, Email = email WHERE CPF = @cpf";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@nome", cAux.Nome);
            Cmd.Parameters.AddWithValue("@cpf", cAux.CPF);
            Cmd.Parameters.AddWithValue("@telefone", cAux.Telefone);
            Cmd.Parameters.AddWithValue("@veiculo", cAux.Veiculo);
            Cmd.Parameters.AddWithValue("@modelo", cAux.Modelo);
            Cmd.Parameters.AddWithValue("@email", cAux.Email);

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

        public bool RemoverCliente(Client cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"DELETE FROM TBCliente WHERE CPF = @cpf";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@cpf", cAux.CPF);

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

    }
}
