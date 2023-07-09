using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.IO;
using System.Xml.Linq;

namespace FichaOrdemParanormal
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region MyDeclarations

        IniFile fileini = new IniFile(@"c:\FichaOrdemParanormal\config.ini");
        private void CallForm(int privilege, string name, int id_player)
        {
            Hide();

            switch (privilege)
            {
                case 0:
                    frmPlayerMain p = new frmPlayerMain(id_player, name);
                    p.ShowDialog();
                    break;

                case 1:
                    frmMasterMain m = new frmMasterMain(name);
                    m.ShowDialog();
                    break;

                case 2:
                    break;
            }

            Close();
        }

        private void Login(string login, string pass)
        {
            Database.Connect();
            pass = Encryption.Encrypt(pass);
            login = Encryption.Encrypt(login);


            if (Database.FindLogin(login, pass) == 0)
            {
                MessageBox.Show("Usuario não encontrado ou login incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lbTitle.Text = "Bem vindo a sua ficha digital";
                btnLogin.Enabled = true;
                Database.Disconnect();
                return;
            }


            int privilege = Database.CheckPrivileges(login);
            
            // ALTERAR PARA ABRIR UMA TELA ONDE ELE ESCOLHE O PERSONAGEM QUE QUER ESCOLHER
            string name = Database.GetUserName(login);
            if (name == "")
                name = txtLogin.Text;

            int id_player = Database.GetPlayerID(login, pass);

            Database.Disconnect();


            CallForm(privilege, name, id_player);
        }

        private void CreateLoginFile(string login, string pass)
        {
            string path = @"c:\FichaOrdemParanormal";

            try
            { DirectoryInfo di = Directory.CreateDirectory(path); }
            catch (Exception e)
            { MessageBox.Show($"Erro ao criar a pasta de auto login\r\n {e}"); }

            try
            {
                fileini.Write("login", $"{Encryption.Encode(login)}", "login");
                fileini.Write("pass", $"{Encryption.Encode(pass)}", "login");
            }
            catch (Exception ex)
            { MessageBox.Show($"Erro\r\n {ex}"); }

        }

        private string[] GetLogin()
        {
            if (!fileini.KeyExists("login", "login")) return null;

            string[] lines = new string[2];
            lines[0] = Encryption.Decode(fileini.Read("login", "login"));
            lines[1] = Encryption.Decode(fileini.Read("pass", "login"));
            return lines;
        }

        private bool CheckFile()
        {
            return File.Exists(@"C:\FichaOrdemParanormal\config.ini");
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPass.Text;
            if (login.Trim() == "" || pass.Trim() == "")
            {
                MessageBox.Show("Há campos vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnLogin.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            lbTitle.Text = "Conectando ao banco de dados...";

            if (cbLoginAuto.Checked) CreateLoginFile(login, pass);

            Login(login, pass);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            AcceptButton = btnLogin;
            string[] info = GetLogin();
            if (CheckFile() && info != null)
                Login(info[0], info[1]);
        }

        private void btnRevealPass_MouseHover(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void btnRevealPass_MouseLeave(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

    }
}
