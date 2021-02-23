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
    public partial class frmCadastro_Clie : Form {
        public frmCadastro_Clie() {
            InitializeComponent();
        }

        public void ClearFields() {
            txbNome.Text = string.Empty;
            mskCpf.Text = string.Empty;
            txbTelefone.Text = string.Empty;
            cmbVeiculo.Text = string.Empty;
            txbModelo.Text = string.Empty;
            txbEmail.Text = string.Empty;
        }

        private void btn_Cad_Click(object sender, EventArgs e) {
            string veiculo = cmbVeiculo.SelectedItem.ToString();
            
            Client client = new Client(txbNome.Text, mskCpf.Text, txbTelefone.Text,
               veiculo, txbModelo.Text, txbEmail.Text);

            ClientController cc = new ClientController();
            bool returned = cc.InsertClient(client);

            if (returned) {
                MessageBox.Show("Cliente inserido com sucesso!");
                ClearFields();
            }
            else
                MessageBox.Show("Falha ao inserir");
        }
    }
}
