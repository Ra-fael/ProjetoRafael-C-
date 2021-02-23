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
using System.Threading;
using System.Windows.Forms;

namespace ProjetoRafael.View {
    public partial class Login : Form {
        public Login() {

            Thread showSplash = new Thread(new ThreadStart(IniciarSplash));
            showSplash.Start();
            Thread.Sleep(3500);

            InitializeComponent();

            showSplash.Abort();

        }

        public void IniciarSplash() {
            Application.Run(new SplashScreen());
        }

        private void btnLogar_Click(object sender, EventArgs e) {

            string user = txbUsu.Text;
            string senha = txbSen.Text;

            UserController cc = new UserController();
            bool retorno = cc.ValidarLogin(user, senha);

            if (retorno) {
                principal telaPrincipal = new principal();
                this.Hide();
                telaPrincipal.ShowDialog();
            }
            else
                MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

