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
    public partial class FormRelatorioEstoque : Form
    {
        public FormRelatorioEstoque()
        {
            InitializeComponent();
        }

        private void FormRelatorioEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseEstoqueDataSet.Estoque_Relatorio' table. You can move, or remove it, as needed.
            this.Estoque_RelatorioTableAdapter.Fill(this.DatabaseEstoqueDataSet.Estoque_Relatorio);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
