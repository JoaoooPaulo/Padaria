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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar um usuario:
            Classes.Usuário usuario = new Classes.Usuário();
            usuario.Email = Txt1.Text;
            usuario.Senha = Txt2.Text;

            //Obter o resultado do SELECT no banco:
            var resultado = usuario.Logar();

            if (resultado.Rows.Count == 1)
            {
                //Senha correta: Prosseguir...
                usuario.NomeCompleto = resultado.Rows[0]["Nome_Completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                MessageBox.Show(usuario.NomeCompleto);
                //Próximo Passo: Abrir janela Menu:
                MenuPrincipal janela = new MenuPrincipal();
                //Esconder janbela atual:
                Hide();
                //MostrarMenu:
                janela.ShowDialog();
                //Mostrar o login quando o menu fechar:
                Show();
            }
            else
            {
                //Senha incorreta:
                MessageBox.Show("Email ou Senha Incorretos. ",
                    "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
