using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormRelatorioProduto : Form
    {
        public FormRelatorioProduto()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseEstoqueDataSet1.Produto' table. You can move, or remove it, as needed.
            this.ProdutoTableAdapter.Fill(this.DatabaseEstoqueDataSet1.Produto);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
