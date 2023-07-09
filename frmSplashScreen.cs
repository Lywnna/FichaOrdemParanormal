using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaOrdemParanormal
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }


        private async void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            await Task.Delay(3000);
            frmLogin l = new frmLogin();
            Hide();
            l.ShowDialog();
            Close();
        }
    }
}
