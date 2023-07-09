using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaOrdemParanormal
{
    public class Player
    {
        public Player(int id_player)
        {
            Database.Connect();
            DataRow status = Database.GetPlayerStatus(id_player).Rows[0];
            DataRow desc = Database.GetPlayerDesc(id_player).Rows[0];
            Database.Disconnect();

            ID_Player = Convert.ToInt32(status["ID_PLAYER"]);
            Nome = Convert.ToString(status["NOME"]);
            Origem = Convert.ToString(status["ORIGEM"]);
            Classe = Convert.ToString(status["CLASSE"]);

            NEX = Convert.ToInt32(status["NEX"]);
            Deslocamento = Convert.ToInt32(status["DESLOCAMENTO"]);
            Pv_atual = Convert.ToInt32(status["PV_ATUAL"]);
            Pv_max = Convert.ToInt32(status["PV_MAX"]);
            Pe_atual = Convert.ToInt32(status["PE_ATUAL"]);
            Pe_max = Convert.ToInt32(status["PE_MAX"]);
            Defesa = Convert.ToInt32(status["DEFESA"]);
            San_atual = Convert.ToInt32(status["SAN_ATUAL"]);
            San_max = Convert.ToInt32(status["SAN_MAX"]);
            DT = Convert.ToInt32(status["DT"]);

            ID_Descricao = Convert.ToInt32(desc["ID"]);
            Aparencia = Convert.ToString(desc["APARENCIA"]);
            Personalidade = Convert.ToString(desc["PERSONALIDADE"]);
            Backstory = Convert.ToString(desc["BACKSTORY"]);
            Objetivos = Convert.ToString(desc["OBJETIVOS"]);


            SetAtributos();
            SetPericia();
            SetRituals();
        }
        public int ID_Player { get; set; }
        public string Nome { get; set; }
        public string Origem { get; set; }
        public string Classe { get; set; }

        public List<Pericias>  Pericia { get; set; }
        public List<Attributes> Atributo { get; set; }
        public List<Rituals> Ritual { get; set; }

        public int NEX { get; set; }
        public int Deslocamento { get; set; }
        public int Pv_atual { get; set; }
        public int Pv_max { get; set; }
        public int Pe_atual { get; set; }
        public int Pe_max { get; set; }
        public int Defesa { get; set; }
        public int San_atual { get; set; }
        public int San_max { get; set; }
        
        // Descricao do player
        public int ID_Descricao { get; set; }
        public string Aparencia { get; set; }
        public string Personalidade { get; set; }
        public string Backstory { get; set; }
        public string Objetivos { get; set; }

        public int DT { get; set; }
        public string Extra { get; set; }
        public void SetPericia()
        {
            Database.Connect();
            DataTable dt = Database.GetPericias(ID_Player);
            Database.Disconnect();

            foreach (DataRow r in dt.Rows)
            {
                Pericias ps = new Pericias(Convert.ToInt32(r["ID_PERICIA"]), Convert.ToInt32(r["ID_ATRIBUTO"]), Convert.ToString(r["ATRIBUTO"]), Convert.ToInt32(r["BONUS"]), Convert.ToString(r["PERICIA"]));
                Pericia.Add(ps);
            }
        }
        public void SetAtributos()
        {
            Database.Connect();
            DataTable dt = Database.GetAtributes(ID_Player);
            Database.Disconnect();

            foreach(DataRow r in dt.Rows)
            {
                Attributes atts = new Attributes(Convert.ToInt32(r["ID_ATRIBUTOS"]), Convert.ToString(r["NOME"]), Convert.ToInt32(r["VALOR"]));
                Atributo.Add(atts);
            }
        }
        public void SetRituals()
        {
            Database.Connect();
            DataTable dt = Database.GetPlayerRituals(ID_Player);
            Database.Disconnect();

            foreach (DataRow dr in dt.Rows)
            {
                Rituals rs = new Rituals(
                    Convert.ToInt32(dr["ID"]),
                    Convert.ToInt32(dr["CIRCULO"]),
                    Convert.ToString(dr["CUSTO"]), 
                    Convert.ToString(dr["EXECUCAO"]),
                    Convert.ToString(dr["NOME"]),
                    Convert.ToString(dr["ELEMENTO"]),
                    Convert.ToString(dr["ALCANCE"]),
                    Convert.ToString(dr["ALVO"]),
                    Convert.ToString(dr["DURACAO"]),
                    Convert.ToString(dr["RESISTENCIA"]),
                    Convert.ToString(dr["DESCRICAO"]),
                    Convert.ToString(dr["EXTRA"]));
                Ritual.Add(rs);
            }
        }
    }
}

