
namespace ProjetoRafael.View {
    partial class RelatorioUsuario {
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetUsuario = new ProjetoRafael.DataSetUsuario();
            this.dataSetUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBUsuariosTableAdapter = new ProjetoRafael.DataSetUsuarioTableAdapters.TBUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsuario";
            reportDataSource1.Value = this.tBUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoRafael.Relatórios.RelatorioUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetUsuario
            // 
            this.dataSetUsuario.DataSetName = "DataSetUsuario";
            this.dataSetUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetUsuarioBindingSource
            // 
            this.dataSetUsuarioBindingSource.DataSource = this.dataSetUsuario;
            this.dataSetUsuarioBindingSource.Position = 0;
            // 
            // tBUsuariosBindingSource
            // 
            this.tBUsuariosBindingSource.DataMember = "TBUsuarios";
            this.tBUsuariosBindingSource.DataSource = this.dataSetUsuarioBindingSource;
            // 
            // tBUsuariosTableAdapter
            // 
            this.tBUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioUsuario";
            this.Text = "RelatorioUsuario";
            this.Load += new System.EventHandler(this.RelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetUsuario dataSetUsuario;
        private System.Windows.Forms.BindingSource dataSetUsuarioBindingSource;
        private System.Windows.Forms.BindingSource tBUsuariosBindingSource;
        private DataSetUsuarioTableAdapters.TBUsuariosTableAdapter tBUsuariosTableAdapter;
    }
}