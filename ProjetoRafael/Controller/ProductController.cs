using ProjetoRafael.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafael.Controller {

    class ProductController {

        public List<Product> ListarProduct() {
            ProductDAO pro = new ProductDAO();
            return pro.ListarProduct();
        }
        public bool InsertProduct(Product product) {
            ProductDAO pro = new ProductDAO();
            return pro.Inserir(product);
        }

        public bool AtualizarProduct(Product product) {
            ProductDAO pro = new ProductDAO();
            return pro.AtualizarProduct(product);
        }

        public Product ConsultaProduct(string nome) {
            ProductDAO cli = new ProductDAO();
            return cli.ConsultaProduct(nome);
        }

        public bool RemoverProduct(Product product) {
            ProductDAO ser = new ProductDAO();
            return ser.RemoverProduct(product);
        }

        public Product RetornarProduct(int id) {
            ProductDAO p = new ProductDAO();
            return p.ReturnProduct(id);
        }

    }
}
