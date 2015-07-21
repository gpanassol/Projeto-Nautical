namespace Projeto
{
    partial class FormConsultaFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewResultFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodFornecedor";
            // 
            // textBoxCodFornecedor
            // 
            this.textBoxCodFornecedor.Location = new System.Drawing.Point(99, 10);
            this.textBoxCodFornecedor.Name = "textBoxCodFornecedor";
            this.textBoxCodFornecedor.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodFornecedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ";
            // 
            // textBoxCNPJ
            // 
            this.textBoxCNPJ.Location = new System.Drawing.Point(255, 10);
            this.textBoxCNPJ.Name = "textBoxCNPJ";
            this.textBoxCNPJ.Size = new System.Drawing.Size(148, 20);
            this.textBoxCNPJ.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Razão Social";
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(99, 43);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(165, 20);
            this.textBoxRazaoSocial.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(594, 46);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewResultFornecedor
            // 
            this.dataGridViewResultFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultFornecedor.Location = new System.Drawing.Point(13, 75);
            this.dataGridViewResultFornecedor.Name = "dataGridViewResultFornecedor";
            this.dataGridViewResultFornecedor.Size = new System.Drawing.Size(656, 275);
            this.dataGridViewResultFornecedor.TabIndex = 7;
            // 
            // FormConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 362);
            this.Controls.Add(this.dataGridViewResultFornecedor);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxRazaoSocial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodFornecedor);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaFornecedor";
            this.Text = "Consulta Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRazaoSocial;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewResultFornecedor;
    }
}