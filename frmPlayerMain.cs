using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaOrdemParanormal
{
    public partial class frmPlayerMain : Form
    {
        public frmPlayerMain(int id, string nome = "{ }")
        {
            InitializeComponent();
            id_player = id;
            player = new Player(id_player);

            Init(nome);
        }
        #region MyDeclarations

        private readonly int id_player;
        private readonly Player player;


        private void Init(string titulo)
        {
            Text = $"Player {titulo}";
            lbNome.Text = $"Nome: {player.Nome}";
            lbOrigem.Text = $"Origem: {player.Origem}";
            lbClasse.Text = $"Classe: {player.Classe}";
            lbDeslocamento.Text = $"Deslocamento: {player.Deslocamento}m";

            lbPV.Text = $"PV: {player.Pv_atual} / {player.Pv_max}";
            prBarPV.Maximum = player.Pv_max;
            prBarPV.Value = player.Pv_atual;

            lbPE.Text = $"PE: {player.Pe_atual} / {player.Pe_max}";
            prBarPE.Maximum = player.Pe_max;
            prBarPE.Value = player.Pe_atual;

            lbPERodada.Text = $"PE por rodada: {player.NEX / 5}";
            lbNEX.Text = $"NEX: {player.NEX}";

            lbSanidade.Text = $"Sanidade: {player.San_atual} / {player.San_max}";
            prBarSanidade.Maximum = player.San_max;
            prBarSanidade.Value = player.San_atual;

            lbDefesa.Text = $"Defesa: {player.Defesa}";
            lbDT.Text = $"DT: {player.DT}";

            lbAgilidade.Text = $"Agilidade: {player.Atributo.Find(x => x.Name == "AGILIDADE").Valor}";
            lbForca.Text = $"Força: {player.Atributo.Find(x => x.Name == "FORÇA").Valor}";
            lbIntelecto.Text = $"Intelecto: {player.Atributo.Find(x => x.Name == "INTELECTO").Valor}";
            lbPresenca.Text = $"Presença: {player.Atributo.Find(x => x.Name == "PRESENÇA").Valor}";
            lbVigor.Text = $"Vigor: {player.Atributo.Find(x => x.Name == "VIGOR").Valor}";

            txtBackStory.Text = player.Backstory;
            txtAparencia.Text = player.Aparencia;
            txtObjetivos.Text = player.Objetivos;
            txtPersonalidade.Text = player.Personalidade;

            dgvPericias.DataSource = FillGridPericias();
            dgvPericias.Columns["ID_PERICIA"].Visible = false;
            dgvPericias.Columns["ID_ATRIBUTO"].Visible = false;

            dgvRituals.DataSource = FillGridRituais();
            dgvRituals.Columns["ID"].Visible = false;

        }


        private DataTable FillGridPericias()
        {
            DataTable dt = new DataTable()
            { 
                Columns =
                {
                    "ID_PERICIA",
                    "ID_ATRIBUTO",
                    "PERICIA",
                    "ATRIBUTO",
                    "BONUS"
                }
            };

            foreach (var item in player.Pericia)
                dt.Rows.Add(item.ID, item.ID_Atributos, item.Nome, item.Atributos, item.Bonus);

            return dt;
        }
        private DataTable FillGridRituais()
        {
            DataTable dt = new DataTable() 
            { 
                Columns = 
                { 
                    "ID", 
                    "NOME",
                    "CIRCULO",
                    "ELEMENTO",
                    "DURACAO"
                }
            };

            foreach (var item in player.Ritual)
                dt.Rows.Add(item.ID, item.Nome, item.Circulo, item.Elemento, item.Duracao);

            return dt;
        }

        #endregion

        private void btnDices_Click(object sender, EventArgs e)
        {
            frmDices d = new frmDices();
            d.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass c = new frmChangePass(player);
            c.ShowDialog();
        }

        private void lbPV_Click(object sender, EventArgs e)
        {
            frmChangeInfo c = new frmChangeInfo(player, 0);
            c.ShowDialog();
            lbPV.Text = $"PV: {player.Pv_atual} / {player.Pv_max}";
        }

        private void lbPE_Click(object sender, EventArgs e)
        {
            frmChangeInfo c = new frmChangeInfo(player, 1);
            c.ShowDialog();
            lbPE.Text = $"PE: {player.Pe_atual} / {player.Pe_max}";
        }

        private void lbNEX_Click(object sender, EventArgs e)
        {
            frmChangeInfo c = new frmChangeInfo(player, 3);
            c.ShowDialog();
            lbNEX.Text = $"NEX: {player.NEX}";
        }

        private void lbSanidade_Click(object sender, EventArgs e)
        {
            frmChangeInfo c = new frmChangeInfo(player, 4);
            c.ShowDialog();
            lbSanidade.Text = $"Sanidade: {player.San_atual}";
        }

        private void lbDefesa_Click(object sender, EventArgs e)
        {
            frmChangeInfo c = new frmChangeInfo(player, 5);
            c.ShowDialog();
            lbDefesa.Text = $"Defesa: {player.Defesa}";
        }

        private void lbDeslocamento_Click(object sender, EventArgs e)
        {
            frmChangeInfo c = new frmChangeInfo(player, 6);
            c.ShowDialog();
            lbDeslocamento.Text = $"Deslocamento: {player.Deslocamento}";
        }

        private void MouseHoverSTATUS(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void MouseLeaveSTATUS(object sender, EventArgs e) => Cursor = Cursors.Default;

        private void lbNome_Click(object sender, EventArgs e) => MessageBox.Show("OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void dgPericias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int dices = player.Atributo.Find(x => x.ID == Convert.ToInt32(dgvPericias.Rows[e.RowIndex].Cells["ID_ATRIBUTO"].Value)).Valor;
            int mod = player.Pericia.Find(x => x.ID == Convert.ToInt32(dgvPericias.Rows[e.RowIndex].Cells["ID_PERICIA"].Value)).Bonus;

            frmDices d = new frmDices(dices, 20, mod);
            d.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            /*
            if(txtFilter.Text.Length == 0)
            {
                dgvPericias.DataSource = FillGrid();
                dgvPericias.Columns["ID_PERICIA"].Visible = false;
                dgvPericias.Columns["ID_ATRIBUTO"].Visible = false;
                return;
            }
            if (dgvPericias.DataSource == null) return;
            DataView dv = new DataView(dgvPericias.DataSource as DataTable)
            {
                RowFilter = $"PERICIA LIKE '%{txtFilter.Text}%'"
            };
            dgvPericias.DataSource = dv;
            */
        }

        private void frmPlayerMain_Resize(object sender, EventArgs e)
        {
            tabControl.Height = Height - 370;
            dgvPericias.Height = tabPericias.Height - 70;

            dgvRituals.Height = tabRituais.Height / 2;
            pnlInfoRituais.Height = tabRituais.Height / 2;
        }

        private void dgvRituals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Rituals ritual = player.Ritual.Find(x => x.ID == Convert.ToInt32(dgvRituals.Rows[e.RowIndex].Cells["ID"].Value));

            lbRitualNome.Text = "Nome: " + ritual.Nome;
            lbRitualExecucao.Text = "Execução: " + ritual.Execucao;
            lbRituallAlcance.Text = "Alcance: " + ritual.Alcance.ToString();
            lbRitualAlvo.Text = "Alvo: " + ritual.Alvo;
            lbRitualElemento.Text = "Elemento: " + ritual.Elemento;
            lbRitualCirculo.Text = "Circulo: " + ritual.Circulo;
            lbRitualDuracao.Text = "Duração: " + ritual.Duracao.ToString();
            lbRitualResistencia.Text = "Resistência: " + ritual.Resistencia;
            lbRitualCusto.Text = "Custo: " + ritual.Custo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(@"C:\FichaOrdemParanormal\config.ini");
            ini.DeleteSection("login");
        }
    }
}
