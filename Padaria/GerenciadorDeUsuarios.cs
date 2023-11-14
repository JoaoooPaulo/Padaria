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
    public partial class GerenciadorDeUsuarios : Form
    {
        public GerenciadorDeUsuarios()
        {
            InitializeComponent();
            Classes.Usuário usuario = new Classes.Usuário();
            
            //Atribuir a tabela (
            usuario.DataSource = usuario.ListarTudo();
        }
    }
}
