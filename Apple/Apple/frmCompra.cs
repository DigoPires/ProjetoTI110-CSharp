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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        public void pesquisarDesc(string descricao)
        {
            if (txtPesquisa.Text.Equals(""))
            {
                MessageBox.Show("Por Favor, insira algo para pesquisar.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    MySqlCommand comm = new MySqlCommand();
                    comm.CommandText = "select * from tb_Produtos where descricao like @descricao;";
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
                        ltbPesquisa.Items.Add(DR.GetString(1));
                        while (DR.Read())
                        {
                            ltbPesquisa.Items.Add(DR.GetString(1));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não existe dados com este nome!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    Conexao.fecharConexao();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível encontrar os dados!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        public void verTudo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tb_Produtos";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbPesquisa.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisa.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }

        public void carregarItens(string desc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tb_Produtos where descricao like @descricao;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = '%' + desc + '%';

            comm.Connection = Conexao.obterConexao();

            // Carregando dados para objeto de tabela
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            txtDescricao.Text = DR.GetString(1).ToString();
            txtValorUnit.Text = DR.GetString(4).ToString();

            Conexao.fecharConexao();
        }

        public int quantidade()
        {
            int result = 1;

            switch (cbbQuantidade.Text)
            {
                case "1":
                    result = 1;
                    break;
                case "2":
                    result = 2;
                    break;
                case "3":
                    result = 3;
                    break;
                case "4":
                    result = 4;
                    break;
                case "5":
                    result = 5;
                    break;
                case "6":
                    result = 6;
                    break;
                case "7":
                    result = 7;
                    break;
                case "8":
                    result = 8;
                    break;
                case "9":
                    result = 9;
                    break;
                case "10":
                    result = 10;
                    break;
                default:
                    break;
            }

            return result;
        }

        public void calcularTotal(double gorjeta)
        {
            double valorTotal, valorSemiTotal, valorGorjeta, valorUnit, quant;
            valorUnit = Convert.ToDouble(txtValorUnit.Text);
            quant = quantidade();

            valorSemiTotal = valorUnit * quant;

            valorGorjeta = valorSemiTotal * (gorjeta / 100);

            valorTotal = valorSemiTotal + valorGorjeta;

            txtValorGorjeta.Text = valorGorjeta.ToString();

            txtValorTotal.Text = valorTotal.ToString();
        }

        public void avaliacaoGorjeta()
        {
            switch (cbbGorjeta.Text)
            {
                case "Excelente - 3%":
                    calcularTotal(3);
                    break;
                case "Bom - 2%":
                    calcularTotal(2);
                    break;
                case "Ruim - 1%":
                    calcularTotal(1);
                    break;
                default:
                    break;
            }
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            string.Format("{0:n}", Convert.ToDouble(txtSaldo.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtValorTotal.Text = txtValorGorjeta.Text;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnVerTudo_Click(object sender, EventArgs e)
        {
            verTudo();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarDesc(txtPesquisa.Text);
        }

        private void ltbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisa.SelectedItem != null)
            {
                string desc = ltbPesquisa.SelectedItem.ToString();
                carregarItens(desc);
                cbbQuantidade.Text = "1";
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado! Favor selecionar um item.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cbbGorjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            avaliacaoGorjeta();
        }

        private void cbbQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            avaliacaoGorjeta();
        }
    }
}
