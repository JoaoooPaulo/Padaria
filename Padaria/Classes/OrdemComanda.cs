using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
