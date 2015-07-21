using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormConsultaFornecedor : Form
    {
        //VARIAVEIS GLOBAIS
        private PoolConexoes pool = new PoolConexoes();

        public FormConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscarFornecedor();
        }

        //METODO BUSCAR FORNECEDOR(ERS)
        private void buscarFornecedor()
        {
            ArrayList lista = pool.getFornecedorByWhere(textBoxCodFornecedor.Text, textBoxRazaoSocial.Text, textBoxCNPJ.Text);

            if (lista.Capacity != 0)
            {
                dataGridViewResultFornecedor.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Nenhum Fornecedor encontrado.");
            }

        }
    }
}
