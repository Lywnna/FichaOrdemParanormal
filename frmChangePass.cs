using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaOrdemParanormal
{
    public partial class frmChangePass : Form
    {
        private Player p;
        public frmChangePass(Player player)
        {
            InitializeComponent();
            p = player;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Database.Connect();
            //if (Database.FindPass(Encryption.Encrypt(txtLastPass.Text)) == 0)
            //{
            //    MessageBox.Show("Senha incorreta");
            //    return;
            //}
            //Database.SaveNewPass(Encryption.Encrypt(txtNewPass.Text), p.ID_Player);
            //Database.Disconnect();
        }
    }
}
