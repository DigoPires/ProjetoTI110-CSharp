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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            desabilitarCamposLoad();
        }

        public void desabilitarCamposLoad()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            dtpDataEntrada.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnNovo.Enabled = true;
        }
        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = true;
            dtpDataEntrada.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnNovo.Enabled = false;

            txtDescricao.Focus();
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            dtpDataEntrada.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnNovo.Enabled = false;
        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = true;
            dtpDataEntrada.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnNovo.Enabled = true;
        }

        public void habilitarCamposPesquisa()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = true;
            dtpDataEntrada.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnNovo.Enabled = false;

            txtDescricao.Focus();
        }

        public void carregarCod()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select cod_prod+1 from tb_Produtos order by cod_prod desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetString(0));

            Conexao.fecharConexao();
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();

            rdbCodigo.Checked = false;
            rdbDescricao.Checked = false;
            txtPesquisa.Clear();
            ltbPesquisa.Items.Clear();
        }

        public void limparPesquisa()
        {
            rdbCodigo.Checked = false;
            rdbDescricao.Checked = false;
            txtPesquisa.Clear();
            ltbPesquisa.Items.Clear();
        }

        public void pesquisarCod(int codigo)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tb_Produtos where cod_prod = @cod_prod;";
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
                    ltbPesquisa.Items.Add(DR.GetString(1));
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
        public void pesquisarDesc(string descricao)
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
                    MessageBox.Show("Não existe dados com está descrição!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar os dados! Verifique a caixa selcionada.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
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

            txtCodigo.Text = DR.GetString(0).ToString();
            txtDescricao.Text = DR.GetString(1).ToString();
            dtpDataEntrada.Text = DR.GetString(2).ToString();
            txtQuantidade.Text = DR.GetString(3).ToString();
            txtValor.Text = DR.GetString(4).ToString();

            Conexao.fecharConexao();
        }


        public int cadastrarProdutos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tb_Produtos(descricao,data_Entrada,quantidade,valor) values(@descricao,@data_Entrada,@quantidade,@valor);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;
            comm.Parameters.Add("@data_Entrada", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataEntrada.Text);
            comm.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = txtQuantidade.Text;
            comm.Parameters.Add("@valor", MySqlDbType.Decimal).Value = txtValor.Text;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        public int alterarProduto(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tb_Produtos set descricao = @descricao, data_Entrada = @data_Entrada, quantidade = @quantidade, valor = @valor where cod_prod = @cod_prod;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = codigo;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;
            comm.Parameters.Add("@data_Entrada", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataEntrada.Text);
            comm.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = txtQuantidade.Text;
            comm.Parameters.Add("@valor", MySqlDbType.Decimal).Value = txtValor.Text;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        public int excluirProdutos(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tb_Produtos where cod_prod = @cod_prod;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@cod_prod", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            Conexao.fecharConexao();

            return res;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
            limparCampos();
            carregarCod();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.Text = string.Format("{0:C}", txtValor.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                pesquisarCod(Convert.ToInt32(txtPesquisa.Text));
            }

            if (rdbDescricao.Checked)
            {
                pesquisarDesc(txtPesquisa.Text);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Equals("") || dtpDataEntrada.Text.Equals("") || txtQuantidade.Text.Equals("") || txtValor.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (cadastrarProdutos() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCamposLoad();
                }
                else
                {
                    MessageBox.Show("Erro ao concluir o cadastro!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void ltbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisa.SelectedItem != null)
            {
                string desc = ltbPesquisa.SelectedItem.ToString();
                carregarItens(desc);
                limparPesquisa();
                habilitarCamposPesquisa();
                btnNovo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado! Favor selecionar um item.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            if (btnNovo.Enabled == false)
            {
                carregarCod();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarProduto(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
                desabilitarCamposLoad();
            }
            else
            {
                MessageBox.Show("Erro ao alterar informações!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (excluirProdutos(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                DialogResult res = MessageBox.Show("Deseja realmente excluir?", "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Excluído com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCamposLoad();
                }
            }
            else
            {
                MessageBox.Show("Erro ao exlcuir os dados!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;
        }

        private void rdbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;
        }
    }
}
