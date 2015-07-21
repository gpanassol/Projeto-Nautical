namespace Projeto
{
    partial class FormEntrada
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodProduto = new System.Windows.Forms.TextBox();
            this.textBoxDescProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValorUnit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descricao";
            // 
            // textBoxCodProduto
            // 
            this.textBoxCodProduto.Location = new System.Drawing.Point(86, 13);
            this.textBoxCodProduto.Name = "textBoxCodProduto";
            this.textBoxCodProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodProduto.TabIndex = 3;
            this.textBoxCodProduto.Leave += new System.EventHandler(this.textBoxCodProduto_Leave);
            // 
            // textBoxDescProduto
            // 
            this.textBoxDescProduto.Location = new System.Drawing.Point(86, 44);
            this.textBoxDescProduto.Name = "textBoxDescProduto";
            this.textBoxDescProduto.Size = new System.Drawing.Size(290, 20);
            this.textBoxDescProduto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtd";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(86, 73);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(100, 20);
            this.textBoxQtd.TabIndex = 6;
            this.textBoxQtd.Text = "1";
            this.textBoxQtd.Leave += new System.EventHandler(this.textBoxQtd_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Total";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Enabled = false;
            this.textBoxValorTotal.Location = new System.Drawing.Point(465, 73);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorTotal.TabIndex = 8;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(490, 137);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 9;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(409, 137);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Unit.";
            // 
            // textBoxValorUnit
            // 
            this.textBoxValorUnit.Enabled = false;
            this.textBoxValorUnit.Location = new System.Drawing.Point(276, 73);
            this.textBoxValorUnit.Name = "textBoxValorUnit";
            this.textBoxValorUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorUnit.TabIndex = 12;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 172);
            this.Controls.Add(this.textBoxValorUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxValorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescProduto);
            this.Controls.Add(this.textBoxCodProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEntrada";
            this.Text = "Registro de Entrada(s)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodProduto;
        private System.Windows.Forms.TextBox textBoxDescProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValorUnit;
    }
}