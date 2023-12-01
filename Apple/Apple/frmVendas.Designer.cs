
namespace Apple
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.btnVerTudo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTabelaVendas = new System.Windows.Forms.Label();
            this.ltbPesquisa = new System.Windows.Forms.ListBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.rdbCodVenda = new System.Windows.Forms.RadioButton();
            this.rdbCodProd = new System.Windows.Forms.RadioButton();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.rdbGorjeta = new System.Windows.Forms.RadioButton();
            this.rdbValorTotal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnVerTudo
            // 
            this.btnVerTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTudo.Image = global::Apple.Properties.Resources.see_24x;
            this.btnVerTudo.Location = new System.Drawing.Point(410, 392);
            this.btnVerTudo.Name = "btnVerTudo";
            this.btnVerTudo.Size = new System.Drawing.Size(161, 41);
            this.btnVerTudo.TabIndex = 29;
            this.btnVerTudo.Text = "&Ver Todas as Vendas";
            this.btnVerTudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTudo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerTudo.UseVisualStyleBackColor = true;
            this.btnVerTudo.Click += new System.EventHandler(this.btnVerTudo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Apple.Properties.Resources.search_24x;
            this.btnPesquisar.Location = new System.Drawing.Point(231, 392);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(161, 41);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::Apple.Properties.Resources.back_24x;
            this.btnVoltar.Location = new System.Drawing.Point(683, 392);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 41);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTabelaVendas
            // 
            this.lblTabelaVendas.AutoSize = true;
            this.lblTabelaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblTabelaVendas.Location = new System.Drawing.Point(297, 30);
            this.lblTabelaVendas.Name = "lblTabelaVendas";
            this.lblTabelaVendas.Size = new System.Drawing.Size(187, 26);
            this.lblTabelaVendas.TabIndex = 32;
            this.lblTabelaVendas.Text = "Tabela de Vendas";
            // 
            // ltbPesquisa
            // 
            this.ltbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ltbPesquisa.FormattingEnabled = true;
            this.ltbPesquisa.ItemHeight = 17;
            this.ltbPesquisa.Location = new System.Drawing.Point(74, 178);
            this.ltbPesquisa.Name = "ltbPesquisa";
            this.ltbPesquisa.Size = new System.Drawing.Size(653, 208);
            this.ltbPesquisa.TabIndex = 34;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPesquisa.Location = new System.Drawing.Point(74, 139);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(653, 26);
            this.txtPesquisa.TabIndex = 33;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPesquisar.Location = new System.Drawing.Point(71, 119);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(71, 17);
            this.lblPesquisar.TabIndex = 35;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // rdbCodVenda
            // 
            this.rdbCodVenda.AutoSize = true;
            this.rdbCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbCodVenda.Location = new System.Drawing.Point(74, 89);
            this.rdbCodVenda.Name = "rdbCodVenda";
            this.rdbCodVenda.Size = new System.Drawing.Size(135, 21);
            this.rdbCodVenda.TabIndex = 36;
            this.rdbCodVenda.TabStop = true;
            this.rdbCodVenda.Text = "Código da Venda";
            this.rdbCodVenda.UseVisualStyleBackColor = true;
            // 
            // rdbCodProd
            // 
            this.rdbCodProd.AutoSize = true;
            this.rdbCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbCodProd.Location = new System.Drawing.Point(221, 89);
            this.rdbCodProd.Name = "rdbCodProd";
            this.rdbCodProd.Size = new System.Drawing.Size(144, 21);
            this.rdbCodProd.TabIndex = 37;
            this.rdbCodProd.TabStop = true;
            this.rdbCodProd.Text = "Código do Produto";
            this.rdbCodProd.UseVisualStyleBackColor = true;
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbDesc.Location = new System.Drawing.Point(376, 89);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(89, 21);
            this.rdbDesc.TabIndex = 38;
            this.rdbDesc.TabStop = true;
            this.rdbDesc.Text = "Descrição";
            this.rdbDesc.UseVisualStyleBackColor = true;
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbData.Location = new System.Drawing.Point(477, 89);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(56, 21);
            this.rdbData.TabIndex = 39;
            this.rdbData.TabStop = true;
            this.rdbData.Text = "Data";
            this.rdbData.UseVisualStyleBackColor = true;
            // 
            // rdbGorjeta
            // 
            this.rdbGorjeta.AutoSize = true;
            this.rdbGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbGorjeta.Location = new System.Drawing.Point(545, 89);
            this.rdbGorjeta.Name = "rdbGorjeta";
            this.rdbGorjeta.Size = new System.Drawing.Size(73, 21);
            this.rdbGorjeta.TabIndex = 40;
            this.rdbGorjeta.TabStop = true;
            this.rdbGorjeta.Text = "Gorjeta";
            this.rdbGorjeta.UseVisualStyleBackColor = true;
            // 
            // rdbValorTotal
            // 
            this.rdbValorTotal.AutoSize = true;
            this.rdbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbValorTotal.Location = new System.Drawing.Point(632, 89);
            this.rdbValorTotal.Name = "rdbValorTotal";
            this.rdbValorTotal.Size = new System.Drawing.Size(95, 21);
            this.rdbValorTotal.TabIndex = 41;
            this.rdbValorTotal.TabStop = true;
            this.rdbValorTotal.Text = "Valor Total";
            this.rdbValorTotal.UseVisualStyleBackColor = true;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbValorTotal);
            this.Controls.Add(this.rdbGorjeta);
            this.Controls.Add(this.rdbData);
            this.Controls.Add(this.rdbDesc);
            this.Controls.Add(this.rdbCodProd);
            this.Controls.Add(this.rdbCodVenda);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.ltbPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTabelaVendas);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVerTudo);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerTudo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTabelaVendas;
        private System.Windows.Forms.ListBox ltbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.RadioButton rdbCodVenda;
        private System.Windows.Forms.RadioButton rdbCodProd;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.RadioButton rdbGorjeta;
        private System.Windows.Forms.RadioButton rdbValorTotal;
    }
}