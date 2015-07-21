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
    public partial class FormConsultarEstoque : Form
    {
        //VARIAVEL GLOBAL
        PoolConexoes pool = new PoolConexoes();

        public FormConsultarEstoque()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            carregarEstoque();
        }

        //METODO RESPONSAVEL POR CARREGAR TOTAIS DO ESTOQUE
        private void carregarEstoque()
        {
            ArrayList lista = pool.getEstoque();

            if (lista.Count > 0)
            {
                dataGridViewResultEstoque.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Não existe produto(s) no Estoque.");
            }
        }
    }
}
