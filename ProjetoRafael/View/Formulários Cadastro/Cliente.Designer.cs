
namespace ProjetoRafael.View {
    partial class frmCadastro_Clie {
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
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btn_Cad = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.pnlProdutoEdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProdutoEdi
            // 
            this.pnlProdutoEdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProdutoEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlProdutoEdi.Controls.Add(this.txbEmail);
            this.pnlProdutoEdi.Controls.Add(this.lblEmail);
            this.pnlProdutoEdi.Controls.Add(this.mskCpf);
            this.pnlProdutoEdi.Controls.Add(this.lblCPF);
            this.pnlProdutoEdi.Controls.Add(this.lblModelo);
            this.pnlProdutoEdi.Controls.Add(this.txbModelo);
            this.pnlProdutoEdi.Controls.Add(this.lblVeiculo);
            this.pnlProdutoEdi.Controls.Add(this.cmbVeiculo);
            this.pnlProdutoEdi.Controls.Add(this.txbTelefone);
            this.pnlProdutoEdi.Controls.Add(this.lblTelefone);
            this.pnlProdutoEdi.Controls.Add(this.btn_Cad);
            this.pnlProdutoEdi.Controls.Add(this.lblNome);
            this.pnlProdutoEdi.Controls.Add(this.txbNome);
            this.pnlProdutoEdi.Location = new System.Drawing.Point(12, 12);
            this.pnlProdutoEdi.Name = "pnlProdutoEdi";
            this.pnlProdutoEdi.Size = new System.Drawing.Size(790, 538);
            this.pnlProdutoEdi.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(50, 301);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(214, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(45, 273);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 25);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "E-mail:";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(316, 51);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(84, 20);
            this.mskCpf.TabIndex = 1;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCPF.Location = new System.Drawing.Point(311, 23);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 25);
            this.lblCPF.TabIndex = 26;
            this.lblCPF.Text = "CPF:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModelo.Location = new System.Drawing.Point(45, 208);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(81, 25);
            this.lblModelo.TabIndex = 25;
            this.lblModelo.Text = "Modelo:";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(50, 236);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(214, 20);
            this.txbModelo.TabIndex = 4;
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVeiculo.Location = new System.Drawing.Point(45, 150);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(79, 25);
            this.lblVeiculo.TabIndex = 23;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Items.AddRange(new object[] {
            "Fiat",
            "Ford",
            "Volkswagen",
            "BMW"});
            this.cmbVeiculo.Location = new System.Drawing.Point(50, 178);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(214, 21);
            this.cmbVeiculo.TabIndex = 3;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(50, 115);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(214, 20);
            this.txbTelefone.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefone.Location = new System.Drawing.Point(45, 87);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(89, 25);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "Telefone:";
            // 
            // btn_Cad
            // 
            this.btn_Cad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cad.BackColor = System.Drawing.Color.White;
            this.btn_Cad.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Cad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Cad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cad.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Cad.Location = new System.Drawing.Point(604, 488);
            this.btn_Cad.Name = "btn_Cad";
            this.btn_Cad.Size = new System.Drawing.Size(99, 30);
            this.btn_Cad.TabIndex = 19;
            this.btn_Cad.Text = "Cadastrar";
            this.btn_Cad.UseVisualStyleBackColor = false;
            this.btn_Cad.Click += new System.EventHandler(this.btn_Cad_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(45, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 25);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(50, 51);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(214, 20);
            this.txbNome.TabIndex = 0;
            // 
            // frmCadastro_Clie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 562);
            this.Controls.Add(this.pnlProdutoEdi);
            this.Name = "frmCadastro_Clie";
            this.Text = "Cliente";
            this.pnlProdutoEdi.ResumeLayout(false);
            this.pnlProdutoEdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdutoEdi;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btn_Cad;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}