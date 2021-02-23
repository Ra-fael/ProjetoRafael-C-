
namespace ProjetoRafael.View {
    partial class frmCadastro_Usua {
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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCad_Usu = new System.Windows.Forms.Button();
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
            this.pnlProdutoEdi.Controls.Add(this.lblPerfil);
            this.pnlProdutoEdi.Controls.Add(this.cmbPerfil);
            this.pnlProdutoEdi.Controls.Add(this.txbSenha);
            this.pnlProdutoEdi.Controls.Add(this.lblSenha);
            this.pnlProdutoEdi.Controls.Add(this.btnCad_Usu);
            this.pnlProdutoEdi.Controls.Add(this.lblNome);
            this.pnlProdutoEdi.Controls.Add(this.txbNome);
            this.pnlProdutoEdi.Location = new System.Drawing.Point(12, 12);
            this.pnlProdutoEdi.Name = "pnlProdutoEdi";
            this.pnlProdutoEdi.Size = new System.Drawing.Size(790, 538);
            this.pnlProdutoEdi.TabIndex = 2;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPerfil.Location = new System.Drawing.Point(45, 151);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(60, 25);
            this.lblPerfil.TabIndex = 23;
            this.lblPerfil.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista",
            "Mecânico"});
            this.cmbPerfil.Location = new System.Drawing.Point(50, 179);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cmbPerfil.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(50, 116);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(214, 20);
            this.txbSenha.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Historic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenha.Location = new System.Drawing.Point(45, 88);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(68, 25);
            this.lblSenha.TabIndex = 20;
            this.lblSenha.Text = "Senha:";
            // 
            // btnCad_Usu
            // 
            this.btnCad_Usu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCad_Usu.BackColor = System.Drawing.Color.White;
            this.btnCad_Usu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCad_Usu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCad_Usu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad_Usu.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCad_Usu.Location = new System.Drawing.Point(604, 488);
            this.btnCad_Usu.Name = "btnCad_Usu";
            this.btnCad_Usu.Size = new System.Drawing.Size(99, 30);
            this.btnCad_Usu.TabIndex = 3;
            this.btnCad_Usu.Text = "Cadastrar";
            this.btnCad_Usu.UseVisualStyleBackColor = false;
            this.btnCad_Usu.Click += new System.EventHandler(this.btnCad_Usu_Click);
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
            // frmCadastro_Usua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 562);
            this.Controls.Add(this.pnlProdutoEdi);
            this.Name = "frmCadastro_Usua";
            this.Text = "Usuários";
            this.pnlProdutoEdi.ResumeLayout(false);
            this.pnlProdutoEdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdutoEdi;
        private System.Windows.Forms.Button btnCad_Usu;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblPerfil;
    }
}