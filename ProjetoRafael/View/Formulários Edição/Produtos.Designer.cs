
namespace ProjetoRafael.View {
    partial class frmEditar_Prod {
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Edi = new System.Windows.Forms.Button();
            this.pnlProdutoEdi = new System.Windows.Forms.Panel();
            this.gpCond = new System.Windows.Forms.GroupBox();
            this.rdbUsado = new System.Windows.Forms.RadioButton();
            this.rdbRecondi = new System.Windows.Forms.RadioButton();
            this.rdbNovo = new System.Windows.Forms.RadioButton();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txbCodProd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txbQtd = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.mtbDimensao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.pnlProdutoEdi.SuspendLayout();
            this.gpCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarca.Location = new System.Drawing.Point(230, 8);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(65, 25);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // listProdutos
            // 
            this.listProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listProdutos.BackColor = System.Drawing.Color.Gray;
            this.listProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhTipo,
            this.clhMarca,
            this.clhModelo,
            this.clhAno});
            this.listProdutos.FullRowSelect = true;
            this.listProdutos.HideSelection = false;
            this.listProdutos.Location = new System.Drawing.Point(557, 14);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(202, 352);
            this.listProdutos.TabIndex = 18;
            this.listProdutos.UseCompatibleStateImageBehavior = false;
            this.listProdutos.View = System.Windows.Forms.View.Details;
            this.listProdutos.SelectedIndexChanged += new System.EventHandler(this.listProdutos_SelectedIndexChanged);
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
            // btn_Edi
            // 
            this.btn_Edi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edi.BackColor = System.Drawing.Color.White;
            this.btn_Edi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Edi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Edi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edi.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Edi.Location = new System.Drawing.Point(557, 494);
            this.btn_Edi.Name = "btn_Edi";
            this.btn_Edi.Size = new System.Drawing.Size(99, 30);
            this.btn_Edi.TabIndex = 19;
            this.btn_Edi.Text = "Alterar";
            this.btn_Edi.UseVisualStyleBackColor = false;
            this.btn_Edi.Click += new System.EventHandler(this.btn_Edi_Click);
            // 
            // pnlProdutoEdi
            // 
            this.pnlProdutoEdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProdutoEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlProdutoEdi.Controls.Add(this.btn_Edi);
            this.pnlProdutoEdi.Controls.Add(this.listProdutos);
            this.pnlProdutoEdi.Controls.Add(this.gpCond);
            this.pnlProdutoEdi.Controls.Add(this.lblDescricao);
            this.pnlProdutoEdi.Controls.Add(this.rtbDescricao);
            this.pnlProdutoEdi.Controls.Add(this.lblCodProd);
            this.pnlProdutoEdi.Controls.Add(this.txbCodProd);
            this.pnlProdutoEdi.Controls.Add(this.lblQtd);
            this.pnlProdutoEdi.Controls.Add(this.txbQtd);
            this.pnlProdutoEdi.Controls.Add(this.lblAno);
            this.pnlProdutoEdi.Controls.Add(this.txbAno);
            this.pnlProdutoEdi.Controls.Add(this.lblProduto);
            this.pnlProdutoEdi.Controls.Add(this.cmbProduto);
            this.pnlProdutoEdi.Controls.Add(this.mtbDimensao);
            this.pnlProdutoEdi.Controls.Add(this.label1);
            this.pnlProdutoEdi.Controls.Add(this.lblMarca);
            this.pnlProdutoEdi.Controls.Add(this.txbMarca);
            this.pnlProdutoEdi.Controls.Add(this.lblModelo);
            this.pnlProdutoEdi.Controls.Add(this.txbModelo);
            this.pnlProdutoEdi.Location = new System.Drawing.Point(12, 12);
            this.pnlProdutoEdi.Name = "pnlProdutoEdi";
            this.pnlProdutoEdi.Size = new System.Drawing.Size(790, 538);
            this.pnlProdutoEdi.TabIndex = 1;
            // 
            // gpCond
            // 
            this.gpCond.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpCond.BackColor = System.Drawing.Color.Transparent;
            this.gpCond.Controls.Add(this.rdbUsado);
            this.gpCond.Controls.Add(this.rdbRecondi);
            this.gpCond.Controls.Add(this.rdbNovo);
            this.gpCond.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.gpCond.ForeColor = System.Drawing.Color.White;
            this.gpCond.Location = new System.Drawing.Point(33, 287);
            this.gpCond.Name = "gpCond";
            this.gpCond.Size = new System.Drawing.Size(214, 115);
            this.gpCond.TabIndex = 17;
            this.gpCond.TabStop = false;
            this.gpCond.Text = "Condição do Prodruto";
            // 
            // rdbUsado
            // 
            this.rdbUsado.AutoSize = true;
            this.rdbUsado.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.rdbUsado.Location = new System.Drawing.Point(6, 81);
            this.rdbUsado.Name = "rdbUsado";
            this.rdbUsado.Size = new System.Drawing.Size(72, 25);
            this.rdbUsado.TabIndex = 2;
            this.rdbUsado.TabStop = true;
            this.rdbUsado.Text = "Usado";
            this.rdbUsado.UseVisualStyleBackColor = true;
            // 
            // rdbRecondi
            // 
            this.rdbRecondi.AutoSize = true;
            this.rdbRecondi.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.rdbRecondi.Location = new System.Drawing.Point(6, 54);
            this.rdbRecondi.Name = "rdbRecondi";
            this.rdbRecondi.Size = new System.Drawing.Size(139, 25);
            this.rdbRecondi.TabIndex = 1;
            this.rdbRecondi.TabStop = true;
            this.rdbRecondi.Text = "Recondicionado";
            this.rdbRecondi.UseVisualStyleBackColor = true;
            // 
            // rdbNovo
            // 
            this.rdbNovo.AutoSize = true;
            this.rdbNovo.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.rdbNovo.Location = new System.Drawing.Point(6, 27);
            this.rdbNovo.Name = "rdbNovo";
            this.rdbNovo.Size = new System.Drawing.Size(66, 25);
            this.rdbNovo.TabIndex = 0;
            this.rdbNovo.TabStop = true;
            this.rdbNovo.Text = "Novo";
            this.rdbNovo.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescricao.Location = new System.Drawing.Point(28, 197);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(94, 25);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(33, 225);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(313, 47);
            this.rtbDescricao.TabIndex = 7;
            this.rtbDescricao.Text = "";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodProd.Location = new System.Drawing.Point(230, 132);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(123, 25);
            this.lblCodProd.TabIndex = 14;
            this.lblCodProd.Text = "Cód. Produto";
            // 
            // txbCodProd
            // 
            this.txbCodProd.Location = new System.Drawing.Point(235, 160);
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.Size = new System.Drawing.Size(110, 20);
            this.txbCodProd.TabIndex = 6;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQtd.Location = new System.Drawing.Point(299, 70);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(47, 25);
            this.lblQtd.TabIndex = 12;
            this.lblQtd.Text = "Qtd.";
            // 
            // txbQtd
            // 
            this.txbQtd.Location = new System.Drawing.Point(304, 98);
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(42, 20);
            this.txbQtd.TabIndex = 4;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAno.Location = new System.Drawing.Point(230, 70);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(46, 25);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano";
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(235, 98);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(41, 20);
            this.txbAno.TabIndex = 3;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProduto.Location = new System.Drawing.Point(28, 8);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(122, 25);
            this.lblProduto.TabIndex = 8;
            this.lblProduto.Text = "Tipo Produto";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Items.AddRange(new object[] {
            "Radiador",
            "Condensador",
            "Abraçadeira",
            "Tampa",
            "Caixa superior",
            "Caixa inferior"});
            this.cmbProduto.Location = new System.Drawing.Point(33, 36);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 0;
            // 
            // mtbDimensao
            // 
            this.mtbDimensao.Location = new System.Drawing.Point(33, 160);
            this.mtbDimensao.Mask = "9999 x 9999";
            this.mtbDimensao.Name = "mtbDimensao";
            this.mtbDimensao.Size = new System.Drawing.Size(73, 20);
            this.mtbDimensao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dimensão";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(235, 36);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(110, 20);
            this.txbMarca.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModelo.Location = new System.Drawing.Point(28, 70);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(77, 25);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(33, 98);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(121, 20);
            this.txbModelo.TabIndex = 2;
            // 
            // frmEditar_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 562);
            this.Controls.Add(this.pnlProdutoEdi);
            this.Name = "frmEditar_Prod";
            this.Text = "Editar";
            this.pnlProdutoEdi.ResumeLayout(false);
            this.pnlProdutoEdi.PerformLayout();
            this.gpCond.ResumeLayout(false);
            this.gpCond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ListView listProdutos;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhTipo;
        private System.Windows.Forms.ColumnHeader clhMarca;
        private System.Windows.Forms.ColumnHeader clhModelo;
        private System.Windows.Forms.ColumnHeader clhAno;
        private System.Windows.Forms.Button btn_Edi;
        private System.Windows.Forms.Panel pnlProdutoEdi;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.GroupBox gpCond;
        private System.Windows.Forms.RadioButton rdbUsado;
        private System.Windows.Forms.RadioButton rdbRecondi;
        private System.Windows.Forms.RadioButton rdbNovo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txbCodProd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txbQtd;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.MaskedTextBox mtbDimensao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txbModelo;
    }
}