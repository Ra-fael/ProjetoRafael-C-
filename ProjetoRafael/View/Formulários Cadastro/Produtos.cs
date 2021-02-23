using System;
using ProjetoRafael;
using ProjetoRafael.View;
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
    public partial class frmCadastro_Prod : Form {
        public frmCadastro_Prod() {
            InitializeComponent();
        }

        private void btn_Cad_Click(object sender, EventArgs e) {
            string tipo = cmbProduto.SelectedItem.ToString();

            string estado;
            if (rdbNovo.Checked)
                estado = "Novo";
            else if (rdbRecon.Checked)
                estado = "Recondicionado";
            else
                estado = "Usado";

            Product product = new Product(tipo, txbMarca.Text, txbModelo.Text,txbAno.Text,
                txbQtd.Text, mtbDimensao.Text,txbCodProd.Text, rtbDescricao.Text, estado);

            ProductController pd = new ProductController();
            bool returned = pd.InsertProduct(product);

            if (returned) {
                MessageBox.Show("Produto cadastrado com sucesso!");
                //ClearFields();
            }
            else
                MessageBox.Show("Falha ao atualizar");
        }
    }
}

