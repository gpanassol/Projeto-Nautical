﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Projeto
{
    class PoolConexoes
    {
        //@ para reconhecer o caminho
        String caminho = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Gabriel\Pessoal\Projeto-Nautical\Projeto-Nautical\Nautical-Project-Stock\Projeto\DatabaseEstoque.mdf;Integrated Security=True;User Instance=True";
        
        //String caminho =  Projeto.Properties.Settings.Default.DatabaseEstoqueConnectionString;

        //METODO INSERE NOVO USUARIO
        public bool insertUsuario(Usuario usuario)
        {

            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "insert into Usuario(matricula, nome, endereco, telefone, rg, cpf, sexo, login, senha, permissao) " +
                             " values (@matricula, @nome, @endereco, @telefone, @rg, @cpf, @sexo, @login, @senha, @permissao) ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("matricula", usuario.Matricula);
                comando.Parameters.AddWithValue("nome", usuario.Nome);
                comando.Parameters.AddWithValue("endereco", usuario.Endereco);
                comando.Parameters.AddWithValue("telefone", usuario.Telefone);
                comando.Parameters.AddWithValue("rg", usuario.Rg);
                comando.Parameters.AddWithValue("cpf", usuario.Cpf);
                comando.Parameters.AddWithValue("sexo", usuario.Sexo);
                comando.Parameters.AddWithValue("login", usuario.Login);
                comando.Parameters.AddWithValue("senha", usuario.Senha);
                comando.Parameters.AddWithValue("permissao", usuario.Permissao);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        //METODO INSERE NOVO PRODUTO
        public bool insertProduto(Produto produto)
        {

            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "insert into Produto(codProduto, nome, descricao, tipoUnidade, observacao, valorUnitario, codFornecedor) " +
                             " values (@codProduto, @nome, @descricao, @tipoUnidade, @observacao, @valorUnitario, @codFornecedor) ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("codProduto", produto.CodProduto);
                comando.Parameters.AddWithValue("nome", produto.Nome);
                comando.Parameters.AddWithValue("descricao", produto.Descricao);
                comando.Parameters.AddWithValue("valorUnitario", produto.ValorUnitario);
                comando.Parameters.AddWithValue("tipoUnidade", produto.TpUnidade);
                comando.Parameters.AddWithValue("observacao", produto.Observacao);
                comando.Parameters.AddWithValue("codFornecedor", produto.CodFornecedor);


                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        //METODO BUSCA LOGIN TENDO COMO PARAMETRO LOGIN E SENHA
        public Usuario getLogin(String login, String senha)
        {
            Usuario usuario = new Usuario();

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = " Select * From Usuario Where login = '" + login
                       + "' AND senha = '" + senha + "'";

            try
            {

                SqlCommand comando = new SqlCommand(sql, conexao);
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    usuario.Matricula = dr[0].ToString();
                    usuario.Nome = dr[1].ToString();
                    usuario.Endereco = dr[2].ToString();
                    usuario.Telefone = dr[3].ToString();
                    usuario.Rg = dr[4].ToString();
                    usuario.Cpf = dr[5].ToString();
                    usuario.Sexo = dr[6].ToString();
                    usuario.Login = dr[7].ToString();
                    usuario.Senha = dr[8].ToString();
                    usuario.Permissao = dr[9].ToString();
                }
            }
            catch (Exception)
            {

                conexao.Close();
                return null;
            }

            conexao.Close();
            return usuario;

        }

        //METODO INSERE NOVA SENHA
        public void insertNewPassword(String novaSenha, String matricula)
        {
            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "insert into Usuario (Password) values (@novaSenha) ";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("novaSenha", novaSenha);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        //METODO BUSCA PRODUTO TENDO COM PARAMETRO COD_PRODUTO
        public ArrayList getProdutos(String codProduto)
        {

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Produto";

            if (codProduto != null && !codProduto.Equals(""))
            {
                sql += " WHERE codProduto = '" + codProduto + "'";
            }


            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            ArrayList arrProdutos = new ArrayList();

            while (dr.Read())
            {

                Produto produto = new Produto();

                produto.CodProduto = dr[0].ToString();
                produto.Nome = dr[1].ToString();
                produto.Descricao = dr[2].ToString();
                produto.ValorUnitario = dr[3].ToString();
                produto.TpUnidade = dr[4].ToString();
                produto.Observacao = dr[5].ToString();
                produto.CodFornecedor = dr[6].ToString();

                arrProdutos.Add(produto);
            }

            return arrProdutos;
        }

        //METODO BUSCA USUARIO TENDO COMO PARAMETRO MATRICULA E NOME
        public ArrayList getUsuario(String matricula, String nome)
        {

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Usuario WHERE 1=1 ";
        
            if (!matricula.Equals(""))
            {
                sql += " AND matricula = " + matricula;
            }

            if (!nome.Equals(""))
            {
                sql += " AND nome LIKE '%" + nome + "%'";
            }

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            ArrayList arrUsuario = new ArrayList();

            while (dr.Read())
            {

                Usuario usuario = new Usuario();

                usuario.Matricula = dr[0].ToString();
                usuario.Nome = dr[1].ToString();
                usuario.Endereco = dr[2].ToString();
                usuario.Telefone = dr[3].ToString();
                usuario.Rg = dr[4].ToString();
                usuario.Cpf = dr[5].ToString();
                usuario.Sexo = dr[6].ToString();
                usuario.Login = dr[7].ToString();
                usuario.Senha = dr[8].ToString();
                usuario.Permissao = dr[9].ToString();


                arrUsuario.Add(usuario);
            }

            return arrUsuario;
        }

        //METODO BUSCA USUARIO TENDO COMO PARAMETRO MATRICULA
        public Usuario getUsuario(String matricula)
        {

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Usuario WHERE matricula = " + matricula;

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            Usuario usuario = null;

            while (dr.Read())
            {
                usuario = new Usuario();

                usuario.Matricula = dr[0].ToString();
                usuario.Nome = dr[1].ToString();
                usuario.Endereco = dr[2].ToString();
                usuario.Telefone = dr[3].ToString();
                usuario.Rg = dr[4].ToString();
                usuario.Cpf = dr[5].ToString();
                usuario.Sexo = dr[6].ToString();
                usuario.Login = dr[7].ToString();
                usuario.Senha = dr[8].ToString();
                usuario.Permissao = dr[9].ToString();

            }

            return usuario;
        }

        //METODO PARA UPDATE USUARIO
        public Boolean updateUsuario(Usuario usuario)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "update Usuario set matricula = @matricula, nome = @nome, endereco = @endereco, telefone = @telefone, rg = @rg, cpf = @cpf," +
                " sexo = @sexo, login = @login, senha = @senha, permissao = @permissao " +
                " WHERE matricula = '" + usuario.Matricula + "'";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("matricula", usuario.Matricula);
                comando.Parameters.AddWithValue("nome", usuario.Nome);
                comando.Parameters.AddWithValue("endereco", usuario.Endereco);
                comando.Parameters.AddWithValue("telefone", usuario.Telefone);
                comando.Parameters.AddWithValue("rg", usuario.Rg);
                comando.Parameters.AddWithValue("cpf", usuario.Cpf);
                comando.Parameters.AddWithValue("sexo", usuario.Sexo);
                comando.Parameters.AddWithValue("login", usuario.Login);
                comando.Parameters.AddWithValue("senha", usuario.Senha);
                comando.Parameters.AddWithValue("permissao", usuario.Permissao);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //METODO BUSCA PRODUTO ESPECIFICO
        public Produto getProduto(String codProduto)
        {
            Produto produto = null;

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Produto WHERE codProduto = '" + codProduto + "'";

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                produto = new Produto();

                produto.CodProduto = dr[0].ToString();
                produto.Nome = dr[1].ToString();
                produto.Descricao = dr[2].ToString();
                produto.ValorUnitario = dr[3].ToString();
                produto.TpUnidade = dr[4].ToString();
                produto.Observacao = dr[5].ToString();
                produto.CodFornecedor = dr[6].ToString();

            }

            return produto;
        }

        //METODO PARA UPDATE DO PRODUTO
        public Boolean updateProduto(Produto produto)
        {

            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "UPDATE Produto  SET " +
                    " codProduto = @codProduto, nome = @nome, descricao = @descricao, " +
                    " valorUnitario = @valorUnitario, tipoUnidade = @tipoUnidade, observacao = @observacao, codFornecedor = @codFornecedor" +
                    " WHERE codProduto = '" + produto.CodProduto + "'";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("codProduto", produto.CodProduto);
                comando.Parameters.AddWithValue("nome", produto.Nome);
                comando.Parameters.AddWithValue("descricao", produto.Descricao);
                comando.Parameters.AddWithValue("valorUnitario", produto.ValorUnitario);
                comando.Parameters.AddWithValue("tipoUnidade", produto.TpUnidade);
                comando.Parameters.AddWithValue("observacao", produto.Observacao);
                comando.Parameters.AddWithValue("codFornecedor", produto.CodFornecedor);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        //METODO INSERE NOVOS REGISTRO NO ESTOQUE
        public bool insertEntradaEstoque(Estoque estoque)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "insert into Estoque(codProduto, descricao, quantidade, valorUnitario, valorTotal) " +
                             " values (@codProduto, @descricao, @quantidade, @valorUnitario, @valorTotal) ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("codProduto", estoque.CodProduto);
                comando.Parameters.AddWithValue("descricao", estoque.Descricao);
                comando.Parameters.AddWithValue("quantidade", estoque.Quantidade);
                comando.Parameters.AddWithValue("valorUnitario", estoque.ValorUnitario);
                comando.Parameters.AddWithValue("valorTotal", estoque.ValorTotal);
                
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //RETORNA REGISTRO DE UM PRODUTO NO ESTOQUE
        public Estoque getEstoque(String codProduto)
        {
            Estoque produtoEstoque = null;

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Estoque WHERE codProduto = '" + codProduto + "'";

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                produtoEstoque = new Estoque();

                produtoEstoque.CodProduto = dr[0].ToString();
                produtoEstoque.Descricao = dr[1].ToString();
                produtoEstoque.Quantidade = dr[2].ToString();
                produtoEstoque.ValorUnitario = dr[3].ToString();
                produtoEstoque.ValorTotal = dr[4].ToString();
            
            }

            return produtoEstoque;
        }

        //METODO ATUALIZA O ESTOQUE
        public Boolean updateEstoque(Estoque estoque)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "UPDATE Estoque  SET " +
                    " codProduto = @codProduto, descricao = @descricao, " +
                    " quantidade = @quantidade, valorUnitario = @valorUnitario, valorTotal = @valorTotal" +
                    " WHERE codProduto = '" + estoque.CodProduto + "'";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("codProduto", estoque.CodProduto);
                comando.Parameters.AddWithValue("descricao", estoque.Descricao);
                comando.Parameters.AddWithValue("quantidade", estoque.Quantidade);
                comando.Parameters.AddWithValue("valorUnitario", estoque.ValorUnitario);
                comando.Parameters.AddWithValue("valorTotal", estoque.ValorTotal);
                
                comando.ExecuteNonQuery();

            }
            catch (Exception) {
                return false;
            }

            return true;
        }

        //METODO REGISTRA OS MOVIMENTOS DO ESTOQUE (ENTRADA/SAIDA)
        public bool insertRelatorioEstoque(EstoqueRelatorio estoque)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "insert into Estoque_Relatorio(codProduto, descricao, quantidade, valorUnitario, valorTotal, movimentacao) " +
                             " values (@codProduto, @descricao, @quantidade, @valorUnitario, @valorTotal, @movimentacao) ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("codProduto", estoque.CodProduto);
                comando.Parameters.AddWithValue("descricao", estoque.Descricao);
                comando.Parameters.AddWithValue("quantidade", estoque.Quantidade);
                comando.Parameters.AddWithValue("valorUnitario", estoque.ValorUnitario);
                comando.Parameters.AddWithValue("valorTotal", estoque.ValorTotal);
                comando.Parameters.AddWithValue("movimentacao", estoque.Movimentacao);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //METODO PARA DELETAR USUARIO
        public bool excluirUsuario(String matricula)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "DELETE FROM Usuario Where matricula = " + matricula;

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
            
        }

        //METODO PARA DELETAR PRODUTO
        public bool excluirProduto(String codProduto)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "DELETE FROM Produto Where codProduto = " + codProduto;

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        //Metodo insere Fornecedor
        public bool insertFornecedor(Fornecedor fornecedor)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "insert into Fornecedor(codFornecedor, razaoSocial, cnpj, telefone, endereco, numero, bairro, cidade, estado, cep) " +
                             " values (@codFornecedor, @razaoSocial, @cnpj, @telefone, @endereco, @numero, @bairro, @cidade, @estado, @cep) ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("codFornecedor", fornecedor.CodFornecedor);
                comando.Parameters.AddWithValue("razaoSocial", fornecedor.RazaoSocial);
                comando.Parameters.AddWithValue("cnpj", fornecedor.Cnpj);
                comando.Parameters.AddWithValue("telefone", fornecedor.Telefone);
                comando.Parameters.AddWithValue("endereco", fornecedor.Endereco);
                comando.Parameters.AddWithValue("numero", fornecedor.Numero);
                comando.Parameters.AddWithValue("bairro", fornecedor.Bairro);
                comando.Parameters.AddWithValue("cidade", fornecedor.Cidade);
                comando.Parameters.AddWithValue("estado", fornecedor.Estado);
                comando.Parameters.AddWithValue("cep", fornecedor.Cep);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //METODO PARA DELETAR FORNECEDOR
        public bool excluirFornecedor(String codFornecedor)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = "DELETE FROM Fornecedor Where codFornecedor = " + codFornecedor;

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        //METODO PARA ATUALIZAR FORNECEDOR
        public Boolean updateFornecedor(Fornecedor fornecedor)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String sql = " UPDATE Fornecedor SET codFornecedor = @codFornecedor, razaoSocial = @razaoSocial, cnpj = @cnpj, " +
                                                   " telefone = @telefone, endereco = @endereco, numero = @numero, bairro = @bairro, cidade = @cidade," +
                                                   " estado = @estado, cep = @cep " +
                             " WHERE codFornecedor = '" + fornecedor.CodFornecedor + "'";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("codFornecedor", fornecedor.CodFornecedor);
                comando.Parameters.AddWithValue("razaoSocial", fornecedor.RazaoSocial);
                comando.Parameters.AddWithValue("cnpj", fornecedor.Cnpj);
                comando.Parameters.AddWithValue("telefone", fornecedor.Telefone);
                comando.Parameters.AddWithValue("endereco", fornecedor.Endereco);
                comando.Parameters.AddWithValue("numero", fornecedor.Numero);
                comando.Parameters.AddWithValue("bairro", fornecedor.Bairro);
                comando.Parameters.AddWithValue("cidade", fornecedor.Cidade);
                comando.Parameters.AddWithValue("estado", fornecedor.Estado);
                comando.Parameters.AddWithValue("cep", fornecedor.Cep);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //METODO RETORNA UM REGISTRO TENDO COM PARAMETRO O CODFORNECEDOR
        public Fornecedor getFornecedor(String codFornecedor)
        {
            Fornecedor fornecedor = null;

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Fornecedor WHERE codFornecedor = " + codFornecedor;

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                fornecedor = new Fornecedor();

                fornecedor.CodFornecedor = dr[0].ToString();
                fornecedor.RazaoSocial = dr[1].ToString();
                fornecedor.Cnpj = dr[2].ToString();
                fornecedor.Telefone = dr[3].ToString();
                fornecedor.Endereco = dr[4].ToString();
                fornecedor.Numero = dr[5].ToString();
                fornecedor.Bairro = dr[6].ToString();
                fornecedor.Cidade = dr[7].ToString();
                fornecedor.Estado = dr[8].ToString();
                fornecedor.Cep = dr[9].ToString();

            }

            return fornecedor;
        }

        //METODO RETORNA O CODFORNECEDOR DO FORNECEDOR TENDO COM PARAMETRO A RAZAO SOCIAL
        public String getCodFornecedor(String razaoSocial)
        {
            String codFornecedor = "";

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT codFornecedor FROM Fornecedor WHERE razaoSocial LIKE '%" + razaoSocial + "%'";

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            if (dr.Read())
            {
                codFornecedor = dr[0].ToString();
            }

            return codFornecedor;
        }

        //METODO RETORNA LISTA DE FORNECEDOR
        public ArrayList getFornecedorByWhere(String codFornecedor, String razaoSocial, String CNPJ)
        {
            ArrayList lista = new ArrayList();

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Fornecedor";

            if(!codFornecedor.Equals("") || !razaoSocial.Equals("") || !CNPJ.Equals(""))
            {
                sql += " WHERE 1 = 1 ";//GAMBIARRA...KKK

                if (!codFornecedor.Equals(""))
                {
                    sql += " AND codFornecedor = " + codFornecedor;
                }

                if(!razaoSocial.Equals("")){
                    sql += " AND razaoSocial LIKE '%" + razaoSocial + "%'";
                }

                if (!CNPJ.Equals(""))
                {
                    sql += " AND cpnj = " + CNPJ;
                }
            }

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                Fornecedor fornecedor = carregarFornecedor(dr);
                lista.Add(fornecedor);
            }

            return lista;
        }

        //METODO PARA CARREGAR FORNECEDOR NA ENTIDADE
        private Fornecedor carregarFornecedor(SqlDataReader dr)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.CodFornecedor = dr[0].ToString();
            fornecedor.RazaoSocial = dr[1].ToString();
            fornecedor.Cnpj = dr[2].ToString();
            fornecedor.Telefone = dr[3].ToString();
            fornecedor.Endereco = dr[4].ToString();
            fornecedor.Numero = dr[5].ToString();
            fornecedor.Bairro = dr[6].ToString();
            fornecedor.Cidade = dr[7].ToString();
            fornecedor.Estado = dr[8].ToString();
            fornecedor.Cep = dr[9].ToString();

            return fornecedor;
        }

        //METODO CARREGA LISTA DE FORNECEDORES
        public ArrayList getFornecedores()
        {
            
            ArrayList lista = new ArrayList();

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Fornecedor";

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                Fornecedor fornecedor = carregarFornecedor(dr);
                lista.Add(fornecedor);
            }

            return lista;

        }

        //METODO CARREGA MOVIMENTACAO DE ESTOQUE
        public ArrayList getMovimentacao(String filtro)
        {
            ArrayList lista = new ArrayList();

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Estoque_Relatorio ";

            if(!filtro.Equals("")){
                sql += "WHERE movimentacao LIKE '%" + filtro + "%'";
            }

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                EstoqueRelatorio produtoEstoque = new EstoqueRelatorio();

                produtoEstoque.CodProduto = dr[0].ToString();
                produtoEstoque.Descricao = dr[1].ToString();
                produtoEstoque.Quantidade = dr[2].ToString();
                produtoEstoque.ValorUnitario = dr[3].ToString();
                produtoEstoque.ValorTotal = dr[4].ToString();
                produtoEstoque.Movimentacao = dr[5].ToString();

                lista.Add(produtoEstoque);

            }

            return lista;
        }

        //METODO CARREGA LISTA DE PRODUTO NO ESTOQUE
        public ArrayList getEstoque()
        {
            ArrayList lista = new ArrayList();

            SqlConnection conexao = new SqlConnection(caminho);
            conexao.Open();

            String sql = "SELECT * FROM Estoque";

            SqlCommand comando = new SqlCommand(sql, conexao);
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                Estoque produtoEstoque = new Estoque();

                produtoEstoque.CodProduto = dr[0].ToString();
                produtoEstoque.Descricao = dr[1].ToString();
                produtoEstoque.Quantidade = dr[2].ToString();
                produtoEstoque.ValorUnitario = dr[3].ToString();
                produtoEstoque.ValorTotal = dr[4].ToString();

                lista.Add(produtoEstoque);

            }

            return lista;
        }

    }
}
