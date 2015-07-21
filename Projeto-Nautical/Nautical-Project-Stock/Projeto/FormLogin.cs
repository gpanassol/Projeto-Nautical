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
    public partial class FormLogin : Form
    {
        private Usuario usuario = null;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        { 
        }
           

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja encerra?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click_1(object sender, EventArgs e)
        {

            String login = textBoxLogin.Text;
            String password = textBoxSenha.Text;

            if(login.Equals("")){
                MessageBox.Show("Login é necessário.");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Senha é necessário.");
            }
            else
            {
                logar(login, password);
            }

        }

        //Metodo responsanvel por LOGAR usuario
        private void logar(String login, String password)
        {
            usuario = new Usuario();

            PoolConexoes conexao = new PoolConexoes();
            usuario = conexao.getLogin(login, password);

            if (usuario.Login != null && usuario.Senha != null)
            {
                if (usuario.Login.Equals(login) && usuario.Senha.Equals(password))
                {
                    this.Hide();

                    if (usuario.Permissao.Equals("Operacional"))
                    {
                        FormPrincipalOperacional formPrincipalOperacional = new FormPrincipalOperacional();
                        formPrincipalOperacional.CacheUsuario = usuario;
                        formPrincipalOperacional.Show();
                    }
                    else
                    {
                        FormPrincipal formPrincipal = new FormPrincipal();
                        formPrincipal.CacheUsuario = usuario;
                        formPrincipal.Show();
                    }

                }

            }
            else
            {
                MessageBox.Show("Login ou senha invalidos.");
            }           
        }
    }
}

