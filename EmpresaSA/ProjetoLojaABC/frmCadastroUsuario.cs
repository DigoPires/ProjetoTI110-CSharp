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
    public partial class frmCadastroUsuario : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();

            txtCodFunc.Clear();
            ltbFuncSemUsu.Items.Clear();
        }

        public int cadastrarUsuario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tb_Usuarios (usuario,senha,cod_Func)values('@usuario','@senha',@cod_Func);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtRepetirSenha.Text;
            comm.Parameters.Add("@cod_Func", MySqlDbType.Int32).Value = codFunc;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        public void carregarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tb_Funcionarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbFuncSemUsu.Items.Clear();

            while (DR.Read())
            {
                ltbFuncSemUsu.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }

        public void carregarUsuarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.usuario, usu.senha, func.cod_func from tb_Funcionarios as func inner join tb_Usuarios as usu on func.cod_func = usu.cod_func where func.nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            try
            {
                txtNome.Text = DR.GetString(0);
                txtSenha.Text = DR.GetString(1);

                txtCodFunc.Text = DR.GetInt32(2).ToString();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Funcionário não possui usuário.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                
                // Carregar o código do funcionário

                txtNome.Clear();
                txtSenha.Clear();
                txtCodigo.Clear();
            }

            Conexao.fecharConexao();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            carregarFuncionarios();
        }

        private void ltbFuncSemUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbFuncSemUsu.SelectedItem != null)
            {
                string nome = ltbFuncSemUsu.SelectedItem.ToString();
                carregarUsuarios(nome);

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado! Favor selecionar um item.", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCodFunc.Text = "Oi";
                txtNome.Clear();
                txtSenha.Clear();
                txtCodigo.Clear();
                txtNome.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtSenha.Text.Equals("") || txtRepetirSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher todos os campos!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (txtSenha.Text.Equals(txtRepetirSenha.Text))
                {
                    if (cadastrarUsuario(Convert.ToInt32(txtCodFunc.Text)) == 1)
                    {
                        MessageBox.Show("Cadastrado com Sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Erro a cadastrar!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Senha não confere!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtSenha.Clear();
                    txtRepetirSenha.Clear();
                    txtSenha.Focus();
                }
            }
        }
    }
}
