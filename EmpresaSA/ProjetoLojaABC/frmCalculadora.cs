﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaABC
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //string txt1, txt2;
            //txt1 = txtNum1.Text;
            //txt2 = txtNum2.Text;

            //double.TryParse(txt1, out double num1);
            //double.TryParse(txt2, out double num2);

            double num1, num2, result = 0;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            if (rdbAdi.Checked)
            {
                result = (num1 + num2);
            }
            if (rdbSub.Checked)
            {
                result = (num1 - num2);
            }
            if (rdbMult.Checked)
            {
                result = (num1 * num2);
            }
            if (rdbDivi.Checked)
            {
                if(num2 == 0)
                {
                    MessageBox.Show("IMPOSSÍVEL DIVIDIR POR 0", "Mensagem do Sistema", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
                else
                {
                    result = (num1 / num2);
                }
            }

            lblSairResult.Text = result.ToString();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
            rdbAdi.Checked = false;
            rdbSub.Checked = false;
            rdbMult.Checked = false;
            rdbDivi.Checked = false;
            lblSairResult.Text = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Declarando variável para receber o valor do Botão
            DialogResult result = MessageBox.Show("Deseja Sair?", "Messagem do Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
