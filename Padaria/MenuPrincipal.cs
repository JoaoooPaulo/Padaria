using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class MenuPrincipal : Form
    {
        Classes.Usuário usuario = new Classes.Usuário();
        public MenuPrincipal(Classes.Usuário usuario)
        {
            InitializeComponent();

            //Atribuir o usuário local no global:
            this.usuario= usuario;

            //Mudar a label de apresentação:
            lblSaudacao.Text = "Olá " + usuario.NomeCompleto;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
           
        private void btnUsuários_Click(object sender, EventArgs e)
        {
            //instanciar a janela:
            GerenciadorDeUsuarios janela = new GerenciadorDeUsuarios();
            janela.Show();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            Views.GerenciadorDeComandas janela = new Views.GerenciadorDeComandas();
            janela.Show();
        }
    }
}
