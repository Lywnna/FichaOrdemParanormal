using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaOrdemParanormal
{
    public class AprimoramentoRituals
    {
        public AprimoramentoRituals(int iD, int iD_Ritual, string nome, string descrico, string custo)
        {
            ID = iD;
            ID_Ritual = iD_Ritual;
            Nome = nome;
            Descrico = descrico;
            Custo = custo;
        }

        public int ID { get; set; }
        public int ID_Ritual { get; set; }
        public string Nome { get; set; }
        public string Descrico { get; set; }
        public string Custo { get; set; }
    }
}
