namespace Padaria
{
    partial class GerenciadorDeComandas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLançar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbquantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContinuar);
            this.groupBox1.Controls.Add(this.lblCodProduto);
            this.groupBox1.Controls.Add(this.lblComanda);
            this.groupBox1.Controls.Add(this.txbCodProduto);
            this.groupBox1.Controls.Add(this.txbComanda);
            this.groupBox1.Location = new System.Drawing.Point(332, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informaçoes ";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(70, 121);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(10, 86);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(66, 13);
            this.lblCodProduto.TabIndex = 3;
            this.lblCodProduto.Text = "Cod.Produto";
            this.lblCodProduto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Location = new System.Drawing.Point(10, 50);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(55, 13);
            this.lblComanda.TabIndex = 2;
            this.lblComanda.Text = "Comanda ";
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Location = new System.Drawing.Point(82, 83);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(100, 20);
            this.txbCodProduto.TabIndex = 1;
            this.txbCodProduto.TextChanged += new System.EventHandler(this.txbCodProduto_TextChanged);
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(82, 47);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(100, 20);
            this.txbComanda.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLançar);
            this.groupBox2.Controls.Add(this.lblProduto);
            this.groupBox2.Controls.Add(this.lblQuantidade);
            this.groupBox2.Controls.Add(this.txbProduto);
            this.groupBox2.Controls.Add(this.txbquantidade);
            this.groupBox2.Location = new System.Drawing.Point(332, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lançamento";
            // 
            // btnLançar
            // 
            this.btnLançar.Location = new System.Drawing.Point(70, 123);
            this.btnLançar.Name = "btnLançar";
            this.btnLançar.Size = new System.Drawing.Size(75, 23);
            this.btnLançar.TabIndex = 4;
            this.btnLançar.Text = "LANÇAR ";
            this.btnLançar.UseVisualStyleBackColor = true;
            this.btnLançar.Click += new System.EventHandler(this.btnLançar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(10, 48);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(6, 88);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(70, 45);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(100, 20);
            this.txbProduto.TabIndex = 2;
            // 
            // txbquantidade
            // 
            this.txbquantidade.Location = new System.Drawing.Point(70, 85);
            this.txbquantidade.Name = "txbquantidade";
            this.txbquantidade.Size = new System.Drawing.Size(100, 20);
            this.txbquantidade.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gerenciador De Comandas ";
            // 
            // GerenciadorDeComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GerenciadorDeComandas";
            this.Text = "GerenciadorDeComandas";
            this.Load += new System.EventHandler(this.GerenciadorDeComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbquantidade;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Button btnLançar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label5;
    }
}