using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FichaOrdemParanormal
{
    public partial class frmDices : Form
    {
        public frmDices(int dices = 0, int sides = 0, int mod = 0)
        {
            InitializeComponent();

            if (dices > 0 &&  sides > 0) 
            { 
                txtDices.Text = dices.ToString();
                txtSides.Text = sides.ToString();
                txtMod.Text = mod.ToString();
                rbD20.Checked = true;
            }
        }
        #region MyDeclarations

        private readonly List<int> results = new List<int>();

        private string CheckDice(List<RadioButton> dices)
        {
            foreach (var sides in from RadioButton sides in dices where sides.Checked select sides)
                return sides.Text;

            return null;
        }

        private void ThrowDices()
        {
            int dices, sides, mod;

            try { sides = Convert.ToInt32(txtSides.Text); }
            catch { sides = 0; }


            try { dices = Convert.ToInt32(txtDices.Text); }
            catch { dices = 0; }

            try { mod = Convert.ToInt32(txtMod.Text); }
            catch { mod = 0; }

            GenerateDices(dices, sides, mod);

        }
        private void GenerateDices(int dices, int sides, int mod)
        {
            if (dices == 0 || sides == 0) return;
            results.Clear();
            Random rnd = new Random();
            string txt = "Dados: ";
            sides++;

            for (int i = 0; i < dices; i++)
            {
                int n = rnd.Next(1, sides);
                results.Add(n);
                txt += $" {n}, ";
            }
            PrintDices(mod);
        }
        private void PrintDices(int mod)
        {
            string txt = "Dados: | ";

            foreach (int i in results)
            {
                txt += $"{i}, ";
            }
            txt = txt.Remove(txt.Length - 2);
            txt += " |";

            if (mod != 0)
            {
                txt += $"\r\nSoma total = {results.Sum()} + {mod} = {results.Sum() + mod}";
                txt += $"\r\nMaior numero = {results.Max()} + {mod} = {results.Max() + mod}";
            }
            else
            {
                txt += $"\r\nSoma total = {results.Sum()} ";
                txt += $"\r\nMaior numero = {results.Max()} ";
            }
            txtResult.Text = txt;
        }
        #endregion

        private void CheckedChanged(object sender, EventArgs e)
        {
            List<RadioButton> dices = new List<RadioButton>
            {
                rbD2,
                rbD3,
                rbD4,
                rbD6,
                rbD8,
                rbD10,
                rbD12,
                rbD20,
                rbD100
            };
            string str = CheckDice(dices);
            str = str.Remove(0, 1);
            txtSides.Text = str;
        }

        private void DiceTextChanged(object sender, EventArgs e)
        {
            ThrowDices();
        }

        private void txtMod_TextChanged(object sender, EventArgs e)
        {
            int mod;
            try { mod = Convert.ToInt32(txtMod.Text); }
            catch { mod = 0; }
            PrintDices(mod);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ThrowDices();
        }
    }
}
