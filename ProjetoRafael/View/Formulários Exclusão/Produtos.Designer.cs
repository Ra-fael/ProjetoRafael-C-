
namespace ProjetoRafael.View {
    partial class frmExc_Prod {
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
            this.pnlProdutoEdi = new System.Windows.Forms.Panel();
            this.btn_Exc = new System.Windows.Forms.Button();
            this.listProdutosEx = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblExcluir = new System.Windows.Forms.Label();
            this.txbexcluir = new System.Windows.Forms.TextBox();
            this.pnlProdutoEdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProdutoEdi
            // 
            this.pnlProdutoEdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProdutoEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlProdutoEdi.Controls.Add(this.btn_Exc);
            this.pnlProdutoEdi.Controls.Add(this.lblExcluir);
            this.pnlProdutoEdi.Controls.Add(this.txbexcluir);
            this.pnlProdutoEdi.Controls.Add(this.listProdutosEx);
            this.pnlProdutoEdi.Location = new System.Drawing.Point(12, 12);
            this.pnlProdutoEdi.Name = "pnlProdutoEdi";
            this.pnlProdutoEdi.Size = new System.Drawing.Size(790, 538);
            this.pnlProdutoEdi.TabIndex = 2;
            // 
            // btn_Exc
            // 
            this.btn_Exc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exc.BackColor = System.Drawing.Color.White;
            this.btn_Exc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Exc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Exc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exc.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Exc.Location = new System.Drawing.Point(629, 493);
            this.btn_Exc.Name = "btn_Exc";
            this.btn_Exc.Size = new System.Drawing.Size(99, 30);
            this.btn_Exc.TabIndex = 19;
            this.btn_Exc.Text = "Excluir";
            this.btn_Exc.UseVisualStyleBackColor = false;
            this.btn_Exc.Click += new System.EventHandler(this.btn_Exc_Click);
            // 
            // listProdutosEx
            // 
            this.listProdutosEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProdutosEx.BackColor = System.Drawing.Color.Gray;
            this.listProdutosEx.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhTipo,
            this.clhMarca,
            this.clhModelo,
            this.clhAno});
            this.listProdutosEx.FullRowSelect = true;
            this.listProdutosEx.HideSelection = false;
            this.listProdutosEx.Location = new System.Drawing.Point(32, 14);
            this.listProdutosEx.Name = "listProdutosEx";
            this.listProdutosEx.Size = new System.Drawing.Size(727, 395);
            this.listProdutosEx.TabIndex = 18;
            this.listProdutosEx.UseCompatibleStateImageBehavior = false;
            this.listProdutosEx.View = System.Windows.Forms.View.Details;
            // 
            // clhId
            // 
            this.clhId.Width = 0;
            // 
            // clhTipo
            // 
            this.clhTipo.Text = "Tipo";
            this.clhTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTipo.Width = 70;
            // 
            // clhMarca
            // 
            this.clhMarca.Text = "Marca";
            this.clhMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhMarca.Width = 70;
            // 
            // clhModelo
            // 
            this.clhModelo.Text = "Modelo";
            this.clhModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhModelo.Width = 70;
            // 
            // clhAno
            // 
            this.clhAno.Text = "Ano";
            this.clhAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhAno.Width = 50;
            // 
            // lblExcluir
            // 
            this.lblExcluir.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExcluir.Location = new System.Drawing.Point(27, 384);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(347, 25);
            this.lblExcluir.TabIndex = 3;
            this.lblExcluir.Text = "Digite o nome do produto para apagar: ";
            // 
            // txbexcluir
            // 
            this.txbexcluir.Location = new System.Drawing.Point(32, 415);
            this.txbexcluir.Name = "txbexcluir";
            this.txbexcluir.Size = new System.Drawing.Size(214, 20);
            this.txbexcluir.TabIndex = 2;
            // 
            // frmExc_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 562);
            this.Controls.Add(this.pnlProdutoEdi);
            this.Name = "frmExc_Prod";
            this.Text = "Form1";
            this.pnlProdutoEdi.ResumeLayout(false);
            this.pnlProdutoEdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdutoEdi;
        private System.Windows.Forms.Button btn_Exc;
        private System.Windows.Forms.ListView listProdutosEx;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhTipo;
        private System.Windows.Forms.ColumnHeader clhMarca;
        private System.Windows.Forms.ColumnHeader clhModelo;
        private System.Windows.Forms.ColumnHeader clhAno;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.TextBox txbexcluir;
    }
}