using ProjetoRafael.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafael.Controller {

    class UserController {

        public List<User> ListarUser() {
            UserDAO use = new UserDAO();
            return use.ListarUser();
        }
        public bool InsertUser(User user) {
            UserDAO use = new UserDAO();
            return use.Inserir(user);
        }

        public bool AtualizarUser(User user) {
            UserDAO use = new UserDAO();
            return use.AtualizarUser(user);
        }

        public bool RemoverUser(User user) {
            UserDAO use = new UserDAO();
            return use.RemoverUser(user);
        }

        public bool ValidarLogin(string user, string senha) {

            UserDAO cli = new UserDAO();
            return cli.VerificarLogin(user, senha);
        }

    }
}
