using System;
using ProjetoRafael;
using ProjetoRafael.View;
using ProjetoRafael.Controller;
using ProjetoRafael.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael {
    public partial class principal : Form {
        public principal() {
            InitializeComponent();
            Desing();
        }

        private void Desing() {
            pnlProdutosSub.Visible = false;
            pnlServicosSub.Visible = false;
            pnlUsuariosSub.Visible = false;
            pnlClientesSub.Visible = false;
            pnlRelatoriosSub.Visible = false;
        }

        private void HideSubMenu() {
            if (pnlProdutosSub.Visible == true)
                pnlProdutosSub.Visible = false;

            if (pnlServicosSub.Visible == true)
                pnlServicosSub.Visible = false;

            if (pnlUsuariosSub.Visible == true)
                pnlUsuariosSub.Visible = false;

            if (pnlClientesSub.Visible == true)
                pnlClientesSub.Visible = false;

            if (pnlRelatoriosSub.Visible == true)
                pnlRelatoriosSub.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu) {
            if (SubMenu.Visible == false) {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        #region Produtos
        //Produtos
        private void btnProdutos_Click(object sender, EventArgs e) {
            ShowSubMenu(pnlProdutosSub);
        }

        private void btnCad_Prod_Click(object sender, EventArgs e) {
            openFormBase(new frmCadastro_Prod());

            HideSubMenu();
        }

        private void btnCon_Prod_Click(object sender, EventArgs e) {
            openFormBase(new frmConsulta_Prod());

            HideSubMenu();
        }
        private void btnEdi_Prod_Click(object sender, EventArgs e) {
            openFormBase(new frmEditar_Prod());

            HideSubMenu();
        }

        private void btnExc_Prod_Click_1(object sender, EventArgs e) {
            openFormBase(new frmExc_Prod());

            HideSubMenu();
        }
        #endregion

        #region Serviços
        //Serviços
        private void btnServicos_Click(object sender, EventArgs e) {
            ShowSubMenu(pnlServicosSub);
        }

        private void btnCad_Serv_Click(object sender, EventArgs e) {
            openFormBase(new frmCadastro_Serv());


            HideSubMenu();
        }
        private void btnCon_Serv_Click(object sender, EventArgs e) {
            openFormBase(new frmConsulta_Serv());
            HideSubMenu();
        }

        private void btnEdi_Serv_Click(object sender, EventArgs e) {
            HideSubMenu();
        }

        private void btnExc_Serv_Click_1(object sender, EventArgs e) {
            HideSubMenu();
        }
        #endregion

        #region Usuários
        //Usuários 
        private void btnUsuarios_Click(object sender, EventArgs e) {
            ShowSubMenu(pnlUsuariosSub);
        }
        private void btnCad_Usua_Click_1(object sender, EventArgs e) {
            openFormBase(new frmCadastro_Usua());
            
            HideSubMenu();
        }
        private void btnCon_Usua_Click(object sender, EventArgs e) {
            openFormBase(new Usuarios());
            
            HideSubMenu();
        }
        private void btnEdi_Usua_Click(object sender, EventArgs e) {
            HideSubMenu();
        }

        private void btnExc_Usua_Click_1(object sender, EventArgs e) {
            HideSubMenu();
        }
        #endregion

        #region Clientes
        //Clientes
        private void btnClientes_Click(object sender, EventArgs e) {
            ShowSubMenu(pnlClientesSub);
        }

        private void btnCad_Clie_Click(object sender, EventArgs e) {
            openFormBase(new frmCadastro_Clie());
            
            HideSubMenu();
        }
        private void btnCon_Clie_Click(object sender, EventArgs e) {
            HideSubMenu();
        }

        private void btnEdi_Clie_Click(object sender, EventArgs e) {
            HideSubMenu();
        }
        private void btnExc_Clie_Click(object sender, EventArgs e) {
            HideSubMenu();
        }
        #endregion
        #region Relatorios
        private void btnRelatorios_Click(object sender, EventArgs e) {
            ShowSubMenu(pnlRelatoriosSub);
        }

        private void btnRel_Usua_Click(object sender, EventArgs e) {
            openFormBase(new RelatorioUsuario());
        }

        private void btnRel_Produtos_Click(object sender, EventArgs e) {
            openFormBase(new RelatorioProdutos());
        }

        #endregion

        private Form activeForm = null;
        private void openFormBase(Form baseForm) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = baseForm;
            baseForm.TopLevel = false;
            baseForm.FormBorderStyle = FormBorderStyle.None;
            baseForm.Dock = DockStyle.Fill;
            pnlBase.Controls.Add(baseForm);
            pnlBase.Tag = baseForm;
            baseForm.BringToFront();
            baseForm.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            var principal = new principal();
            this.Close();
        }

        private void pictureLogo_Click(object sender, EventArgs e) {
           
        }

       
    }
}