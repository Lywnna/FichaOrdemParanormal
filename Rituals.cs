using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaOrdemParanormal
{
    public class Rituals
    {
        public Rituals(int id, int circulo, string custo, string execucao, string nome, string elemento, string alcance, string alvo,
            string duracao, string resistencia, string desc, string extra, List<AprimoramentoRituals> apr = null)
        {
            ID = id;
            Circulo = circulo;
            Custo = custo;
            Nome = nome;
            Duracao = duracao;
            Elemento = elemento;
            Alcance = alcance;
            Alvo = alvo;
            Resistencia = resistencia;
            Descricao = desc;
            Extra = extra;
            Execucao = execucao;
            Aprimoramento = apr;
        }

        public int ID { get; set; }
        public int Excucao { get; set; }
        public int Circulo { get; set; }
        public string Custo { get; set; }
        public string Execucao { get; set; }
        public string Nome { get; set; }
        public string Elemento { get; set; }
        public string Alcance { get; set; }
        public string Alvo { get; set; }
        public string Duracao { get; set; }
        public string Resistencia { get; set;}
        public string Descricao { get; set; }
        public string Extra { get; set; }

        public List<AprimoramentoRituals> Aprimoramento { get; set; }
        public void SetAprimoramento()
        {
            Database.Connect();
            DataTable dt = Database.GetRitualsApromoramento();
            Database.Disconnect();

            foreach(DataRow dr  in dt.Rows)
            {
                AprimoramentoRituals apr = new  AprimoramentoRituals();
                Aprimoramento.Add(apr);
            }
        }
    }
}
