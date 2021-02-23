
namespace ProjetoRafael.View {
    partial class frmConsulta_Serv {
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
            this.pnlCon = new System.Windows.Forms.Panel();
            this.txbConsulta = new System.Windows.Forms.TextBox();
            this.btnCad_Busca = new System.Windows.Forms.Button();
            this.listServicos = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhServico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCon
            // 
            this.pnlCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlCon.Controls.Add(this.txbConsulta);
            this.pnlCon.Controls.Add(this.btnCad_Busca);
            this.pnlCon.Controls.Add(this.listServicos);
            this.pnlCon.Location = new System.Drawing.Point(12, 12);
            this.pnlCon.Name = "pnlCon";
            this.pnlCon.Size = new System.Drawing.Size(660, 437);
            this.pnlCon.TabIndex = 3;
            // 
            // txbConsulta
            // 
            this.txbConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbConsulta.Location = new System.Drawing.Point(0, 394);
            this.txbConsulta.Name = "txbConsulta";
            this.txbConsulta.Size = new System.Drawing.Size(660, 20);
            this.txbConsulta.TabIndex = 2;
            this.txbConsulta.Text = "Digite aqui sua busca";
            this.txbConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbConsulta.Click += new System.EventHandler(this.txbConsulta_Click);
            // 
            // btnCad_Busca
            // 
            this.btnCad_Busca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCad_Busca.Location = new System.Drawing.Point(0, 414);
            this.btnCad_Busca.Name = "btnCad_Busca";
            this.btnCad_Busca.Size = new System.Drawing.Size(660, 23);
            this.btnCad_Busca.TabIndex = 1;
            this.btnCad_Busca.Text = "Buscar";
            this.btnCad_Busca.UseVisualStyleBackColor = true;
            this.btnCad_Busca.Click += new System.EventHandler(this.btnCad_Busca_Click);
            // 
            // listServicos
            // 
            this.listServicos.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listServicos.BackColor = System.Drawing.Color.Gray;
            this.listServicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhCategoria,
            this.clhServico,
            this.clhValor,
            this.clhDescricao});
            this.listServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listServicos.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.listServicos.ForeColor = System.Drawing.Color.White;
            this.listServicos.FullRowSelect = true;
            this.listServicos.HideSelection = false;
            this.listServicos.Location = new System.Drawing.Point(0, 0);
            this.listServicos.Name = "listServicos";
            this.listServicos.Size = new System.Drawing.Size(660, 437);
            this.listServicos.TabIndex = 0;
            this.listServicos.UseCompatibleStateImageBehavior = false;
            this.listServicos.View = System.Windows.Forms.View.Details;
            // 
            // clhId
            // 
            this.clhId.Text = "ID";
            this.clhId.Width = 30;
            // 
            // clhCategoria
            // 
            this.clhCategoria.Text = "Categoria";
            this.clhCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhCategoria.Width = 100;
            // 
            // clhServico
            // 
            this.clhServico.Text = "Serviço";
            this.clhServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhServico.Width = 200;
            // 
            // clhValor
            // 
            this.clhValor.Text = "Valor";
            this.clhValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhValor.Width = 105;
            // 
            // clhDescricao
            // 
            this.clhDescricao.Text = "Descrição";
            this.clhDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhDescricao.Width = 260;
            // 
            // frmConsulta_Serv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnlCon);
            this.Name = "frmConsulta_Serv";
            this.Text = "Serviços";
            this.pnlCon.ResumeLayout(false);
            this.pnlCon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCon;
        private System.Windows.Forms.ListView listServicos;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhCategoria;
        private System.Windows.Forms.ColumnHeader clhServico;
        private System.Windows.Forms.ColumnHeader clhValor;
        private System.Windows.Forms.ColumnHeader clhDescricao;
        private System.Windows.Forms.Button btnCad_Busca;
        private System.Windows.Forms.TextBox txbConsulta;
    }
}