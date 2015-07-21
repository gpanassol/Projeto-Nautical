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
    public partial class FormConsultaMovimentacao : Form
    {
        //VARIAVEL GLOBAL
        PoolConexoes pool = new PoolConexoes();

        public FormConsultaMovimentacao()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            carregarMovimentacao();
        }

        //METODO CARREGA MOVIMENTACAO DO ESTOQUE ATUAL CONSIDERANDO FILTRO
        private void carregarMovimentacao()
        {
            ArrayList lista = pool.getMovimentacao(comboBoxFiltro.Text);

            if (lista.Count > 0)
            {
                dataGridViewResultMovimentacao.DataSource = lista;
            }
            else
            {
                dataGridViewResultMovimentacao.DataSource = "";
                MessageBox.Show("Não existe movimentação.");
            }

        }
    }
}
