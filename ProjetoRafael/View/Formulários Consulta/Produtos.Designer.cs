
namespace ProjetoRafael.View {
    partial class frmConsulta_Prod {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listProdutos = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDimensao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listProdutos
            // 
            this.listProdutos.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listProdutos.BackColor = System.Drawing.Color.Gray;
            this.listProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhTipo,
            this.clhMarca,
            this.clhModelo,
            this.clhAno,
            this.clhQtd,
            this.clhDimensao,
            this.clhCod,
            this.clhDescricao,
            this.clhEstado});
            this.listProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProdutos.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.listProdutos.ForeColor = System.Drawing.Color.White;
            this.listProdutos.FullRowSelect = true;
            this.listProdutos.HideSelection = false;
            this.listProdutos.Location = new System.Drawing.Point(0, 0);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(684, 461);
            this.listProdutos.TabIndex = 1;
            this.listProdutos.UseCompatibleStateImageBehavior = false;
            this.listProdutos.View = System.Windows.Forms.View.Details;
            // 
            // clhId
            // 
            this.clhId.Text = "ID";
            this.clhId.Width = 30;
            // 
            // clhTipo
            // 
            this.clhTipo.Text = "Tipo";
            this.clhTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTipo.Width = 100;
            // 
            // clhMarca
            // 
            this.clhMarca.Text = "Marca";
            this.clhMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhMarca.Width = 95;
            // 
            // clhAno
            // 
            this.clhAno.Text = "Ano";
            this.clhAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhAno.Width = 55;
            // 
            // clhQtd
            // 
            this.clhQtd.DisplayIndex = 4;
            this.clhQtd.Text = "Qtd.";
            this.clhQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhQtd.Width = 45;
            // 
            // clhDimensao
            // 
            this.clhDimensao.DisplayIndex = 5;
            this.clhDimensao.Text = "Dimensão";
            this.clhDimensao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhDimensao.Width = 85;
            // 
            // clhCod
            // 
            this.clhCod.DisplayIndex = 6;
            this.clhCod.Text = "Código";
            this.clhCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhCod.Width = 70;
            // 
            // clhDescricao
            // 
            this.clhDescricao.Text = "Descrição";
            this.clhDescricao.Width = 80;
            // 
            // clhEstado
            // 
            this.clhEstado.Text = "Condição Prodruto";
            this.clhEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhEstado.Width = 150;
            // 
            // clhModelo
            // 
            this.clhModelo.Text = "Modelo";
            this.clhModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhModelo.Width = 70;
            // 
            // frmConsulta_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.listProdutos);
            this.Name = "frmConsulta_Prod";
            this.Text = "Consulta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listProdutos;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhTipo;
        private System.Windows.Forms.ColumnHeader clhMarca;
        private System.Windows.Forms.ColumnHeader clhAno;
        private System.Windows.Forms.ColumnHeader clhQtd;
        private System.Windows.Forms.ColumnHeader clhDimensao;
        private System.Windows.Forms.ColumnHeader clhCod;
        private System.Windows.Forms.ColumnHeader clhDescricao;
        private System.Windows.Forms.ColumnHeader clhEstado;
        private System.Windows.Forms.ColumnHeader clhModelo;
    }
}