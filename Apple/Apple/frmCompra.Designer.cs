
namespace Apple
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.gpbCompra = new System.Windows.Forms.GroupBox();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.lblQuantidadeEstq = new System.Windows.Forms.Label();
            this.txtQuantidadeEstq = new System.Windows.Forms.TextBox();
            this.cbbQuantidade = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorGorjeta = new System.Windows.Forms.TextBox();
            this.lblValorGorjeta = new System.Windows.Forms.Label();
            this.cbbGorjeta = new System.Windows.Forms.ComboBox();
            this.lblGorjeta = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnVerTudo = new System.Windows.Forms.Button();
            this.ltbPesquisa = new System.Windows.Forms.ListBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.gpbCompra.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSaldo.Location = new System.Drawing.Point(28, 408);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(51, 20);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSaldo.Location = new System.Drawing.Point(85, 405);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(125, 26);
            this.txtSaldo.TabIndex = 1;
            this.txtSaldo.Text = "100000";
            // 
            // gpbCompra
            // 
            this.gpbCompra.Controls.Add(this.txtNomeCli);
            this.gpbCompra.Controls.Add(this.lblNomeCli);
            this.gpbCompra.Controls.Add(this.dtpCompra);
            this.gpbCompra.Controls.Add(this.lblQuantidadeEstq);
            this.gpbCompra.Controls.Add(this.txtQuantidadeEstq);
            this.gpbCompra.Controls.Add(this.cbbQuantidade);
            this.gpbCompra.Controls.Add(this.btnCancelar);
            this.gpbCompra.Controls.Add(this.txtValorTotal);
            this.gpbCompra.Controls.Add(this.btnComprar);
            this.gpbCompra.Controls.Add(this.lblValorTotal);
            this.gpbCompra.Controls.Add(this.txtValorGorjeta);
            this.gpbCompra.Controls.Add(this.lblValorGorjeta);
            this.gpbCompra.Controls.Add(this.cbbGorjeta);
            this.gpbCompra.Controls.Add(this.lblGorjeta);
            this.gpbCompra.Controls.Add(this.txtValorUnit);
            this.gpbCompra.Controls.Add(this.lblValorUnit);
            this.gpbCompra.Controls.Add(this.lblQuantidade);
            this.gpbCompra.Controls.Add(this.txtDescricao);
            this.gpbCompra.Controls.Add(this.lblDescricao);
            this.gpbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gpbCompra.Location = new System.Drawing.Point(32, 16);
            this.gpbCompra.Name = "gpbCompra";
            this.gpbCompra.Size = new System.Drawing.Size(357, 372);
            this.gpbCompra.TabIndex = 2;
            this.gpbCompra.TabStop = false;
            this.gpbCompra.Text = "Compra";
            // 
            // dtpCompra
            // 
            this.dtpCompra.Enabled = false;
            this.dtpCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompra.Location = new System.Drawing.Point(260, 19);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(79, 20);
            this.dtpCompra.TabIndex = 39;
            // 
            // lblQuantidadeEstq
            // 
            this.lblQuantidadeEstq.AutoSize = true;
            this.lblQuantidadeEstq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblQuantidadeEstq.Location = new System.Drawing.Point(181, 141);
            this.lblQuantidadeEstq.Name = "lblQuantidadeEstq";
            this.lblQuantidadeEstq.Size = new System.Drawing.Size(158, 17);
            this.lblQuantidadeEstq.TabIndex = 38;
            this.lblQuantidadeEstq.Text = "Quantidade no Estoque";
            // 
            // txtQuantidadeEstq
            // 
            this.txtQuantidadeEstq.Enabled = false;
            this.txtQuantidadeEstq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtQuantidadeEstq.Location = new System.Drawing.Point(184, 161);
            this.txtQuantidadeEstq.Name = "txtQuantidadeEstq";
            this.txtQuantidadeEstq.Size = new System.Drawing.Size(155, 23);
            this.txtQuantidadeEstq.TabIndex = 37;
            // 
            // cbbQuantidade
            // 
            this.cbbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuantidade.FormattingEnabled = true;
            this.cbbQuantidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbQuantidade.Location = new System.Drawing.Point(32, 277);
            this.cbbQuantidade.Name = "cbbQuantidade";
            this.cbbQuantidade.Size = new System.Drawing.Size(140, 21);
            this.cbbQuantidade.TabIndex = 36;
            this.cbbQuantidade.SelectedIndexChanged += new System.EventHandler(this.cbbQuantidade_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Apple.Properties.Resources.cancel;
            this.btnCancelar.Location = new System.Drawing.Point(184, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 41);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValorTotal.Location = new System.Drawing.Point(184, 274);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(155, 23);
            this.txtValorTotal.TabIndex = 34;
            // 
            // btnComprar
            // 
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Image = global::Apple.Properties.Resources.shopping_24x;
            this.btnComprar.Location = new System.Drawing.Point(67, 313);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(105, 41);
            this.btnComprar.TabIndex = 28;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblValorTotal.Location = new System.Drawing.Point(189, 255);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(77, 17);
            this.lblValorTotal.TabIndex = 35;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // txtValorGorjeta
            // 
            this.txtValorGorjeta.Enabled = false;
            this.txtValorGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValorGorjeta.Location = new System.Drawing.Point(184, 216);
            this.txtValorGorjeta.Name = "txtValorGorjeta";
            this.txtValorGorjeta.Size = new System.Drawing.Size(155, 23);
            this.txtValorGorjeta.TabIndex = 32;
            // 
            // lblValorGorjeta
            // 
            this.lblValorGorjeta.AutoSize = true;
            this.lblValorGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblValorGorjeta.Location = new System.Drawing.Point(183, 196);
            this.lblValorGorjeta.Name = "lblValorGorjeta";
            this.lblValorGorjeta.Size = new System.Drawing.Size(112, 17);
            this.lblValorGorjeta.TabIndex = 33;
            this.lblValorGorjeta.Text = "Valor da Gorjeta";
            // 
            // cbbGorjeta
            // 
            this.cbbGorjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGorjeta.FormattingEnabled = true;
            this.cbbGorjeta.Items.AddRange(new object[] {
            "Excelente - 5%",
            "Bom - 3%",
            "Ruim - 2%",
            "Sem Gorjeta"});
            this.cbbGorjeta.Location = new System.Drawing.Point(32, 218);
            this.cbbGorjeta.Name = "cbbGorjeta";
            this.cbbGorjeta.Size = new System.Drawing.Size(140, 21);
            this.cbbGorjeta.TabIndex = 31;
            this.cbbGorjeta.SelectedIndexChanged += new System.EventHandler(this.cbbGorjeta_SelectedIndexChanged);
            // 
            // lblGorjeta
            // 
            this.lblGorjeta.AutoSize = true;
            this.lblGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblGorjeta.Location = new System.Drawing.Point(29, 197);
            this.lblGorjeta.Name = "lblGorjeta";
            this.lblGorjeta.Size = new System.Drawing.Size(55, 17);
            this.lblGorjeta.TabIndex = 30;
            this.lblGorjeta.Text = "Gorjeta";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Enabled = false;
            this.txtValorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValorUnit.Location = new System.Drawing.Point(32, 161);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(140, 23);
            this.txtValorUnit.TabIndex = 26;
            this.txtValorUnit.TextChanged += new System.EventHandler(this.txtValorUnit_TextChanged);
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblValorUnit.Location = new System.Drawing.Point(29, 141);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(94, 17);
            this.lblValorUnit.TabIndex = 29;
            this.lblValorUnit.Text = "Valor Unitário";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblQuantidade.Location = new System.Drawing.Point(26, 257);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 17);
            this.lblQuantidade.TabIndex = 28;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDescricao.Location = new System.Drawing.Point(32, 100);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(307, 23);
            this.txtDescricao.TabIndex = 24;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDescricao.Location = new System.Drawing.Point(29, 80);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 27;
            this.lblDescricao.Text = "Descrição";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.btnVerTudo);
            this.gpbPesquisa.Controls.Add(this.ltbPesquisa);
            this.gpbPesquisa.Controls.Add(this.txtPesquisa);
            this.gpbPesquisa.Controls.Add(this.btnPesquisar);
            this.gpbPesquisa.Controls.Add(this.lblPesquisa);
            this.gpbPesquisa.Location = new System.Drawing.Point(419, 16);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(358, 372);
            this.gpbPesquisa.TabIndex = 24;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // btnVerTudo
            // 
            this.btnVerTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTudo.Image = global::Apple.Properties.Resources.see_24x;
            this.btnVerTudo.Location = new System.Drawing.Point(190, 313);
            this.btnVerTudo.Name = "btnVerTudo";
            this.btnVerTudo.Size = new System.Drawing.Size(105, 41);
            this.btnVerTudo.TabIndex = 27;
            this.btnVerTudo.Text = "&Ver Tudo";
            this.btnVerTudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTudo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerTudo.UseVisualStyleBackColor = true;
            this.btnVerTudo.Click += new System.EventHandler(this.btnVerTudo_Click);
            // 
            // ltbPesquisa
            // 
            this.ltbPesquisa.FormattingEnabled = true;
            this.ltbPesquisa.Location = new System.Drawing.Point(34, 119);
            this.ltbPesquisa.Name = "ltbPesquisa";
            this.ltbPesquisa.Size = new System.Drawing.Size(292, 186);
            this.ltbPesquisa.TabIndex = 26;
            this.ltbPesquisa.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisa_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPesquisa.Location = new System.Drawing.Point(34, 77);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(292, 23);
            this.txtPesquisa.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Apple.Properties.Resources.search_24x;
            this.btnPesquisar.Location = new System.Drawing.Point(73, 313);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 41);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPesquisa.Location = new System.Drawing.Point(103, 57);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(151, 17);
            this.lblPesquisa.TabIndex = 14;
            this.lblPesquisa.Text = "Pesquise pelo Produto";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::Apple.Properties.Resources.back_24x;
            this.btnVoltar.Location = new System.Drawing.Point(672, 399);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 41);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNomeCli.Location = new System.Drawing.Point(32, 51);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(307, 23);
            this.txtNomeCli.TabIndex = 40;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNomeCli.Location = new System.Drawing.Point(29, 31);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(112, 17);
            this.lblNomeCli.TabIndex = 41;
            this.lblNomeCli.Text = "Nome do Cliente";
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbCompra);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.gpbCompra.ResumeLayout(false);
            this.gpbCompra.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox gpbCompra;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button btnVerTudo;
        private System.Windows.Forms.ListBox ltbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblGorjeta;
        private System.Windows.Forms.TextBox txtValorGorjeta;
        private System.Windows.Forms.Label lblValorGorjeta;
        private System.Windows.Forms.ComboBox cbbGorjeta;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ComboBox cbbQuantidade;
        private System.Windows.Forms.Label lblQuantidadeEstq;
        private System.Windows.Forms.TextBox txtQuantidadeEstq;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblNomeCli;
    }
}