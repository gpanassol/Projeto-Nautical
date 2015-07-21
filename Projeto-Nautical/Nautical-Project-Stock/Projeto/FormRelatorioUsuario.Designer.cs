namespace Projeto
{
    partial class FormRelatorioUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseEstoqueDataSet2 = new Projeto.DatabaseEstoqueDataSet2();
            this.UsuarioTableAdapter = new Projeto.DatabaseEstoqueDataSet2TableAdapters.UsuarioTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEstoqueDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioBindingSource
            // 
            this.UsuarioBindingSource.DataMember = "Usuario";
            this.UsuarioBindingSource.DataSource = this.DatabaseEstoqueDataSet2;
            // 
            // DatabaseEstoqueDataSet2
            // 
            this.DatabaseEstoqueDataSet2.DataSetName = "DatabaseEstoqueDataSet2";
            this.DatabaseEstoqueDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsuarioTableAdapter
            // 
            this.UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatabaseEstoqueDataSet2_Usuario";
            reportDataSource1.Value = this.UsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(661, 335);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioUsuario";
            this.Text = "Relatorio de Usuarios";
            this.Load += new System.EventHandler(this.FormRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEstoqueDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource UsuarioBindingSource;
        private DatabaseEstoqueDataSet2 DatabaseEstoqueDataSet2;
        private Projeto.DatabaseEstoqueDataSet2TableAdapters.UsuarioTableAdapter UsuarioTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}