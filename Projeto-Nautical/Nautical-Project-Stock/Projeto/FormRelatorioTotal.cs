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
    public partial class FormRelatorioTotal : Form
    {
        public FormRelatorioTotal()
        {
            InitializeComponent();
        }

        private void FormRelatorioTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseEstoqueDataSet3.Estoque' table. You can move, or remove it, as needed.
            this.EstoqueTableAdapter.Fill(this.DatabaseEstoqueDataSet3.Estoque);

            this.reportViewer1.RefreshReport();
        }
    }
}
