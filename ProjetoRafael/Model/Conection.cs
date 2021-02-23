using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoRafael.Model {
    class Conection {
        private SqlConnection conexao;

        public Conection() {
            //string cadeiaConexao = @"Data Source=DESKTOP-OS04KB5;Initial Catalog=LojaDoMarques;Integrated Security=True";
            string cadeiaConexao = @"Data Source=" + Environment.MachineName + ";Initial Catalog=BlackDoor;Integrated Security=true";
            conexao = new SqlConnection(cadeiaConexao);
            conexao.Open();
        }

        //Tenta fechar a conexão.
        public void Desconectar() {
            if (conexao.State == ConnectionState.Open) {
                conexao.Close();
            }
        }

        public SqlConnection RetornarConexao() {
            return conexao;
        }
    }
}
