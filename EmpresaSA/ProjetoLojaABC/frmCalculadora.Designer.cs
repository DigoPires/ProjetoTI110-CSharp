
namespace ProjetoLojaABC
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.rdbDivi = new System.Windows.Forms.RadioButton();
            this.rdbMult = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbAdi = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblSairResult = new System.Windows.Forms.Label();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum1.Location = new System.Drawing.Point(129, 70);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(53, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum2.Location = new System.Drawing.Point(129, 136);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(53, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Número 2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(637, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";
            // 
            // gpbOperador
            // 
            this.gpbOperador.Controls.Add(this.rdbDivi);
            this.gpbOperador.Controls.Add(this.rdbMult);
            this.gpbOperador.Controls.Add(this.rdbSub);
            this.gpbOperador.Controls.Add(this.rdbAdi);
            this.gpbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbOperador.Location = new System.Drawing.Point(340, 70);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Padding = new System.Windows.Forms.Padding(25, 25, 7, 7);
            this.gpbOperador.Size = new System.Drawing.Size(168, 154);
            this.gpbOperador.TabIndex = 2;
            this.gpbOperador.TabStop = false;
            this.gpbOperador.Text = "Operador";
            // 
            // rdbDivi
            // 
            this.rdbDivi.AutoSize = true;
            this.rdbDivi.Location = new System.Drawing.Point(21, 103);
            this.rdbDivi.Name = "rdbDivi";
            this.rdbDivi.Size = new System.Drawing.Size(86, 21);
            this.rdbDivi.TabIndex = 5;
            this.rdbDivi.TabStop = true;
            this.rdbDivi.Text = "Divisão(:)";
            this.rdbDivi.UseVisualStyleBackColor = true;
            // 
            // rdbMult
            // 
            this.rdbMult.AutoSize = true;
            this.rdbMult.Location = new System.Drawing.Point(21, 80);
            this.rdbMult.Name = "rdbMult";
            this.rdbMult.Size = new System.Drawing.Size(123, 21);
            this.rdbMult.TabIndex = 4;
            this.rdbMult.TabStop = true;
            this.rdbMult.Text = "Multiplicação(x)";
            this.rdbMult.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(21, 57);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(106, 21);
            this.rdbSub.TabIndex = 3;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "Subtração(-)";
            this.rdbSub.UseVisualStyleBackColor = true;
            // 
            // rdbAdi
            // 
            this.rdbAdi.AutoSize = true;
            this.rdbAdi.Location = new System.Drawing.Point(21, 34);
            this.rdbAdi.Name = "rdbAdi";
            this.rdbAdi.Size = new System.Drawing.Size(87, 21);
            this.rdbAdi.TabIndex = 2;
            this.rdbAdi.TabStop = true;
            this.rdbAdi.Text = "Adição(+)";
            this.rdbAdi.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(650, 169);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(98, 50);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnLimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimp.Location = new System.Drawing.Point(650, 225);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(98, 51);
            this.btnLimp.TabIndex = 4;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = false;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(598, 369);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(163, 58);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNum1.Location = new System.Drawing.Point(132, 93);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNum2.Location = new System.Drawing.Point(132, 160);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // lblSairResult
            // 
            this.lblSairResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblSairResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSairResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSairResult.Location = new System.Drawing.Point(640, 93);
            this.lblSairResult.Name = "lblSairResult";
            this.lblSairResult.Size = new System.Drawing.Size(121, 43);
            this.lblSairResult.TabIndex = 9;
            this.lblSairResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSairResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gpbOperador);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.RadioButton rdbDivi;
        private System.Windows.Forms.RadioButton rdbMult;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAdi;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblSairResult;
    }
}