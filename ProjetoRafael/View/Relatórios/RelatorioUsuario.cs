using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael.View {
    public partial class RelatorioUsuario : Form {
        public RelatorioUsuario() {
            InitializeComponent();
        }

        private void RelatorioUsuario_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dataSetUsuario.TBUsuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.tBUsuariosTableAdapter.Fill(this.dataSetUsuario.TBUsuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
