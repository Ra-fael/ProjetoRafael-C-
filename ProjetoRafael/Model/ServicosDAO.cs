using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace ProjetoRafael.Model {
    class ServicosDAO {
        //Propriedades necessárias para conexão e criação/execução das consultas SQL
        private Conection Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ServicosDAO() {
            Con = new Conection();    //Instancia um objeto Conexao, viabilizando o uso de seus métodos.
            Cmd = new SqlCommand(); //Instancia um objeto SqlCommand, viabilizando o uso de seus métodos.
        }
        public bool Inserir(Servicos cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"INSERT INTO TBServicos VALUES (@categoria, @servico, @valor, @descricao)";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@categoria", cAux.Categoria);
            Cmd.Parameters.AddWithValue("@servico", cAux.Servico);
            Cmd.Parameters.AddWithValue("@valor", cAux.Valor);
            Cmd.Parameters.AddWithValue("@descricao", cAux.Descricao);
            //Cmd.Parameters.Clear();

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
        

        public List<Servicos> ListarServicos() {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM TBServicos";

            SqlDataReader rd = Cmd.ExecuteReader();

            List<Servicos> listaRetornar = new List<Servicos>();

            while (rd.Read()) {
                Servicos ser = new Servicos((int)rd["Id"], (string)rd["Categoria"], (string)rd["Serviço"],
                                          (string)rd["Valor"], (string)rd["Descrição"]);
                listaRetornar.Add(ser);
            }

            return listaRetornar;
        }
        public Servicos ConsultaServicos(string Servicos) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = "SELECT * FROM TBServicos WHERE  Servicos = @servicos";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@servicos", Servicos);
            //Executa o comando SQL previamente definido e armazena os resultado no objeto SqlDataReader.
            SqlDataReader rd = Cmd.ExecuteReader();

            //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
            while (rd.Read()) {
                //Instancia um objeto cliente com as informações da linha retornada do banco de dados.
                Servicos ser = new Servicos((int)rd["Id"], (string)rd["Categoria"], (string)rd["Servicos"],
                                          (string)rd["Valor"], (string)rd["Descricao"]);
                rd.Close(); //"Fecha" o SqlDataReader que foi criado para receber o retorno da consulta SQL.
                return ser;
            }
            return null;
        }


        public bool AtualizarServicos(Servicos cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"UPDATE TBServicos SET Categoria = @categoria, Serviço = @serviço, Valor = @valor, Descrição = @descricao WHERE Id = @id";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@id", cAux.Id);
            Cmd.Parameters.AddWithValue("@categoria", cAux.Categoria);
            Cmd.Parameters.AddWithValue("@serviço", cAux.Servico);
            Cmd.Parameters.AddWithValue("@valor", cAux.Valor);
            Cmd.Parameters.AddWithValue("@descrição", cAux.Descricao);


            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

        public bool RemoverServicos(Servicos cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"DELETE FROM TBServicos WHERE Id = @id";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@id", cAux.Id);

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

    }
}
