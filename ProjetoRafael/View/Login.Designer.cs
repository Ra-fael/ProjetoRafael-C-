
namespace ProjetoRafael.View {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsu = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbUsu = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txbSen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.lblUsu.Location = new System.Drawing.Point(12, 29);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(64, 21);
            this.lblUsu.TabIndex = 0;
            this.lblUsu.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.lblSenha.Location = new System.Drawing.Point(11, 84);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 21);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txbUsu
            // 
            this.txbUsu.Location = new System.Drawing.Point(12, 53);
            this.txbUsu.Name = "txbUsu";
            this.txbUsu.Size = new System.Drawing.Size(176, 20);
            this.txbUsu.TabIndex = 2;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(100, 183);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(72, 31);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txbSen
            // 
            this.txbSen.Location = new System.Drawing.Point(12, 108);
            this.txbSen.Name = "txbSen";
            this.txbSen.PasswordChar = '*';
            this.txbSen.Size = new System.Drawing.Size(176, 20);
            this.txbSen.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 226);
            this.Controls.Add(this.txbSen);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txbUsu);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbUsu;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txbSen;
    }
}