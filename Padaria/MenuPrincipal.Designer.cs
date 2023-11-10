namespace Padaria
{
    partial class MenuPrincipal
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
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuários = new System.Windows.Forms.Button();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.Location = new System.Drawing.Point(20, 33);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(265, 21);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "Menu Principal --PADARIA";
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(144, 84);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(133, 50);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnComandas
            // 
            this.btnComandas.Location = new System.Drawing.Point(27, 84);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(111, 50);
            this.btnComandas.TabIndex = 2;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Location = new System.Drawing.Point(27, 140);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(250, 47);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnUsuários
            // 
            this.btnUsuários.Location = new System.Drawing.Point(27, 193);
            this.btnUsuários.Name = "btnUsuários";
            this.btnUsuários.Size = new System.Drawing.Size(250, 56);
            this.btnUsuários.TabIndex = 4;
            this.btnUsuários.Text = "Usuários";
            this.btnUsuários.UseVisualStyleBackColor = true;
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Location = new System.Drawing.Point(24, 68);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(66, 13);
            this.lblSaudacao.TabIndex = 5;
            this.lblSaudacao.Text = "Ola, Name...";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 274);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.btnUsuários);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.Lbltitulo);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuários;
        private System.Windows.Forms.Label lblSaudacao;
    }
}