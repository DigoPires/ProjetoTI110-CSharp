using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Apple
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        public void verTudo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tb_Vendas;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbPesquisa.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisa.Items.Add(DR.GetString(0) + " | " + DR.GetString(1) + " | " + DR.GetString(2) + " | " + DR.GetString(3) + " | " + Convert.ToDateTime(DR.GetString(4)).ToShortDateString() + " | " + DR.GetString(5) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(6))) + " | " + DR.GetString(7) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(8))));
            }

            Conexao.fecharConexao();
        }

        public void pesquisarDesc(string descricao)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tb_Vendas where descricao like @descricao;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();

                comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = '%' + descricao + '%';

                comm.Connection = Conexao.obterConexao();

                // Carregando dados para objeto de tabela
                MySqlDataReader DR;

                DR = comm.ExecuteReader();

                ltbPesquisa.Items.Clear();

                if (DR.Read())
                {
                    ltbPesquisa.Items.Add(DR.GetString(0) + " | " + DR.GetString(1) + " | " + DR.GetString(2) + " | " + DR.GetString(3) + " | " + Convert.ToDateTime(DR.GetString(4)).ToShortDateString() + " | " + DR.GetString(5) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(6))) + " | " + DR.GetString(7) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(8))));
                    while (DR.Read())
                    {
                        ltbPesquisa.Items.Add(DR.GetString(0) + " | " + DR.GetString(1) + " | " + DR.GetString(2) + " | " + DR.GetString(3) + " | " + Convert.ToDateTime(DR.GetString(4)).ToShortDateString() + " | " + DR.GetString(5) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(6))) + " | " + DR.GetString(7) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(8))));
                    }
                }
                else
                {
                    MessageBox.Show("Não existe dados com está descrição!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar os dados!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                pesquisarDesc(txtPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Por Favor, insira algum", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnVerTudo_Click(object sender, EventArgs e)
        {
            verTudo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEstoque abrir = new frmEstoque();
            abrir.Show();
            this.Hide();
        }
    }
}
