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
    public partial class RelatorioProdutos : Form {
        public RelatorioProdutos() {
            InitializeComponent();
        }

        private void fmrRelatorio_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.TBProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.tBProdutosTableAdapter.Fill(this.dataSet1.TBProdutos);

            this.reportViewer1.RefreshReport();
        }
    }
}
