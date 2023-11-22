using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padaria.Classes
{
    public class OrdemComanda
    {
        public string Id { get; set; }
        public string IdFicha { get; set; }
        public string Id_Produto { get; set; }
        public int Quantidade { get; set; }
        public int Id_resp { get; set; }
        public DateTime Data_Adic { get; set; }
        public string Situacao { get; set; }

        public bool Novolancamento()
        {
            {
                string comando = "INSERT INTO ordens_Comandas(id_ficha, id_produto, quantidade, id_resp) " +
                    "VALUES (@id_ficha, @id_produto, @quantidade, @id_resp) ";
                Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
                MySqlConnection con = conexaoBD.ObterConexao();
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
                cmd.Parameters.AddWithValue("@email", Email);



                //Obter o hash:
                string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
                cmd.Parameters.AddWithValue("@senha", hashsenha);
                cmd.Prepare();
                try
                {
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        conexaoBD.Desconectar(con);
                        return false;
                    }
                    else
                    {
                        conexaoBD.Desconectar(con);
                        return true;
                    }
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
        }
    }
}
