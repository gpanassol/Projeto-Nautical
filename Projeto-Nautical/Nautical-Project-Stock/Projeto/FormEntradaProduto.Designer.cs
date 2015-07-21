namespace Projeto
{
    partial class FormEntradaProduto
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
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.buttonEntrada = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entradas";
            // 
            // textBoxCodProduto
            // 
            this.textBoxCodProduto.Location = new System.Drawing.Point(13, 30);
            this.textBoxCodProduto.Name = "textBoxCodProduto";
            this.textBoxCodProduto.Size = new System.Drawing.Size(136, 20);
            this.textBoxCodProduto.TabIndex = 2;
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(12, 94);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(136, 20);
            this.textBoxEntrada.TabIndex = 3;
            // 
            // buttonEntrada
            // 
            this.buttonEntrada.Location = new System.Drawing.Point(342, 219);
            this.buttonEntrada.Name = "buttonEntrada";
            this.buttonEntrada.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrada.TabIndex = 4;
            this.buttonEntrada.Text = "Entrada";
            this.buttonEntrada.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(261, 219);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 254);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrada);
            this.Controls.Add(this.textBoxEntrada);
            this.Controls.Add(this.textBoxCodProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEntradaProduto";
            this.Text = "Entrada de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodProduto;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.Button buttonEntrada;
        private System.Windows.Forms.Button buttonCancelar;
    }
}