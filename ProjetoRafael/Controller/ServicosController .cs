using ProjetoRafael.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafael.Controller {

    class ServicosController {

        public List<Servicos> ListarServicos() {
            ServicosDAO ser = new ServicosDAO();
            return ser.ListarServicos();
        }
        public bool InsertServicos(Servicos servicos) {
            ServicosDAO ser = new ServicosDAO();
            return ser.Inserir(servicos);
        }

        public bool AtualizarServicos(Servicos servicos) {
            ServicosDAO ser = new ServicosDAO();
            return ser.AtualizarServicos(servicos);
        }

        public bool RemoverServicos(Servicos servicos) {
            ServicosDAO ser = new ServicosDAO();
            return ser.RemoverServicos(servicos);
        }

    }
}
