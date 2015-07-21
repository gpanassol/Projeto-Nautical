using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Projeto
{
    class ValidaFormulario
    {
        //CLASSE VALIDA CLASSE FORNECEDOR
        public ArrayList validaFornecedor(Fornecedor fornecedor)
        {
            ArrayList listErro = new ArrayList();
            String mensagem = "";

            if (fornecedor.CodFornecedor.Equals(""))
            {
                mensagem = "Necessário Cod Fornecedor.";
                listErro.Add(mensagem);
            }

            if (fornecedor.RazaoSocial.Equals(""))
            {
                mensagem = "Necessário Razão Social.";
                listErro.Add(mensagem);
            }

            if (fornecedor.Cnpj.Equals(""))
            {
                mensagem = "Necessário CNPJ da Empresa.";
                listErro.Add(mensagem);
            }

            return listErro;
        }

        //METODO VALIDA CLASSE DE USUARIO
        public ArrayList validaUsuario(Usuario usuario)
        {
            ArrayList listErro = new ArrayList();
            String mensagem = "";

            if(usuario.Matricula.Equals("")){

                mensagem = "Necessário Matricula.";
                listErro.Add(mensagem);
            }

            if (usuario.Rg.Equals("")){
                mensagem = "Necessário RG.";
                listErro.Add(mensagem);
            }

            if (usuario.Cpf.Equals(""))
            {
                mensagem = "Necessário CPF.";
                listErro.Add(mensagem);
            }

            if(usuario.Permissao.Equals("")){
                mensagem = "Necessário Permissão.";
                listErro.Add(mensagem);
            }

            if (usuario.Login.Equals(""))
            {
                mensagem = "Necessário Login.";
                listErro.Add(mensagem);
            }

            if (usuario.Senha.Equals(""))
            {
                mensagem = "Necessário Senha.";
                listErro.Add(mensagem);
            }

            return listErro;
        }

        //CLASSE VALIDA CLASSE DE PRODUTO
        public ArrayList validaProduto(Produto produto)
        {
            ArrayList listErro = new ArrayList();
            String mensagem = "";

            if (produto.CodProduto.Equals(""))
            {
                mensagem = "Necessário Cod Produto.";
                listErro.Add(mensagem);
            }

            if (produto.Nome.Equals(""))
            {
                mensagem = "Necessário Nome do Produto.";
                listErro.Add(mensagem);
            }

            if (produto.ValorUnitario.Equals(""))
            {
                mensagem = "Necessário Qtd de Produto.";
                listErro.Add(mensagem);
            }

            if (produto.TpUnidade.Equals(""))
            {
                mensagem = "Necessário Tipo de Unidade do Produto.";
                listErro.Add(mensagem);
            }

            return listErro;

        }

        public ArrayList validaEstoque(Estoque estoque)
        {
            ArrayList listErro = new ArrayList();
            String mensagem = "";

            if(estoque.CodProduto.Equals("")){
                mensagem = "Necessário Codigo do Produto.";
                listErro.Add(mensagem);
            }

            if (estoque.Descricao.Equals(""))
            {
                mensagem = "Necessário Descrição do Produto.";
                listErro.Add(mensagem);
            }

            if (estoque.Quantidade.Equals(""))
            {
                mensagem = "Necessário Quantidade de Produtos.";
                listErro.Add(mensagem);
            }

            if (estoque.ValorUnitario.Equals(""))
            {
                mensagem = "Necessário Valor Unitário.";
                listErro.Add(mensagem);
            }

            if (estoque.ValorTotal.Equals(""))
            {
                mensagem = "Necessário Valor Total.";
                listErro.Add(mensagem);
            }

            return listErro;
        }

    }
}
