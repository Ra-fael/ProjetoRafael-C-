using System;
using ProjetoRafael.Model;
using ProjetoRafael.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael.View {
    public partial class frmConsulta_Prod : Form {
        public frmConsulta_Prod() {
            InitializeComponent();

            listProdutos.Items.Clear();

            ProductController prodContr = new ProductController();
            List<Product> proAux = prodContr.ListarProduct();

            if (proAux.Count > 0) {
                foreach (var pro in proAux) {
                    ListViewItem lv = new ListViewItem(pro.Id.ToString());
                    lv.SubItems.Add(pro.Tipo);
                    lv.SubItems.Add(pro.Marca);
                    lv.SubItems.Add(pro.Modelo);
                    lv.SubItems.Add(pro.Ano);
                    lv.SubItems.Add(pro.Qtd);
                    lv.SubItems.Add(pro.Dimensao);
                    lv.SubItems.Add(pro.Cod);
                    lv.SubItems.Add(pro.Descricao);
                    lv.SubItems.Add(pro.CondicaoProd);
                    listProdutos.Items.Add(lv);
                }

            }
        }
    }
}
