﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormAlterarSenha : Form
    {
        //VARIAVEIS GLOBAIS
        private PoolConexoes conexoes = new PoolConexoes();
        private Usuario cacheUsuario = null;

        public FormAlterarSenha()
        {
            InitializeComponent();
        }

        //RECEBE A INSTANCIA DO USUARIO LOGADO ATUALMENTE
        internal Usuario CacheUsuario
        {
            get { return cacheUsuario; }
            set { cacheUsuario = value; }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        //METODO UTILIZADO PARA LIMPAR CAMPOS DO FORM
        private void limpar()
        {
            textBoxConfirmarNovaSenha.Text = "";
            textBoxNovaSenha.Text = "";
            textBoxSenhaAtual.Text = "";
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (!textBoxNovaSenha.Text.Equals(textBoxConfirmarNovaSenha.Text))
            {
                MessageBox.Show("Senhas estão diferentes.");
            }
            else if (!textBoxSenhaAtual.Text.Equals(cacheUsuario.Senha))
            {
                MessageBox.Show("Senha Atual esta errada.");
            }
            else
            {
                alterarSenha(textBoxSenhaAtual.Text);
            }
        }

        //METODO ALTERA SENHA DO USUARIO
        private void alterarSenha(String novaSenha)
        {
            cacheUsuario.Senha = novaSenha;
            Boolean isAlterado = conexoes.updateUsuario(cacheUsuario);

            if (isAlterado)
            {
                MessageBox.Show("Senha Alterado com sucesso.");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao alterar Senha.");
            }
        }
    }
}
