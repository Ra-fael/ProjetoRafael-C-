using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace ProjetoRafael.Model {
    class ProductDAO {
        //Propriedades necessárias para conexão e criação/execução das consultas SQL
        private Conection Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ProductDAO() {
            Con = new Conection();    //Instancia um objeto Conexao, viabilizando o uso de seus métodos.
            Cmd = new SqlCommand(); //Instancia um objeto SqlCommand, viabilizando o uso de seus métodos.
        }
        public bool Inserir(Product cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"INSERT INTO TBProdutos VALUES (@tipo, @marca, @modelo, @ano, @qtd, @dimensao, @cod, @descricao, @condicaoprod)";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@tipo", cAux.Tipo);
            Cmd.Parameters.AddWithValue("@marca", cAux.Marca);
            Cmd.Parameters.AddWithValue("@modelo", cAux.Modelo);
            Cmd.Parameters.AddWithValue("@ano", cAux.Ano);
            Cmd.Parameters.AddWithValue("@qtd", cAux.Qtd);
            Cmd.Parameters.AddWithValue("@dimensao", cAux.Dimensao);
            Cmd.Parameters.AddWithValue("@cod", cAux.Cod);
            Cmd.Parameters.AddWithValue("@descricao", cAux.Descricao);
            Cmd.Parameters.AddWithValue("@condicaoprod", cAux.CondicaoProd);
            

            //Cmd.Parameters.Clear();

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
        

        public List<Product> ListarProduct() {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM TBProdutos";

            SqlDataReader rd = Cmd.ExecuteReader();

            List<Product> listaRetornar = new List<Product>();

            while (rd.Read()) {
                Product cli = new Product((int)rd["Id"], (string)rd["Tipo"], (string)rd["Marca"],
                                          (string)rd["Modelo"], (string)rd["Ano"],
                                          (string)rd["Qtd"], (string)rd["Dimensao"],
                                          (string)rd["Cod"], (string)rd["Descricao"],
                                          (string)rd["CondicaoProd"]);
                listaRetornar.Add(cli);
            }

            return listaRetornar;
        }
        public Product ConsultaProduct(string Marca) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = "SELECT * FROM TBProdutos WHERE  Marca = @marca";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@marca", Marca);
            //Executa o comando SQL previamente definido e armazena os resultado no objeto SqlDataReader.
            SqlDataReader rd = Cmd.ExecuteReader();

            //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
            while (rd.Read()) {
                //Instancia um objeto cliente com as informações da linha retornada do banco de dados.
                Product cli = new Product((int)rd["Id"], (string)rd["Tipo"], (string)rd["Marca"],
                                          (string)rd["Modelo"], (string)rd["Ano"],
                                          (string)rd["Qtd"], (string)rd["Dimensao"],
                                          (string)rd["Cod"], (string)rd["Descricao"],
                                          (string)rd["CondicaoProd"]);
                rd.Close(); //"Fecha" o SqlDataReader que foi criado para receber o retorno da consulta SQL.
                return cli;
            }
            return null;
        }


        public bool AtualizarProduct(Product cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"UPDATE TBProdutos SET Tipo = @tipo, Marca = @marca, Modelo = @modelo, Ano = @ano, Qtd = @qtd, Dimensao = @dimensao, Cod = @cod, Descricao = @descricao, CondicaoProd = @condicaoprod WHERE Id = @id";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@id", cAux.Id);
            Cmd.Parameters.AddWithValue("@tipo", cAux.Tipo);
            Cmd.Parameters.AddWithValue("@marca", cAux.Marca);
            Cmd.Parameters.AddWithValue("@modelo", cAux.Modelo);
            Cmd.Parameters.AddWithValue("@ano", cAux.Ano);
            Cmd.Parameters.AddWithValue("@qtd", cAux.Qtd);
            Cmd.Parameters.AddWithValue("@dimensao", cAux.Dimensao);
            Cmd.Parameters.AddWithValue("@cod", cAux.Cod);
            Cmd.Parameters.AddWithValue("@descricao", cAux.Descricao);
            Cmd.Parameters.AddWithValue("@condicaoprod", cAux.CondicaoProd);
            

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

        public bool RemoverProduct(Product cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"DELETE FROM TBProdutos WHERE Marca = @marca";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@marca", cAux.Marca);

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

        public Product ReturnProduct(int Id) {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM TBProdutos WHERE Id = @id";
            Cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader rd = Cmd.ExecuteReader();

            while (rd.Read()) {
                Product pro = new Product((int)rd["Id"], (string)rd["Tipo"], (string)rd["Marca"],
                                          (string)rd["Modelo"], (string)rd["Ano"],
                                          (string)rd["Qtd"], (string)rd["Dimensao"],
                                          (string)rd["Cod"], (string)rd["Descricao"],
                                          (string)rd["CondicaoProd"]);
                rd.Close();
                return pro;
            }
            return null;
        }

    }
}
