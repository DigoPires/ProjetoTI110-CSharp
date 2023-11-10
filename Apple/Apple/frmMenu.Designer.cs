
namespace Apple
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.pctComprar = new System.Windows.Forms.PictureBox();
            this.pctEstoque = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblEstoque.Location = new System.Drawing.Point(176, 362);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(114, 31);
            this.lblEstoque.TabIndex = 1;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblCompra.Location = new System.Drawing.Point(517, 361);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(119, 31);
            this.lblCompra.TabIndex = 3;
            this.lblCompra.Text = "Comprar";
            // 
            // pctComprar
            // 
            this.pctComprar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctComprar.Image = ((System.Drawing.Image)(resources.GetObject("pctComprar.Image")));
            this.pctComprar.Location = new System.Drawing.Point(432, 54);
            this.pctComprar.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.pctComprar.Name = "pctComprar";
            this.pctComprar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pctComprar.Size = new System.Drawing.Size(277, 297);
            this.pctComprar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctComprar.TabIndex = 2;
            this.pctComprar.TabStop = false;
            this.pctComprar.Click += new System.EventHandler(this.pctComprar_Click);
            // 
            // pctEstoque
            // 
            this.pctEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEstoque.Image = ((System.Drawing.Image)(resources.GetObject("pctEstoque.Image")));
            this.pctEstoque.Location = new System.Drawing.Point(97, 54);
            this.pctEstoque.Name = "pctEstoque";
            this.pctEstoque.Size = new System.Drawing.Size(278, 297);
            this.pctEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctEstoque.TabIndex = 0;
            this.pctEstoque.TabStop = false;
            this.pctEstoque.Click += new System.EventHandler(this.pctEstoque_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.pctComprar);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.pctEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pctComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.PictureBox pctComprar;
    }
}