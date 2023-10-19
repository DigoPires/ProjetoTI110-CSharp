using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apple
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            desabilitarCampos();

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;
        }
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            dtpDataEntrada.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;

            rdbCodigo.Enabled = false;
            rdbDescricao.Enabled = false;
            txtPesquisa.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = false;
        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = true;
            dtpDataEntrada.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;

            rdbCodigo.Enabled = true;
            rdbDescricao.Enabled = true;
            txtPesquisa.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = true;
        }
    }
}
