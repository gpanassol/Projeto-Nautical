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
    public partial class FormPrincipal : Form
    {

        private Usuario cacheUsuario = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        internal Usuario CacheUsuario
        {
            get { return cacheUsuario; }
            set { cacheUsuario = value; }
        }

        private void consultaDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaUsuario formConsultaUsuario = new FormConsultaUsuario();
            formConsultaUsuario.Show();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario formCadastroUsuario = new FormCadastroUsuario();
            formCadastroUsuario.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha();
            formAlterarSenha.CacheUsuario = cacheUsuario;
            formAlterarSenha.Show();
        }

        private void saidaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaida formSaida = new FormSaida();
            formSaida.Show();
        }

        private void entradaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntrada formEntrada = new FormEntrada();
            formEntrada.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogout = new FormLogin();
            formLogout.Show();
            this.Close();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioProduto formRelatorioCliente = new FormRelatorioProduto();
            formRelatorioCliente.Show();
        }

        private void usuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioUsuario formRelatorioUsuario = new FormRelatorioUsuario();
            formRelatorioUsuario.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLogin formLogout = new FormLogin();
            formLogout.Show();
            this.Close();

        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormRelatorioEstoque formRelatorioEstoqueES = new FormRelatorioEstoque();
            formRelatorioEstoqueES.Show();
        }

        private void qtEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioTotal formRelatorioEstoqueTotal = new FormRelatorioTotal();
            formRelatorioEstoqueTotal.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastraFornecedor cadastraFornecedor = new FormCadastraFornecedor();
            cadastraFornecedor.Show();
        }

        private void consultarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaFornecedor consultaFornecedor = new FormConsultaFornecedor();
            consultaFornecedor.Show();
        }

        private void consultarMovimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaMovimentacao consultaMovimentacao = new FormConsultaMovimentacao();
            consultaMovimentacao.Show();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastraProduto formCadastroProduto = new FormCadastraProduto();
            formCadastroProduto.Show();
        }

        private void consultaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaProduto formConsultaProduto = new FormConsultaProduto();
            formConsultaProduto.Show();
        }

        private void consultarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarEstoque formConsultarEstoque = new FormConsultarEstoque();
            formConsultarEstoque.Show();
        }
    }
}
