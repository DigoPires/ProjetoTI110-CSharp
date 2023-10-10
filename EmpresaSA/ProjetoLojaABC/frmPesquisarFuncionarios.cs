using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmPesquisarFuncionarios : Form
    {
        // Desabilitar Campos
        public void desabilitarCampos()
        {
            txtDescricao.Enabled = false;

            rdbCodigo.Checked = false;
            rdbNome.Checked = false;

            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        // Habilitar Campos
        public void habilitarCampos()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;

            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        // Limpar Campos
        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Focus();
            ltbPesquisar.Items.Clear();
        }

        // Pesquisar por código
        public void pesquisarCod(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tb_Funcionarios where cod_func = @cod_func;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@cod_func", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();

            // Carregando dados para objeto de tabela
            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Clear();

            ltbPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }

        // Pesquisar por nome
        public void pesquisarNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tb_Funcionarios where nome like @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = '%' +  nome + '%';

            comm.Connection = Conexao.obterConexao();

            // Carregando dados para objeto de tabela
            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            ltbPesquisar.Items.Clear();

            while (DR.Read())
            { 
                ltbPesquisar.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }

        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                pesquisarCod(Convert.ToInt32(txtDescricao.Text));
            }

            if (rdbNome.Checked)
            {
                pesquisarNome(txtDescricao.Text);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisar.SelectedItem != null)
            {
                string nome = ltbPesquisar.SelectedItem.ToString();
                frmFuncionarios abrir = new frmFuncionarios(nome);
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado! Favor selecionar um item.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.Show();
            this.Hide();
        }
    }
}
