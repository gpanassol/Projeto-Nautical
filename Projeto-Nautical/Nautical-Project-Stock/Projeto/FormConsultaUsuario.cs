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
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoolConexoes conexao = new PoolConexoes();

            String matricula = textBoxMatricula.Text;
            String nome = textBoxNome.Text;

            ArrayList arrUsuario = conexao.getUsuario(matricula, nome);

            if (arrUsuario.Capacity != 0)
            {
                dataGridViewConsUsuario.DataSource = arrUsuario;
            }
            else
            {
                MessageBox.Show("Nenhum Usuario encontrado.");
            }
        }

        private void dataGridViewConsUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 1)
            {
                String a = (String)dataGridViewConsUsuario[0, e.RowIndex].Value;
            }
        }

    }
}
