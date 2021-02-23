using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace ProjetoRafael.Model {
    class UserDAO {
        //Propriedades necessárias para conexão e criação/execução das consultas SQL
        private Conection Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public UserDAO() {
            Con = new Conection();  //Instancia um objeto Conexao, viabilizando o uso de seus métodos.
            Cmd = new SqlCommand(); //Instancia um objeto SqlCommand, viabilizando o uso de seus métodos.
        }
        public bool Inserir(User cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"INSERT INTO TBUsuarios VALUES (@nome, @senha, @perfil)";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@nome", cAux.Nome);
            Cmd.Parameters.AddWithValue("@senha", cAux.Senha);
            Cmd.Parameters.AddWithValue("@perfil", cAux.Perfil);
          

            //Cmd.Parameters.Clear();

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
        public bool VerificarLogin(string nome, string senha) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = "SELECT * FROM TBUsuarios WHERE  Nome = @nome and Senha = @senha";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@nome", nome);
            Cmd.Parameters.AddWithValue("@senha", senha);

            //Executa o comando SQL previamente definido e armazena os resultado no objeto SqlDataReader.
            SqlDataReader rd = Cmd.ExecuteReader();

            //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
            while (rd.Read()) {
                if (rd != null)
                    return true;
            }
            return false;
        }

        public List<User> ListarUser() {
            Cmd.Connection = Con.RetornarConexao();
            Cmd.CommandText = "SELECT * FROM TBUsuarios";

            SqlDataReader rd = Cmd.ExecuteReader();

            List<User> listaRetornar = new List<User>();

            while (rd.Read()) {
                User cli = new User((int)rd["Id"], (string)rd["Nome"], (string)rd["Senha"],
                                          (string)rd["Perfil"]);
                                          
                listaRetornar.Add(cli);
            }

            return listaRetornar;
        }
        public User ConsultaUsuario(string nome) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = "SELECT * FROM TBUsuario WHERE  Nome = @nome";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@nome", nome);
            //Executa o comando SQL previamente definido e armazena os resultado no objeto SqlDataReader.
            SqlDataReader rd = Cmd.ExecuteReader();

            //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
            while (rd.Read()) {
                //Instancia um objeto cliente com as informações da linha retornada do banco de dados.
                User use = new User((int)rd["Id"], (string)rd["Nome"], (string)rd["Senha"],
                                          (string)rd["Perfil"]);
                rd.Close(); //"Fecha" o SqlDataReader que foi criado para receber o retorno da consulta SQL.
                return use;
            }
            return null;
        }


        public bool AtualizarUser(User uAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"UPDATE TBUsuarios SET Nome = @nome, Senha = @senha, Perfil = @perfil WHERE Id = @id";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@id", uAux.Id);
            Cmd.Parameters.AddWithValue("@nome", uAux.Nome);
            Cmd.Parameters.AddWithValue("@senha", uAux.Senha);
            Cmd.Parameters.AddWithValue("@perfil", uAux.Perfil);

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

        public bool RemoverUser(User cAux) {
            Cmd.Connection = Con.RetornarConexao(); //Estabelece a conexão com o banco de dados.
            //Cria o comando SQL que será executado no banco.
            Cmd.CommandText = @"DELETE FROM TBCliente WHERE Id = @id";
            //Associa os valores contidos no objeto Cliente cAux aos parâmetros contidos no comando SQL.
            Cmd.Parameters.AddWithValue("@id", cAux.Id);

            //Executa a consulta SQL e retorna o número de linhas que foram afetadas no banco de dados.
            if (Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

    }
}
