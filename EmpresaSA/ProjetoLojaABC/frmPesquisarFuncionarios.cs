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

namespace ProjetoLojaABC
{
    public partial class frmPesquisarFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

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

        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
        
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Clear();
            ltbPesquisar.Items.Add(txtDescricao.Text);
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
    }
}
