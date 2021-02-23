using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafael.Model {
    public class Product {
        public int Id { get; set; }
        public string Tipo { get; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Ano { get; set; }
        public string Qtd { get; set; }
        public string Dimensao { get; private set; }
        public string Cod { get; set; }
        public string Descricao { get; set; }
        public string CondicaoProd { get; set; }

        public Product(string tipo, string marca, string modelo, string ano, string qtd, string dimensao, string cod, string descricao, string condicao) {
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Qtd = qtd;
            Dimensao = dimensao;
            Cod = cod;
            Descricao = descricao;
            CondicaoProd = condicao;
        }

        public Product(int id, string tipo, string marca, string modelo, string ano, string qtd, string dimensao, string cod, string descricao, string condicao) {
            Id = id;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Qtd = qtd;
            Dimensao = dimensao;
            Cod = cod;
            Descricao = descricao;
            CondicaoProd = condicao;

        }

        //public Product(string cpf) {
          //  CPF = cpf;
       // }  

    }
}
