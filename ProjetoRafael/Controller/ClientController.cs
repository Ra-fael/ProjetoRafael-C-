using ProjetoRafael.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafael.Controller {

    class ClientController {
        

        public List<Client> ListarClientes() {
            ClientDAO cli = new ClientDAO();
            return cli.ListarClientes();
        }
        public bool InsertClient(Client cliente) {
            ClientDAO cli = new ClientDAO();
            return cli.Inserir(cliente);
        }

        public Client ConsultaCliente(string cpf) {
            ClientDAO cli = new ClientDAO();
            return cli.ConsultaCliente(cpf);
        }

        public bool AtualizarCliente(Client cliente) {
            ClientDAO cli = new ClientDAO();
            return cli.AtualizarCliente(cliente);
        }

        public bool RemoverCliente(Client cliente) {
            ClientDAO cli = new ClientDAO();
            return cli.RemoverCliente(cliente);
        }

    }
}
