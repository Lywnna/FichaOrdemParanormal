using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaOrdemParanormal
{
    internal static class Database                                                    
    {
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        private static string port;
        private static string conStr;
        private static MySqlConnection con;
        private static MySqlCommand cmd;
        private static void Init()
        {
            IniFile ini = new IniFile(@"C:\FichaOrdemParanormal\config.ini");

            server = Encryption.Decode(ini.Read("server", "server"));
            database = Encryption.Decode(ini.Read("database", "server"));
            uid = Encryption.Decode(ini.Read("uid", "server"));
            password = Encryption.Decode(ini.Read("pass", "server"));
            port = Encryption.Decode(ini.Read("port", "server"));
            conStr = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};";
            con = new MySqlConnection(conStr);
        }
        public static void Connect()
        {
            Init();
            try
            { con.Open(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar se conectar ao banco de dados\r\nErro:\r\n{ex}",
                    "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Disconnect()
        {
            try
            { con.Close(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar fechar o banco de dados\r\nErro:\r\n{ex}",
                    "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int FindLogin(string login, string pass)
        {
            string findUser = $"SELECT COUNT(*) FROM RPG.TB_LOGIN L WHERE L.USER = '{login}' AND L.PASSWORD = '{pass}'";
            cmd = new MySqlCommand(findUser, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            int value = Convert.ToInt32(reader.GetValue(0));
            reader.Dispose();
            return value;
        }

        public static int CheckPrivileges(string user)
        {
            string query = $"SELECT PRIVILEGES FROM RPG.TB_LOGIN WHERE USER = '{user}'";
            cmd = new MySqlCommand(query, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int value = Convert.ToInt32(reader.GetValue(0));
            reader.Dispose();
            return value;
        }

        public static string GetUserName(string user)
        {
            string query = $"SELECT SOCIALNAME FROM RPG.TB_LOGIN WHERE USER = '{user}'";
            cmd = new MySqlCommand(query, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string s = Convert.ToString(reader.GetValue(0));
            reader.Dispose();
            return s;
        }
        public static void SetPlayerStatus(Player p)
        {
            string query = "UPDATE RPG.TB_STATUS SET " +
                $" ID_PLAYER = {p.ID_Player}, " +
                $" NEX = {p.NEX} " +
                $" DESLOCAMENTO = {p.Deslocamento} " +
                $" PV_ATUAL = {p.Pv_atual} " +
                $" PE_ATUAL = {p.Pe_atual} " +
                $" DEF_ATUAL = {p.Defesa} " +
                $" SAN_ATUAL = {p.San_atual} ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetPlayerStatus(int id_player)
        {
            DataTable dt = new DataTable();
            string query = " SELECT " +
                " S.*, " +
                " P.NOME, " +
                " P.ORIGEM, " +
                " P.CLASSE, " +
                " P.ORIGEM " +
                " FROM RPG.TB_STATUS S " +
                " JOIN RPG.TB_PLAYER P ON P.ID = S.ID_PLAYER " +
                $" WHERE S.ID_PLAYER = {id_player} ";

            cmd = new MySqlCommand(query, con);

            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static int GetPlayerID(string user, string pass)
        {
            DataTable dt = new DataTable();
            string query = " SELECT " +
                " P.ID " +
                " FROM RPG.TB_PLAYER P " +
                " JOIN RPG.TB_LOGIN L ON L.ID = P.ID_LOGIN " +
                $" WHERE L.USER = '{user}' " +
                $" AND L.PASSWORD = '{pass}' ";
            cmd = new MySqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());

            DataRow dr = dt.Rows[0];
            return Convert.ToInt32(dr["ID"]);
        }

        public static void UpdateStatus(Player p)
        {
            string query = " UPDATE RPG.TB_STATUS T SET " +
                $" T.PV_ATUAL = {p.Pv_atual}, " +
                $" T.PE_ATUAL = {p.Pe_atual}, " +
                $" T.SAN_ATUAL = {p.San_atual}, " +
                $" T.DEFESA = {p.Defesa}, " +
                $" T.NEX = {p.NEX}, " +
                $" T.DESLOCAMENTO =  {p.Deslocamento} " +
                $" WHERE T.ID_PLAYER = {p.ID_Player} ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetAtributes(int id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT " +
                " PA.ID_PLAYER, " +
                " PA.VALOR, " +
                " A.NOME, " +
                " A.ID AS ID_ATRIBUTOS " +
                " FROM RPG.TB_PLAYER_ATRIBUTOS PA " +
                " JOIN RPG.TB_ATRIBUTOS A ON A.ID = PA.ID_ATRIBUTOS " +
                $" WHERE PA.ID_PLAYER = {id}";
            cmd = new MySqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static DataTable GetPericias(int id, string filter = "")
        {
            DataTable dt = new DataTable();
            string query = 
                " SELECT " +
                " P.ID AS ID_PERICIA, " +
                " A.ID AS ID_ATRIBUTO, " +
                " P.NOME AS PERICIA, " +
                " A.NOME AS ATRIBUTO, " +
                " COALESCE(PP.BONUS, 0) AS BONUS " +
                " FROM RPG.TB_PERICIAS P " +
                " JOIN RPG.TB_ATRIBUTOS A ON A.ID = P.ID_ATRIBUTOS " +
                " LEFT JOIN RPG.TB_PLAYER_PERICIA PP ON PP.ID_PERICIA = P.ID " +
                " LEFT JOIN RPG.TB_PLAYER_ATRIBUTOS PA ON PA.ID_ATRIBUTOS = A.ID " +
                $" WHERE PA.ID_PLAYER = {id} " + filter;

            cmd = new MySqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public static DataTable GetPlayerDesc(int id)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM RPG.TB_DESCRICAO_PLAYER D WHERE D.ID_PLAYER = {id}";
            cmd = new MySqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public static DataTable GetPlayerRituals(int id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT " +
                " R.ID, " +
                " E.NOME AS EXECUCAO, " +
                " R.NOME, " +
                " R.ELEMENTO, " +
                " R.CIRCULO, " +
                " R.ALCANCE, " +
                " R.ALVO, " +
                " R.DURACAO, " +
                " R.RESISTENCIA, " +
                " R.CUSTO, " +
                " R.DESCRICAO, " +
                " R.EXTRA " +
                " FROM TB_RITUAIS R " +
                " JOIN TB_EXECUCAO E ON E.ID = R.ID_EXECUCAO " +
                " JOIN TB_PLAYER_RITUAIS P ON P.ID_RITUAIS = R.ID " +
                $" WHERE P.ID_PLAYER = {id}";


            cmd = new MySqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public static DataTable GetRitualsApromoramento()
        {
            DataTable dt = new DataTable();
            string query = "";

            cmd = new MySqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
    }
}
