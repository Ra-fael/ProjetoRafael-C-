using System;
using System.Collections.Generic;
using ProjetoRafael;
using ProjetoRafael.View;
using ProjetoRafael.Model;
using ProjetoRafael.Controller;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael.View {
    public partial class frmEditar_Prod : Form {
        public frmEditar_Prod() {
            InitializeComponent();
            Mostrar();
            
        }

        public Product freg;
        public frmEditar_Prod(Product cli) {
            InitializeComponent();

            freg = cli;
        }

        public void Mostrar() {
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
                    listProdutos.Items.Add(lv);
                }
            }
        }

        public void PreencherCampos() {
            int idProduto = int.Parse(listProdutos.Items[listProdutos.FocusedItem.Index].SubItems[0].Text);

            ProductController prodAux = new ProductController();
            Product pro  = prodAux.RetornarProduct(idProduto);

            cmbProduto.Text = pro.Tipo;
            txbMarca.Text = pro.Marca;
            txbModelo.Text = pro.Modelo;
            txbAno.Text = pro.Ano;
            txbQtd.Text = pro.Qtd;
            mtbDimensao.Text = pro.Dimensao;
            txbCodProd.Text = pro.Cod;
            rtbDescricao.Text = pro.Descricao;

        }

        public void ClearFields() {
            cmbProduto.Text = string.Empty;
            txbMarca.Text = string.Empty;
            txbModelo.Text = string.Empty;
            txbAno.Text = string.Empty;
            txbQtd.Text = string.Empty;
            mtbDimensao.Text = string.Empty;
            txbCodProd.Text = string.Empty;
            rtbDescricao.Text = string.Empty;
            
        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e) {
            PreencherCampos();
        }

        private void btn_Edi_Click(object sender, EventArgs e) {
            int idProduto = int.Parse(listProdutos.Items[listProdutos.FocusedItem.Index].SubItems[0].Text);

            string tipo = cmbProduto.SelectedItem.ToString();

            string estado = string.Empty;
            if (rdbNovo.Checked)
                estado = "Novo";
            else if (rdbRecondi.Checked)
                estado = "Recondicionado";
            else
                estado = "Usado";

            Product product = new Product(idProduto, tipo, txbMarca.Text, txbModelo.Text, txbAno.Text,
                txbQtd.Text, mtbDimensao.Text, txbCodProd.Text, rtbDescricao.Text, estado);

            ProductController pd = new ProductController();
            bool returned = pd.AtualizarProduct(product);

            if (returned) {
                MessageBox.Show("Produto atualizado com sucesso!");
                ClearFields();
                Mostrar();
            }
            else
                MessageBox.Show("Falha ao atualizar");


        }
    }
}

