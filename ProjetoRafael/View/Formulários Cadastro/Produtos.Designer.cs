using System;
using ProjetoRafael;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael.View {
    partial class frmCadastro_Prod {
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
            this.btn_Cad = new System.Windows.Forms.Button();
            this.gpCond = new System.Windows.Forms.GroupBox();
            this.rdbUsuado = new System.Windows.Forms.RadioButton();
            this.rdbRecon = new System.Windows.Forms.RadioButton();
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gpCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btn_Cad);
            this.panel1.Controls.Add(this.gpCond);
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
            this.panel1.Size = new System.Drawing.Size(660, 437);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cad
            // 
            this.btn_Cad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cad.BackColor = System.Drawing.Color.White;
            this.btn_Cad.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Cad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Cad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cad.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Cad.Location = new System.Drawing.Point(426, 394);
            this.btn_Cad.Name = "btn_Cad";
            this.btn_Cad.Size = new System.Drawing.Size(99, 30);
            this.btn_Cad.TabIndex = 18;
            this.btn_Cad.Text = "Cadastrar";
            this.btn_Cad.UseVisualStyleBackColor = false;
            this.btn_Cad.Click += new System.EventHandler(this.btn_Cad_Click);
            // 
            // gpCond
            // 
            this.gpCond.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpCond.BackColor = System.Drawing.Color.Transparent;
            this.gpCond.Controls.Add(this.rdbUsuado);
            this.gpCond.Controls.Add(this.rdbRecon);
            this.gpCond.Controls.Add(this.rdbNovo);
            this.gpCond.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.gpCond.ForeColor = System.Drawing.Color.White;
            this.gpCond.Location = new System.Drawing.Point(380, 15);
            this.gpCond.Name = "gpCond";
            this.gpCond.Size = new System.Drawing.Size(214, 115);
            this.gpCond.TabIndex = 17;
            this.gpCond.TabStop = false;
            this.gpCond.Text = "Condição do Prodruto";
            // 
            // rdbUsuado
            // 
            this.rdbUsuado.AutoSize = true;
            this.rdbUsuado.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.rdbUsuado.Location = new System.Drawing.Point(6, 81);
            this.rdbUsuado.Name = "rdbUsuado";
            this.rdbUsuado.Size = new System.Drawing.Size(72, 25);
            this.rdbUsuado.TabIndex = 2;
            this.rdbUsuado.TabStop = true;
            this.rdbUsuado.Text = "Usado";
            this.rdbUsuado.UseVisualStyleBackColor = true;
            // 
            // rdbRecon
            // 
            this.rdbRecon.AutoSize = true;
            this.rdbRecon.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.rdbRecon.Location = new System.Drawing.Point(6, 54);
            this.rdbRecon.Name = "rdbRecon";
            this.rdbRecon.Size = new System.Drawing.Size(139, 25);
            this.rdbRecon.TabIndex = 1;
            this.rdbRecon.TabStop = true;
            this.rdbRecon.Text = "Recondicionado";
            this.rdbRecon.UseVisualStyleBackColor = true;
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
            this.rtbDescricao.TabIndex = 7;
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
            this.txbCodProd.TabIndex = 6;
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
            this.txbQtd.TabIndex = 4;
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
            this.txbAno.TabIndex = 3;
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
            this.cmbProduto.TabIndex = 0;
            // 
            // mtbDimensao
            // 
            this.mtbDimensao.Location = new System.Drawing.Point(18, 170);
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
            this.txbMarca.TabIndex = 1;
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
            this.txbModelo.TabIndex = 2;
            // 
            // frmCadastro_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastro_Prod";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpCond.ResumeLayout(false);
            this.gpCond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblModelo;
        private TextBox txbModelo;
        private MaskedTextBox mtbDimensao;
        private Label label1;
        private Label lblMarca;
        private TextBox txbMarca;
        private Label lblProduto;
        private ComboBox cmbProduto;
        private Label lblQtd;
        private TextBox txbQtd;
        private Label lblAno;
        private TextBox txbAno;
        private RichTextBox rtbDescricao;
        private Label lblCodProd;
        private TextBox txbCodProd;
        private Label lblDescricao;
        private GroupBox gpCond;
        private RadioButton rdbUsuado;
        private RadioButton rdbRecon;
        private RadioButton rdbNovo;
        private Button btn_Cad;
    }
}