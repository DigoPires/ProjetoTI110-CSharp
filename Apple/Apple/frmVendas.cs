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

        private void frmVendas_Load(object sender, EventArgs e)
        {
            
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

        public void pesquisarCodVenda(int codigo)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tb_Vendas where cod_venda = @cod_venda;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();

                comm.Parameters.Add("@cod_venda", MySqlDbType.Int32).Value = codigo;

                comm.Connection = Conexao.obterConexao();

                // Carregando dados para objeto de tabela
                MySqlDataReader DR;

                DR = comm.ExecuteReader();

                ltbPesquisa.Items.Clear();

                if (DR.Read())
                {
                    ltbPesquisa.Items.Add(DR.GetString(0) + " | " + DR.GetString(1) + " | " + DR.GetString(2) + " | " + DR.GetString(3) + " | " + Convert.ToDateTime(DR.GetString(4)).ToShortDateString() + " | " + DR.GetString(5) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(6))) + " | " + DR.GetString(7) + " | " + string.Format("{0:c}", Convert.ToDouble(DR.GetString(8))));
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar os dados! Verifique o código.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar os dados! Verifique a caixa selcionada.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void pesquisarCodProd(int codigo)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tb_Vendas where cod_prod = @cod_prod;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();

                comm.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = codigo;

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
                MessageBox.Show("Não foi possível encontrar os dados! Verifique a caixa selcionada.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
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
                MessageBox.Show("Não foi possível encontrar os dados! Verifique a caixa selcionada.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }  

        public void pesquisarData(string data)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "SELECT * FROM tb_Vendas WHERE EXTRACT(YEAR FROM data_venda) = @data OR EXTRACT(MONTH FROM data_venda) = @data OR EXTRACT(DAY FROM data_venda) = @data OR data_venda = @data;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();

                comm.Parameters.Add("@data", MySqlDbType.Date).Value = Convert.ToDateTime(data);

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
                MessageBox.Show("Não foi possível encontrar os dados! Verifique a caixa selcionada.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void pesquisarGorjeta(string gorjeta)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tb_Vendas where gorjeta like @gorjeta;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();

                comm.Parameters.Add("@gorjeta", MySqlDbType.VarChar, 100).Value = '%' + gorjeta + '%';

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
                MessageBox.Show("Não foi possível encontrar os dados! Verifique a caixa selcionada.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void pesquisarValorTotal(int valor)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tb_Vendas where valor_total = @valor;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();

                comm.Parameters.Add("@valor", MySqlDbType.Int32).Value = valor;

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
                MessageBox.Show("Não foi possível encontrar os dados! Verifique a caixa selcionada.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtPesquisa.Text != "")
            {
                pesquisarDesc(txtPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Por Favor, insira algum", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
=======
            if (rdbCodVenda.Checked || rdbCodProd.Checked || rdbData.Checked || rdbDesc.Checked || rdbGorjeta.Checked || rdbValorTotal.Checked)
            {
                if (rdbCodVenda.Checked)
                {
                    try
                    {
                        pesquisarCodVenda(Convert.ToInt32(txtPesquisa.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Insira somente números!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                if (rdbCodProd.Checked)
                {
                    try
                    {
                        pesquisarCodProd(Convert.ToInt32(txtPesquisa.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Insira somente números!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                if (rdbDesc.Checked)
                {
                    pesquisarDesc(txtPesquisa.Text);
                }
                if (rdbData.Checked)
                {
                    pesquisarData(txtPesquisa.Text);
                }
                if (rdbGorjeta.Checked)
                {
                    pesquisarGorjeta(txtPesquisa.Text);
                }
                if (rdbValorTotal.Checked)
                {
                    try
                    {
                        pesquisarValorTotal(Convert.ToInt32(txtPesquisa.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Insira somente números!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma caixa antes de realizar a pesquisa!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
>>>>>>> bead5c449d840f934bc058a229d64c27a95db57e
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
