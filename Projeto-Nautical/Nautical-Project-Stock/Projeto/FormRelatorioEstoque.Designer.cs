namespace Projeto
{
    partial class FormRelatorioEstoque
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
            this.Estoque_RelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseEstoqueDataSet = new Projeto.DatabaseEstoqueDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Estoque_RelatorioTableAdapter = new Projeto.DatabaseEstoqueDataSetTableAdapters.Estoque_RelatorioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Estoque_RelatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEstoqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Estoque_RelatorioBindingSource
            // 
            this.Estoque_RelatorioBindingSource.DataMember = "Estoque_Relatorio";
            this.Estoque_RelatorioBindingSource.DataSource = this.DatabaseEstoqueDataSet;
            // 
            // DatabaseEstoqueDataSet
            // 
            this.DatabaseEstoqueDataSet.DataSetName = "DatabaseEstoqueDataSet";
            this.DatabaseEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatabaseEstoqueDataSet_Estoque_Relatorio";
            reportDataSource1.Value = this.Estoque_RelatorioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(661, 335);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Estoque_RelatorioTableAdapter
            // 
            this.Estoque_RelatorioTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioEstoque";
            this.Text = "Relatorio de Estoque";
            this.Load += new System.EventHandler(this.FormRelatorioEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Estoque_RelatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEstoqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Estoque_RelatorioBindingSource;
        private DatabaseEstoqueDataSet DatabaseEstoqueDataSet;
        private Projeto.DatabaseEstoqueDataSetTableAdapters.Estoque_RelatorioTableAdapter Estoque_RelatorioTableAdapter;
    }
}