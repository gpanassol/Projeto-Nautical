using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto
{
    class Produto
    {
        private string _codProduto;
        private string _nome;
        private string _descricao;
        private string _valorUnitario;
        private string _tpUnidade;
        private string _observacao;
        private string _codFornecedor;

        public string CodFornecedor
        {
            get { return _codFornecedor; }
            set { _codFornecedor = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string ValorUnitario
        {
            get { return _valorUnitario; }
            set { _valorUnitario = value; }
        }


        public string TpUnidade
        {
            get { return _tpUnidade; }
            set { _tpUnidade = value; }
        }


        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }

        public string CodProduto
        {
            get { return _codProduto; }
            set { _codProduto = value; }
        }
    }
}
