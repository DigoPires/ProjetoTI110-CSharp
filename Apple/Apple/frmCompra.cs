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

        public int codigoProd = 0;

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

        public void limparCampos()
        {
            txtNomeCli.Clear();
            txtDescricao.Clear();
            txtQuantidadeEstq.Clear();
            txtValorUnit.Clear();
            txtValorGorjeta.Clear();
            txtValorTotal.Clear();

            cbbGorjeta.Text = "";
            cbbQuantidade.Text = "";

            txtPesquisa.Clear();
            ltbPesquisa.Items.Clear();
        }

        public void desabilitarCompra()
        {
            txtNomeCli.Enabled = false;

            cbbGorjeta.Enabled = false;
            cbbQuantidade.Enabled = false;

            btnComprar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public void habilitarCompra()
        {
            txtNomeCli.Enabled = true;

            cbbGorjeta.Enabled = true;
            cbbQuantidade.Enabled = true;

            btnComprar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public bool verificarCompra()
        {
            double saldo, total;

            saldo = Convert.ToDouble(txtSaldo.Text);
            total = Convert.ToDouble(txtValorTotal.Text);
            if (saldo > total)
            {
                double quant, quantEstoq;
                quantEstoq = Convert.ToDouble(txtQuantidadeEstq.Text);
                quant = Convert.ToDouble(cbbQuantidade.Text);

                if (quantEstoq >= quant)
                {
                    return true;
                }

                MessageBox.Show("Quantidade insuficiente!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            MessageBox.Show("Saldo insuficiente para encerrar a compra!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return false;
        }

        public void registrarVenda()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tb_Vendas(cod_prod,nome_cli,descricao,data_venda,gorjeta,valor_gorjeta,quantidade,valor_total) values(@cod_prod,@nome_cli,@descricao,@data_venda,@gorjeta,@valor_gorjeta,@quantidade,@valor_total);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = codigoProd;
            comm.Parameters.Add("@nome_cli", MySqlDbType.VarChar, 100).Value = txtNomeCli.Text;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;
            comm.Parameters.Add("@data_venda", MySqlDbType.Date).Value = Convert.ToDateTime(dtpCompra.Text);
            comm.Parameters.Add("@gorjeta", MySqlDbType.VarChar, 50).Value = cbbGorjeta.Text;
            comm.Parameters.Add("@valor_gorjeta", MySqlDbType.Decimal).Value = Convert.ToDouble(txtValorGorjeta.Text);
            comm.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = cbbQuantidade.Text;
            comm.Parameters.Add("@valor_total", MySqlDbType.Decimal).Value = txtValorTotal.Text;

            comm.Connection = Conexao.obterConexao();

            comm.ExecuteNonQuery();

            Conexao.fecharConexao();
        }

        public void calcularNovoSaldo()
        {
            double res, saldo, total;

            saldo = Convert.ToDouble(txtSaldo.Text);
            total = Convert.ToDouble(txtValorTotal.Text);

            res = saldo - total;

            txtSaldo.Text = string.Format("{0:n}", res);
        }

        public void alterarQuantidade(double quant, double quantEstoq)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tb_produtos set quantidade = @quant where descricao like @desc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@desc", MySqlDbType.VarChar, 100).Value = '%' + txtDescricao.Text + '%';
            comm.Parameters.Add("@quant", MySqlDbType.Decimal).Value = (quantEstoq - quant);

            comm.Connection = Conexao.obterConexao();

            comm.ExecuteNonQuery();

            Conexao.fecharConexao();
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
                if (Convert.ToDouble(DR.GetString(3)) > 0)
                {
                    ltbPesquisa.Items.Add(DR.GetString(1));
                }
            }

            Conexao.fecharConexao();
        }

        public void carregarItens(string desc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tb_Produtos where descricao like @descricao;"; //select quantidade from tb_Produtos where descricao like;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = '%' + desc + '%';

            comm.Connection = Conexao.obterConexao();

            // Carregando dados para objeto de tabela
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            codigoProd = Convert.ToInt32(DR.GetString(0));

            txtDescricao.Text = DR.GetString(1).ToString();
            txtQuantidadeEstq.Text = DR.GetString(3).ToString();
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
                case "Excelente - 5%":
                    calcularTotal(5);
                    break;
                case "Bom - 3%":
                    calcularTotal(3);
                    break;
                case "Ruim - 2%":
                    calcularTotal(2);
                    break;
                case "Sem Gorjeta":
                    calcularTotal(0);
                    break;
                default:
                    break;
            }
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            txtSaldo.Text = string.Format("{0:n}", Convert.ToDouble(txtSaldo.Text));
            txtPesquisa.Focus();
            desabilitarCompra();
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
                habilitarCompra();
                cbbQuantidade.Text = "1";
                cbbGorjeta.Text = "Sem Gorjeta";
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado! Favor selecionar um item.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cbbGorjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGorjeta.Text != "")
            {
                avaliacaoGorjeta();
            }
        }

        private void cbbQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbQuantidade.Text != "")
            {
                avaliacaoGorjeta();
            }
        }

        private void txtValorUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtValorUnit.Text != "")
            {
                avaliacaoGorjeta();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text != "")
            {
                if (verificarCompra())
                {
                    DialogResult res = MessageBox.Show("Deseja encerrar a compra no valor de: " + string.Format("{0:c}", Convert.ToDouble(txtValorTotal.Text)), "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Compra bem-sucedida! Obrigado pela preferência.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        desabilitarCompra();
                        calcularNovoSaldo();
                        alterarQuantidade(Convert.ToDouble(cbbQuantidade.Text), Convert.ToDouble(txtQuantidadeEstq.Text));
                        registrarVenda();
                        limparCampos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira seu nome!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja cancelar sua compra?", "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Compra cancelada!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCompra();
                limparCampos();
            }
        }

    }
}
