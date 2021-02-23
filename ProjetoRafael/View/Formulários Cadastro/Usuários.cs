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
    public partial class frmCadastro_Usua : Form {
        public frmCadastro_Usua() {
            InitializeComponent();
        }

        private void btnCad_Usu_Click(object sender, EventArgs e) {
            string perfil = cmbPerfil.SelectedItem.ToString();

            User user = new User(txbNome.Text, txbSenha.Text, perfil);

            UserController uc = new UserController();
            bool returned = uc.InsertUser(user);

            if (returned) {
                MessageBox.Show("Usuario inserido com sucesso!");
                //ClearFields();
            }
            else
                MessageBox.Show("Falha ao inserir");
        }
    }
}
