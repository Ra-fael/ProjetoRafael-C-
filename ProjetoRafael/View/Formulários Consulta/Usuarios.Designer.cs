
namespace ProjetoRafael.View {
    partial class Usuarios {
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
            this.listUser = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPerfil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listUser
            // 
            this.listUser.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listUser.BackColor = System.Drawing.Color.Gray;
            this.listUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhNome,
            this.clhSenha,
            this.clhPerfil});
            this.listUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUser.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.listUser.ForeColor = System.Drawing.Color.White;
            this.listUser.FullRowSelect = true;
            this.listUser.HideSelection = false;
            this.listUser.Location = new System.Drawing.Point(0, 0);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(800, 450);
            this.listUser.TabIndex = 1;
            this.listUser.UseCompatibleStateImageBehavior = false;
            this.listUser.View = System.Windows.Forms.View.Details;
            // 
            // clhId
            // 
            this.clhId.Text = "ID";
            this.clhId.Width = 30;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhNome.Width = 100;
            // 
            // clhSenha
            // 
            this.clhSenha.Text = "Senha";
            this.clhSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhSenha.Width = 200;
            // 
            // clhPerfil
            // 
            this.clhPerfil.Text = "Perfil";
            this.clhPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhPerfil.Width = 105;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listUser);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhSenha;
        private System.Windows.Forms.ColumnHeader clhPerfil;
    }
}