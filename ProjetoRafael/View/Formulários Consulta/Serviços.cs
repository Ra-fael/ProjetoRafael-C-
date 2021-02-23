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

namespace ProjetoRafael.View {
    public partial class frmConsulta_Serv : Form {
        public frmConsulta_Serv() {
            InitializeComponent();

            listServicos.Items.Clear();

            ServicosController serContr = new ServicosController();
            List<Servicos> serAux = serContr.ListarServicos();

            if (serAux.Count > 0) {
                foreach (var ser in serAux) {
                    ListViewItem lv = new ListViewItem(ser.Id.ToString());
                    lv.SubItems.Add(ser.Categoria);
                    lv.SubItems.Add(ser.Servico);
                    lv.SubItems.Add(ser.Valor);
                    lv.SubItems.Add(ser.Descricao);
                    listServicos.Items.Add(lv);
                }

            }

        }

        private void txbConsulta_Click(object sender, EventArgs e) {
            txbConsulta.Text = string.Empty;
        }

        private void btnCad_Busca_Click(object sender, EventArgs e) {
            
        }
    }
}