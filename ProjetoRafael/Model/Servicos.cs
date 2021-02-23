using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael.Model {
    public class Servicos {
        public int Id { get; set; }
        public string Categoria { get; }
        public string Servico { get; private set; }
        public string Valor { get; private set; }
        public string Descricao { get; set; }
        

        public Servicos(string categoria, string servico, string valor, string descricao) {
            Categoria = categoria;
            Servico = servico;
            Valor = valor;
            Descricao = descricao;
        }

        public Servicos(int id, string categoria, string servico, string valor, string descricao) {
            Id = id;
            Categoria = categoria;
            Servico = servico;
            Valor = valor;
            Descricao = descricao;

        }

        
    }
}
