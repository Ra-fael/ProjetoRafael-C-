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
    public partial class frmCadastro_Serv : Form {
        public frmCadastro_Serv() {
            InitializeComponent();

            AplicarEventos(txbValor);
            

        }

        private  void RetornarMascara(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e) {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)) {
                if (e.KeyChar == ',') {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void TirarMascara(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
           
        }

        private void AplicarEventos(TextBox txt) {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            string categoria = string.Empty;
            if (ckbReparo.Checked)
                categoria += ("Reparo");
            if (ckbManutencao.Checked)
                categoria += ("Manutencao");


            

            Servicos servicos = new Servicos(categoria, txbServ.Text, txbValor.Text, 
                rtbDesc.Text);

            ServicosController cc = new ServicosController();
            bool returned = cc.InsertServicos(servicos);

            if (returned) {
                MessageBox.Show("Serviço inserido com sucesso!");
               //ClearFields();
            }
            else
                MessageBox.Show("Falha ao inserir");
        }

        
    }
}
