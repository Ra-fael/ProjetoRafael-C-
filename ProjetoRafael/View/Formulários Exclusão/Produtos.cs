using System;
using System.Collections.Generic;
using ProjetoRafael.Controller;
using ProjetoRafael.Model;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael.View {
    public partial class frmExc_Prod : Form {
        public frmExc_Prod() {
            InitializeComponent();
            Mostrar();
        }

        public void Mostrar() {
            listProdutosEx.Items.Clear();

            ProductController prodContr = new ProductController();
            List<Product> proAux = prodContr.ListarProduct();

            if (proAux.Count > 0) {
                foreach (var pro in proAux) {
                    ListViewItem lv = new ListViewItem(pro.Id.ToString());
                    lv.SubItems.Add(pro.Tipo);
                    lv.SubItems.Add(pro.Marca);
                    lv.SubItems.Add(pro.Modelo);
                    lv.SubItems.Add(pro.Ano);
                    listProdutosEx.Items.Add(lv);
                }
            }
        }

        private void btn_Exc_Click(object sender, EventArgs e) {
            string marca = txbexcluir.Text;

            ProductController cc = new ProductController();
            Product cli = cc.ConsultaProduct(marca);


            if (cli != null) {
                cc.RemoverProduct(cli);
                MessageBox.Show("Produto  removido", "Sucesso", MessageBoxButtons.OK);
                txbexcluir.Text = string.Empty;
                Mostrar();
            }
            else {
                MessageBox.Show("Produto  incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbexcluir.Text = string.Empty;
            }
        }
    }
}
