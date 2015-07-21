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
    public partial class FormPrincipalOperacional : Form
    {
        private Usuario cacheUsuario = null;

        public FormPrincipalOperacional()
        {
            InitializeComponent();
        }

        internal Usuario CacheUsuario
        {
            get { return cacheUsuario; }
            set { cacheUsuario = value; }
        }

        private void FormPrincipalOperacional_Load(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormSaidaProduto formSaidaProduto = new FormSaidaProduto();
            //formSaidaProduto.Show();
        }

        private void consultaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaProduto formConsultaProduto = new FormConsultaProduto();
            formConsultaProduto.Show();
        }

        private void entradaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntrada formEntrada = new FormEntrada();
            formEntrada.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha();
            formAlterarSenha.CacheUsuario = cacheUsuario;
            formAlterarSenha.Show();
        }

        private void buttonLogoutOP_Click(object sender, EventArgs e)
        {
            FormLogin formLogoutOP = new FormLogin();
            formLogoutOP.Show();
            this.Close();
        }

        private void lgoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
  

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogout = new FormLogin();
            formLogout.Show();


            
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioProduto formRelatorioCliente = new FormRelatorioProduto();
            formRelatorioCliente.Show();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioUsuario formRelatorioUsuario = new FormRelatorioUsuario();
            formRelatorioUsuario.Show();
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioTotal formRelatorioTotaleEstoque = new FormRelatorioTotal();
            formRelatorioTotaleEstoque.Show();
        }

        private void consultaDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaUsuario formConsultaUsuárioop = new FormConsultaUsuario();
            formConsultaUsuárioop.Show();
        }

        private void estoqueESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioEstoque formRelatorioESestoque = new FormRelatorioEstoque();
            formRelatorioESestoque.Show();
        }

        private void consultaFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaFornecedor consultFornecedor = new FormConsultaFornecedor();
            consultFornecedor.Show();
        }

    }
}
