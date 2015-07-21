namespace Projeto
{
    partial class FormConsultarEstoque
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
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.dataGridViewResultEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(594, 13);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 0;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // dataGridViewResultEstoque
            // 
            this.dataGridViewResultEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultEstoque.Location = new System.Drawing.Point(13, 45);
            this.dataGridViewResultEstoque.Name = "dataGridViewResultEstoque";
            this.dataGridViewResultEstoque.Size = new System.Drawing.Size(656, 305);
            this.dataGridViewResultEstoque.TabIndex = 1;
            // 
            // FormConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 362);
            this.Controls.Add(this.dataGridViewResultEstoque);
            this.Controls.Add(this.buttonConsultar);
            this.Name = "FormConsultarEstoque";
            this.Text = "Consultar Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.DataGridView dataGridViewResultEstoque;
    }
}