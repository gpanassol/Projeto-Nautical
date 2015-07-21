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
    public partial class FormRelatorioUsuario : Form
    {
        public FormRelatorioUsuario()
        {
            InitializeComponent();
        }

        private void FormRelatorioUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseEstoqueDataSet2.Usuario' table. You can move, or remove it, as needed.
            this.UsuarioTableAdapter.Fill(this.DatabaseEstoqueDataSet2.Usuario);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
