namespace Projeto
{
    partial class FormRelatorioTotal
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatabaseEstoqueDataSet3 = new Projeto.DatabaseEstoqueDataSet3();
            this.EstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EstoqueTableAdapter = new Projeto.DatabaseEstoqueDataSet3TableAdapters.EstoqueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEstoqueDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatabaseEstoqueDataSet3_Estoque";
            reportDataSource1.Value = this.EstoqueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.Report4.rdlc";
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
            // DatabaseEstoqueDataSet3
            // 
            this.DatabaseEstoqueDataSet3.DataSetName = "DatabaseEstoqueDataSet3";
            this.DatabaseEstoqueDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstoqueBindingSource
            // 
            this.EstoqueBindingSource.DataMember = "Estoque";
            this.EstoqueBindingSource.DataSource = this.DatabaseEstoqueDataSet3;
            // 
            // EstoqueTableAdapter
            // 
            this.EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioTotal";
            this.Text = "Total Estoque";
            this.Load += new System.EventHandler(this.FormRelatorioTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEstoqueDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EstoqueBindingSource;
        private DatabaseEstoqueDataSet3 DatabaseEstoqueDataSet3;
        private Projeto.DatabaseEstoqueDataSet3TableAdapters.EstoqueTableAdapter EstoqueTableAdapter;
    }
}