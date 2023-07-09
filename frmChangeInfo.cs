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
    public partial class frmChangeInfo : Form
    {
        public frmChangeInfo(Player p, int index)
        {
            InitializeComponent();

            i = index;
            this.p = p;

            init(index);
        }

        #region MyDeclaration
        private int i;
        private Player p; 
        private void init(int index)
        {
            string[] n =
            {
               $"Vida: {p.Pv_atual}",
               $"PE: {p.Pe_atual}",
               $"PE por rodada: {Convert.ToInt32(p.NEX / 5)}",
               $"NEX: {p.NEX}",
               $"Sanidade: {p.San_atual}",
               $"Defesa: {p.Defesa}",
               $"Deslocamento: {p.Deslocamento}"
            };

            Text = $"Alterando a {n[index]}";
            lbAlterar.Text = $"Alterando {n[index]}";
            lbInfo.Text = $"Valor atual de {n[index]}";
        }

        #endregion
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int x = 0;
            try
            { x = Convert.ToInt32(txtInfoNova.Text); }
            catch 
            {
                MessageBox.Show("Erro na conversao para numero","Erro",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtInfoNova.Text = string.Empty; 
                return;
            }
            switch (i)
            {
                case 0:
                    p.Pv_atual += x; 
                    break; 
                case 1:
                    p.Pe_atual += x;
                    break;
                case 2:
                    break;
                case 3:
                    p.NEX += x;
                    break;
                case 4:
                    p.San_atual += x;
                    break;
                case 5:
                    p.Defesa += x;
                    break;
                case 6:
                    p.Deslocamento += x;
                    break;
                default:
                    MessageBox.Show("Parabens, voce achou um erro que e considerado impossivel de se chegar");
                    break;

            }
            Database.Connect();
            Database.UpdateStatus(p);
            Database.Disconnect();
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
