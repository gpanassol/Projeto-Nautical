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
    public partial class FormConsultaProduto : Form
    {
        public FormConsultaProduto()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            carregarProduto();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        //METODO CARREGA PRODUTO
        private void carregarProduto()
        {
            PoolConexoes conexao = new PoolConexoes();

            String codProduto = textBoxCodProduto.Text;

            ArrayList arrProduto = conexao.getProdutos(codProduto);

            if (arrProduto.Capacity != 0)
            {
                dataGridViewResultProduto.DataSource = arrProduto;
            }
            else
            {
                MessageBox.Show("Nenhum Produto encontrado.");
            }
        }

        private void limpar()
        {
            dataGridViewResultProduto.DataSource = "";
        }


    }
}
