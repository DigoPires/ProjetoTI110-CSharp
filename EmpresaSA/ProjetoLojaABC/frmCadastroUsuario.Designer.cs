
namespace ProjetoLojaABC
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbFuncionarios = new System.Windows.Forms.GroupBox();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.ltbFuncSemUsu = new System.Windows.Forms.ListBox();
            this.lblFuncSemUsu = new System.Windows.Forms.Label();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlCRUD.SuspendLayout();
            this.gpbFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnEcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(0, 502);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(784, 59);
            this.pnlCRUD.TabIndex = 13;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(669, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 41);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(558, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 41);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(446, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 41);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnEcluir
            // 
            this.btnEcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnEcluir.Image")));
            this.btnEcluir.Location = new System.Drawing.Point(335, 9);
            this.btnEcluir.Name = "btnEcluir";
            this.btnEcluir.Size = new System.Drawing.Size(105, 41);
            this.btnEcluir.TabIndex = 16;
            this.btnEcluir.Text = "&Excluir";
            this.btnEcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(226, 9);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 41);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(117, 9);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 41);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(6, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 41);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.Controls.Add(this.txtCodFunc);
            this.gpbFuncionarios.Controls.Add(this.lblCodFunc);
            this.gpbFuncionarios.Controls.Add(this.ltbFuncSemUsu);
            this.gpbFuncionarios.Controls.Add(this.lblFuncSemUsu);
            this.gpbFuncionarios.Controls.Add(this.txtRepetirSenha);
            this.gpbFuncionarios.Controls.Add(this.lblSenha);
            this.gpbFuncionarios.Controls.Add(this.txtSenha);
            this.gpbFuncionarios.Controls.Add(this.lblRepetirSenha);
            this.gpbFuncionarios.Controls.Add(this.txtNome);
            this.gpbFuncionarios.Controls.Add(this.lblUsuario);
            this.gpbFuncionarios.Controls.Add(this.txtCodigo);
            this.gpbFuncionarios.Controls.Add(this.lblCodigo);
            this.gpbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFuncionarios.Location = new System.Drawing.Point(16, 35);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(753, 449);
            this.gpbFuncionarios.TabIndex = 14;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Dados";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Enabled = false;
            this.txtCodFunc.Location = new System.Drawing.Point(604, 358);
            this.txtCodFunc.MaxLength = 5;
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(68, 24);
            this.txtCodFunc.TabIndex = 14;
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCodFunc.Location = new System.Drawing.Point(475, 363);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(125, 16);
            this.lblCodFunc.TabIndex = 13;
            this.lblCodFunc.Text = "Código Funcionário";
            // 
            // ltbFuncSemUsu
            // 
            this.ltbFuncSemUsu.FormattingEnabled = true;
            this.ltbFuncSemUsu.ItemHeight = 18;
            this.ltbFuncSemUsu.Location = new System.Drawing.Point(478, 111);
            this.ltbFuncSemUsu.Name = "ltbFuncSemUsu";
            this.ltbFuncSemUsu.Size = new System.Drawing.Size(203, 238);
            this.ltbFuncSemUsu.TabIndex = 12;
            this.ltbFuncSemUsu.SelectedIndexChanged += new System.EventHandler(this.ltbFuncSemUsu_SelectedIndexChanged);
            // 
            // lblFuncSemUsu
            // 
            this.lblFuncSemUsu.AutoSize = true;
            this.lblFuncSemUsu.Location = new System.Drawing.Point(489, 81);
            this.lblFuncSemUsu.Name = "lblFuncSemUsu";
            this.lblFuncSemUsu.Size = new System.Drawing.Size(183, 18);
            this.lblFuncSemUsu.TabIndex = 11;
            this.lblFuncSemUsu.Text = "Funcionários sem Usuário";
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Location = new System.Drawing.Point(138, 316);
            this.txtRepetirSenha.MaxLength = 100;
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.Size = new System.Drawing.Size(183, 24);
            this.txtRepetirSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(82, 234);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(138, 231);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(183, 24);
            this.txtSenha.TabIndex = 3;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Location = new System.Drawing.Point(31, 319);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(101, 18);
            this.lblRepetirSenha.TabIndex = 8;
            this.lblRepetirSenha.Text = "Repetir Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 159);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 24);
            this.txtNome.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(72, 162);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(138, 78);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(76, 81);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbFuncionarios);
            this.Controls.Add(this.pnlCRUD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroUsuario";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.pnlCRUD.ResumeLayout(false);
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFuncSemUsu;
        private System.Windows.Forms.ListBox ltbFuncSemUsu;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label lblCodFunc;
    }
}