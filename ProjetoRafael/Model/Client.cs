using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafael.Model {
    public class Client {


        public string Nome { get; }
        public string CPF { get; set; }
        public string Telefone { get;  set; }
        public string Veiculo { get; set; }
        public string Modelo { get; set; }
        public string Email { get; set; }



        public Client(string nome, string cpf, string telefone, string veiculo, string modelo, string email) {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Veiculo = cpf;
            Modelo = modelo;
            Email = email;
        }

        public Client(string cpf) {
            CPF = cpf;
        }

    }
}
