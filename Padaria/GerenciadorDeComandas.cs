using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class GerenciadorDeComandas : Form
    {
        //Globais:
        Classes.Usuário usuario;
        public GerenciadorDeComandas(Classes.Usuário usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            //Mudar o título da Janela:
            this.Text = "GerenciadorDeComandas - Logado Como: " + usuario.NomeCompleto.ToUpper();

            //popularo DGV com os dados da tabela de produtos:
            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarTudo();


        }

        private void GerenciadorDeComandas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaselecionada = dgvProdutos.CurrentCell.RowIndex;
            var linha = dgvProdutos Rows[linhaselecionada];

            //Popular os txbs com os valores dos GVS 
            txbCodProduto.Text = linha.Cells[0].Value.ToString();
            txbProduto.Text = linha.Cells[1].Value.ToString();
        }

        private void btnLançar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja lançar?", "AVISO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                //Obtere os valores dos campos:
                ordem.IdFicha = int.Parse(txbComanda.Text);
                ordem.Id_Produto = int.Parse(txbCodProduto.Text);
                ordem.Quantidade = int.Parse(txbquantidade.Text);
                ordem.Id_resp = usuario.Id;
                //Efetuar o cadastro:
                if(ordem.Novolancamento() == true)
                {
                    MessageBox.Show("Lançamento efetuado!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Falha no Lançamento!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbCodProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            grbLancamento.Enabled = true;
            grbInfos.Enabled = false;

        }
    }
}
