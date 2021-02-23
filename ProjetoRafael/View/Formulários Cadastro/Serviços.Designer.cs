
namespace ProjetoRafael.View {
    partial class frmCadastro_Serv {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.pnlCad = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblServ = new System.Windows.Forms.Label();
            this.txbServ = new System.Windows.Forms.TextBox();
            this.gpTipSer = new System.Windows.Forms.GroupBox();
            this.ckbManutencao = new System.Windows.Forms.CheckBox();
            this.ckbReparo = new System.Windows.Forms.CheckBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlCad.SuspendLayout();
            this.gpTipSer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.rtbDescricao);
            this.panel1.Controls.Add(this.lblCodProd);
            this.panel1.Controls.Add(this.txbCodProd);
            this.panel1.Controls.Add(this.lblQtd);
            this.panel1.Controls.Add(this.txbQtd);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.txbAno);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Controls.Add(this.cmbProduto);
            this.panel1.Controls.Add(this.mtbDimensao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.txbMarca);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.txbModelo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(380, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 115);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condição do Prodruto";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.radioButton3.Location = new System.Drawing.Point(6, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Usado";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(139, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Recondicionado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Novo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescricao.Location = new System.Drawing.Point(13, 207);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(94, 25);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(18, 235);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(313, 96);
            this.rtbDescricao.TabIndex = 15;
            this.rtbDescricao.Text = "";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodProd.Location = new System.Drawing.Point(215, 142);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(123, 25);
            this.lblCodProd.TabIndex = 14;
            this.lblCodProd.Text = "Cód. Produto";
            // 
            // txbCodProd
            // 
            this.txbCodProd.Location = new System.Drawing.Point(220, 170);
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.Size = new System.Drawing.Size(110, 20);
            this.txbCodProd.TabIndex = 13;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQtd.Location = new System.Drawing.Point(284, 80);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(47, 25);
            this.lblQtd.TabIndex = 12;
            this.lblQtd.Text = "Qtd.";
            // 
            // txbQtd
            // 
            this.txbQtd.Location = new System.Drawing.Point(289, 108);
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(42, 20);
            this.txbQtd.TabIndex = 11;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAno.Location = new System.Drawing.Point(215, 80);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(46, 25);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano";
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(220, 108);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(41, 20);
            this.txbAno.TabIndex = 9;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProduto.Location = new System.Drawing.Point(13, 15);
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
            this.cmbProduto.Location = new System.Drawing.Point(18, 43);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 7;
            // 
            // mtbDimensao
            // 
            this.mtbDimensao.Location = new System.Drawing.Point(18, 170);
            this.mtbDimensao.Mask = "9999 x 9999";
            this.mtbDimensao.Name = "mtbDimensao";
            this.mtbDimensao.Size = new System.Drawing.Size(73, 20);
            this.mtbDimensao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dimensão";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarca.Location = new System.Drawing.Point(215, 15);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(65, 25);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(220, 43);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(110, 20);
            this.txbMarca.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModelo.Location = new System.Drawing.Point(13, 80);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(77, 25);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(18, 108);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(121, 20);
            this.txbModelo.TabIndex = 0;
            // 
            // pnlCad
            // 
            this.pnlCad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlCad.Controls.Add(this.btnCadastrar);
            this.pnlCad.Controls.Add(this.lblValor);
            this.pnlCad.Controls.Add(this.txbValor);
            this.pnlCad.Controls.Add(this.lblServ);
            this.pnlCad.Controls.Add(this.txbServ);
            this.pnlCad.Controls.Add(this.gpTipSer);
            this.pnlCad.Controls.Add(this.lblDesc);
            this.pnlCad.Controls.Add(this.rtbDesc);
            this.pnlCad.Location = new System.Drawing.Point(12, 12);
            this.pnlCad.Name = "pnlCad";
            this.pnlCad.Size = new System.Drawing.Size(660, 437);
            this.pnlCad.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Location = new System.Drawing.Point(461, 398);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(99, 30);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValor.Location = new System.Drawing.Point(320, 142);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 25);
            this.lblValor.TabIndex = 21;
            this.lblValor.Text = "Valor";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(325, 170);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(110, 20);
            this.txbValor.TabIndex = 1;
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblServ.Location = new System.Drawing.Point(13, 142);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(73, 25);
            this.lblServ.TabIndex = 19;
            this.lblServ.Text = "Serviço";
            // 
            // txbServ
            // 
            this.txbServ.Location = new System.Drawing.Point(18, 170);
            this.txbServ.Name = "txbServ";
            this.txbServ.Size = new System.Drawing.Size(243, 20);
            this.txbServ.TabIndex = 0;
            // 
            // gpTipSer
            // 
            this.gpTipSer.Controls.Add(this.ckbManutencao);
            this.gpTipSer.Controls.Add(this.ckbReparo);
            this.gpTipSer.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.gpTipSer.ForeColor = System.Drawing.Color.White;
            this.gpTipSer.Location = new System.Drawing.Point(18, 15);
            this.gpTipSer.Name = "gpTipSer";
            this.gpTipSer.Size = new System.Drawing.Size(245, 100);
            this.gpTipSer.TabIndex = 17;
            this.gpTipSer.TabStop = false;
            this.gpTipSer.Text = "Tipo de serviço executado";
            // 
            // ckbManutencao
            // 
            this.ckbManutencao.AutoSize = true;
            this.ckbManutencao.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.ckbManutencao.Location = new System.Drawing.Point(6, 61);
            this.ckbManutencao.Name = "ckbManutencao";
            this.ckbManutencao.Size = new System.Drawing.Size(115, 25);
            this.ckbManutencao.TabIndex = 1;
            this.ckbManutencao.Text = "Manutenção";
            this.ckbManutencao.UseVisualStyleBackColor = true;
            // 
            // ckbReparo
            // 
            this.ckbReparo.AutoSize = true;
            this.ckbReparo.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.ckbReparo.Location = new System.Drawing.Point(6, 30);
            this.ckbReparo.Name = "ckbReparo";
            this.ckbReparo.Size = new System.Drawing.Size(79, 25);
            this.ckbReparo.TabIndex = 0;
            this.ckbReparo.Text = "Reparo";
            this.ckbReparo.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesc.Location = new System.Drawing.Point(13, 207);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(94, 25);
            this.lblDesc.TabIndex = 16;
            this.lblDesc.Text = "Descrição";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(18, 235);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(418, 62);
            this.rtbDesc.TabIndex = 2;
            this.rtbDesc.Text = "";
            // 
            // frmCadastro_Serv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnlCad);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastro_Serv";
            this.Text = "cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCad.ResumeLayout(false);
            this.pnlCad.PerformLayout();
            this.gpTipSer.ResumeLayout(false);
            this.gpTipSer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
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
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Panel pnlCad;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.GroupBox gpTipSer;
        private System.Windows.Forms.CheckBox ckbManutencao;
        private System.Windows.Forms.CheckBox ckbReparo;
        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.TextBox txbServ;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Button btnCadastrar;
    }
}