﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormEntrada : Form
    {
        private PoolConexoes pool = new PoolConexoes();
        private ValidaFormulario valida = new ValidaFormulario();
        private Produto produto = null;
        private Estoque cachEstoque = null;

        public FormEntrada()
        {
            InitializeComponent();
        }

        //Interessao da pagina com o preenchimento do codProduto
        private void textBoxCodProduto_Leave(object sender, EventArgs e)
        {
            if (!textBoxCodProduto.Text.Equals(""))
            {
                produto = pool.getProduto(textBoxCodProduto.Text);

                if (produto != null)
                {
                    textBoxDescProduto.Text = produto.Descricao;
                    textBoxValorUnit.Text = produto.ValorUnitario;
                    textBoxValorTotal.Text = produto.ValorUnitario;
                }
            }

        }

        //Interessao da pagina com o preenchimento da Qtd
        private void textBoxQtd_Leave(object sender, EventArgs e)
        {
            if (!textBoxQtd.Text.Equals(""))
            {
                Double qtd = Double.Parse(textBoxQtd.Text);

                if (qtd > 0)
                {
                    Double vlUnit = Double.Parse(textBoxValorUnit.Text);

                    Double vlTotal = vlUnit * qtd;

                    textBoxValorTotal.Text = vlTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Quantidade deve ser maior que zero.");
                }
            }
        }

        //METODO VERIFICA SE EXISTE PRODUTO CADASTRADO NO ESTOQUE
        //CASO HAJA, SOMENTE FAZ UPDATE NOS DADOS
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            cachEstoque = pool.getEstoque(textBoxCodProduto.Text);

            if (cachEstoque == null)
            {
                registrarEntradaProduto();
            }
            else
            {
                atualizarEntradaProduto();
            }
        }

        //Metodo para registrar as Entradas
        private void registrarEntradaProduto()
        {
            Estoque entEstoque = new Estoque();
            entEstoque.CodProduto = textBoxCodProduto.Text;
            entEstoque.Descricao = textBoxDescProduto.Text;
            entEstoque.Quantidade = textBoxQtd.Text;
            entEstoque.ValorUnitario = textBoxValorUnit.Text;
            entEstoque.ValorTotal = textBoxValorTotal.Text;
           // entEstoque.Movimentacao = "ENTRADA";

            ArrayList mensagens = valida.validaEstoque(entEstoque);

            if (mensagens.Count > 0)
            {
                String mensagem = (String)mensagens[0];
                MessageBox.Show(mensagem);
            }
            else
            {
                try
                {
                    bool insert = pool.insertEntradaEstoque(entEstoque);
                    gerarRelatorioEstoque();
                    if (insert)
                    {
                        MessageBox.Show("Entrada registrada com sucesso.");
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao registrar entrada.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao registrar entrada.");
                }
            }
        }

        private void atualizarEntradaProduto()
        {
            double qtdSaldo = Double.Parse(cachEstoque.Quantidade);
            double qtdEntrada = Double.Parse(textBoxQtd.Text);

            double qtd = qtdEntrada + qtdSaldo;

            Estoque entEstoque = new Estoque();
            entEstoque.CodProduto = textBoxCodProduto.Text;
            entEstoque.Descricao = textBoxDescProduto.Text;
            entEstoque.Quantidade = qtd.ToString();
            entEstoque.ValorUnitario = textBoxValorUnit.Text;
            entEstoque.ValorTotal = textBoxValorTotal.Text;

            ArrayList mensagens = valida.validaEstoque(entEstoque);

            if (mensagens.Count > 0)
            {
                String mensagem = (String)mensagens[0];
                MessageBox.Show(mensagem);
            }
            else
            {
                try
                {
                    bool insert = pool.updateEstoque(entEstoque);
                    gerarRelatorioEstoque();
                    if (insert)
                    {
                        MessageBox.Show("Entrada registrada com sucesso.");
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao registrar entrada.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao registrar entrada.");
                }
            }
        }

        //METODO LIMPA O FORMULARIO
        private void limpar()
        {
            textBoxCodProduto.Text = "";
            textBoxDescProduto.Text = "";
            textBoxQtd.Text = "1";
            textBoxValorUnit.Text = "";
            textBoxValorTotal.Text = "";
        }

        //METODO GERA RELATORIO DE ENTRADAS DO ESTOQUE
        private void gerarRelatorioEstoque()
        {
            EstoqueRelatorio estoque = new EstoqueRelatorio();
            estoque.CodProduto = textBoxCodProduto.Text;
            estoque.Descricao = textBoxDescProduto.Text;
            estoque.Quantidade = textBoxQtd.Text;
            estoque.ValorUnitario = textBoxValorUnit.Text;
            estoque.ValorTotal = textBoxValorTotal.Text;
            estoque.Movimentacao = "ENTRADA";

            pool.insertRelatorioEstoque(estoque);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
