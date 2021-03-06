﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto
{
    public class EstoqueRelatorio
    {
        private string _codProduto;
        private string _descricao;
        private string _quantidade;
        private string _valorUnitario;
        private string _valorTotal;
        private string _movimentacao;

        public string CodProduto
        {
            get { return _codProduto; }
            set { _codProduto = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public string ValorUnitario
        {
            get { return _valorUnitario; }
            set { _valorUnitario = value; }
        }

        public string ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }

        public string Movimentacao
        {
            get { return _movimentacao; }
            set { _movimentacao = value; }
        }
    }
}
