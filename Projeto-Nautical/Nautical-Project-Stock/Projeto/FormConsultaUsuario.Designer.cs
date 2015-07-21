namespace Projeto
{
    partial class FormConsultaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewConsUsuario = new System.Windows.Forms.DataGridView();
            this.databaseEstoqueDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseEstoqueDataSet = new Projeto.DatabaseEstoqueDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseEstoqueDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseEstoqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(70, 13);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatricula.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewConsUsuario
            // 
            this.dataGridViewConsUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsUsuario.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewConsUsuario.Name = "dataGridViewConsUsuario";
            this.dataGridViewConsUsuario.Size = new System.Drawing.Size(657, 308);
            this.dataGridViewConsUsuario.TabIndex = 3;
            this.dataGridViewConsUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsUsuario_CellClick);
            // 
            // databaseEstoqueDataSetBindingSource
            // 
            this.databaseEstoqueDataSetBindingSource.DataSource = this.databaseEstoqueDataSet;
            this.databaseEstoqueDataSetBindingSource.Position = 0;
            // 
            // databaseEstoqueDataSet
            // 
            this.databaseEstoqueDataSet.DataSetName = "DatabaseEstoqueDataSet";
            this.databaseEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(218, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(175, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // FormConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 362);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewConsUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaUsuario";
            this.Text = "Consultar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseEstoqueDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseEstoqueDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewConsUsuario;
        private System.Windows.Forms.BindingSource databaseEstoqueDataSetBindingSource;
        private DatabaseEstoqueDataSet databaseEstoqueDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}