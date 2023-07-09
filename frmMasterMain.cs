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
    public partial class frmMasterMain : Form
    {
        public frmMasterMain(string nome = "{ }")
        {
            InitializeComponent();
            Init(nome);
        }
        #region MyDeclarations
        private void Init(string titulo)
        {
            Text = $"Mestre {titulo}";
        }
        #endregion
        private void frmMasterMain_Load(object sender, EventArgs e)
        {

        }
    }
}
