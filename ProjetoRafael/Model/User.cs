using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafael.Model {
    public class User {
        public int Id { get; set; }
        public string Nome { get; }
        public string Senha { get; private set; }
        public string Perfil { get; private set; } 




        public User(string nome, string senha, string perfil) {
            Nome = nome;
            Senha = senha;
            Perfil = perfil;
        }

        public User(int id, string nome, string senha, string perfil) {
            Id = id;
            Nome = nome;
            Senha = senha;
            Perfil = perfil;
        }


        public override string ToString() {
            string ast = string.Empty;
            for (int i = 0; i < Senha.Length - 1; i++) {
                ast += "*";
            }
            return "Nome: " + Nome +    
                   "\nSenha: " + Senha[0] + ast;
        }

    }
}
