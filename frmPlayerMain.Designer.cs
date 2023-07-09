namespace FichaOrdemParanormal
{
    partial class frmPlayerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerMain));
            this.lbOrigem = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbClasse = new System.Windows.Forms.Label();
            this.lbPV = new System.Windows.Forms.Label();
            this.lbNEX = new System.Windows.Forms.Label();
            this.lbDeslocamento = new System.Windows.Forms.Label();
            this.lbSanidade = new System.Windows.Forms.Label();
            this.lbPE = new System.Windows.Forms.Label();
            this.lbPERodada = new System.Windows.Forms.Label();
            this.lbDefesa = new System.Windows.Forms.Label();
            this.lbAgilidade = new System.Windows.Forms.Label();
            this.lbForca = new System.Windows.Forms.Label();
            this.lbIntelecto = new System.Windows.Forms.Label();
            this.lbPresenca = new System.Windows.Forms.Label();
            this.lbVigor = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPericias = new System.Windows.Forms.TabPage();
            this.lbFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnDices = new System.Windows.Forms.Button();
            this.dgvPericias = new System.Windows.Forms.DataGridView();
            this.tabRituais = new System.Windows.Forms.TabPage();
            this.pnlInfoRituais = new System.Windows.Forms.Panel();
            this.lbRitualNome = new System.Windows.Forms.Label();
            this.dgvRituals = new System.Windows.Forms.DataGridView();
            this.tabDesc = new System.Windows.Forms.TabPage();
            this.tabControlDesc = new System.Windows.Forms.TabControl();
            this.tabBackStory = new System.Windows.Forms.TabPage();
            this.txtBackStory = new System.Windows.Forms.TextBox();
            this.tabPersonality = new System.Windows.Forms.TabPage();
            this.txtPersonalidade = new System.Windows.Forms.TextBox();
            this.tabAparencia = new System.Windows.Forms.TabPage();
            this.txtAparencia = new System.Windows.Forms.TextBox();
            this.tabObjetivos = new System.Windows.Forms.TabPage();
            this.txtObjetivos = new System.Windows.Forms.TextBox();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnDelLogin = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prBarSanidade = new System.Windows.Forms.ProgressBar();
            this.prBarPE = new System.Windows.Forms.ProgressBar();
            this.prBarPV = new System.Windows.Forms.ProgressBar();
            this.lbDT = new System.Windows.Forms.Label();
            this.lbRitualExecucao = new System.Windows.Forms.Label();
            this.lbRituallAlcance = new System.Windows.Forms.Label();
            this.lbRitualAlvo = new System.Windows.Forms.Label();
            this.lbRitualCirculo = new System.Windows.Forms.Label();
            this.lbRitualElemento = new System.Windows.Forms.Label();
            this.lbRitualDuracao = new System.Windows.Forms.Label();
            this.lbRitualResistencia = new System.Windows.Forms.Label();
            this.lbRitualCusto = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPericias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).BeginInit();
            this.tabRituais.SuspendLayout();
            this.pnlInfoRituais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRituals)).BeginInit();
            this.tabDesc.SuspendLayout();
            this.tabControlDesc.SuspendLayout();
            this.tabBackStory.SuspendLayout();
            this.tabPersonality.SuspendLayout();
            this.tabAparencia.SuspendLayout();
            this.tabObjetivos.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrigem
            // 
            this.lbOrigem.AutoSize = true;
            this.lbOrigem.Location = new System.Drawing.Point(215, 18);
            this.lbOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrigem.Name = "lbOrigem";
            this.lbOrigem.Size = new System.Drawing.Size(80, 19);
            this.lbOrigem.TabIndex = 0;
            this.lbOrigem.Text = "Origem: { }";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(13, 18);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(73, 19);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome: { }";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // lbClasse
            // 
            this.lbClasse.AutoSize = true;
            this.lbClasse.Location = new System.Drawing.Point(215, 85);
            this.lbClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClasse.Name = "lbClasse";
            this.lbClasse.Size = new System.Drawing.Size(75, 19);
            this.lbClasse.TabIndex = 2;
            this.lbClasse.Text = "Classe: { }";
            // 
            // lbPV
            // 
            this.lbPV.AutoSize = true;
            this.lbPV.Location = new System.Drawing.Point(13, 10);
            this.lbPV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPV.Name = "lbPV";
            this.lbPV.Size = new System.Drawing.Size(54, 19);
            this.lbPV.TabIndex = 5;
            this.lbPV.Text = "PV: { }";
            this.lbPV.Click += new System.EventHandler(this.lbPV_Click);
            this.lbPV.MouseLeave += new System.EventHandler(this.MouseLeaveSTATUS);
            this.lbPV.MouseHover += new System.EventHandler(this.MouseHoverSTATUS);
            // 
            // lbNEX
            // 
            this.lbNEX.AutoSize = true;
            this.lbNEX.Location = new System.Drawing.Point(13, 49);
            this.lbNEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNEX.Name = "lbNEX";
            this.lbNEX.Size = new System.Drawing.Size(67, 19);
            this.lbNEX.TabIndex = 4;
            this.lbNEX.Text = "NEX: { }";
            this.lbNEX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNEX.Click += new System.EventHandler(this.lbNEX_Click);
            this.lbNEX.MouseLeave += new System.EventHandler(this.MouseLeaveSTATUS);
            this.lbNEX.MouseHover += new System.EventHandler(this.MouseHoverSTATUS);
            // 
            // lbDeslocamento
            // 
            this.lbDeslocamento.AutoSize = true;
            this.lbDeslocamento.Location = new System.Drawing.Point(215, 49);
            this.lbDeslocamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeslocamento.Name = "lbDeslocamento";
            this.lbDeslocamento.Size = new System.Drawing.Size(121, 19);
            this.lbDeslocamento.TabIndex = 3;
            this.lbDeslocamento.Text = "Deslocamento: { }";
            this.lbDeslocamento.Click += new System.EventHandler(this.lbDeslocamento_Click);
            this.lbDeslocamento.MouseLeave += new System.EventHandler(this.MouseLeaveSTATUS);
            this.lbDeslocamento.MouseHover += new System.EventHandler(this.MouseHoverSTATUS);
            // 
            // lbSanidade
            // 
            this.lbSanidade.AutoSize = true;
            this.lbSanidade.Location = new System.Drawing.Point(13, 145);
            this.lbSanidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSanidade.Name = "lbSanidade";
            this.lbSanidade.Size = new System.Drawing.Size(91, 19);
            this.lbSanidade.TabIndex = 8;
            this.lbSanidade.Text = "Sanidade: { }";
            this.lbSanidade.Click += new System.EventHandler(this.lbSanidade_Click);
            this.lbSanidade.MouseLeave += new System.EventHandler(this.MouseLeaveSTATUS);
            this.lbSanidade.MouseHover += new System.EventHandler(this.MouseHoverSTATUS);
            // 
            // lbPE
            // 
            this.lbPE.AutoSize = true;
            this.lbPE.Location = new System.Drawing.Point(13, 80);
            this.lbPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPE.Name = "lbPE";
            this.lbPE.Size = new System.Drawing.Size(53, 19);
            this.lbPE.TabIndex = 7;
            this.lbPE.Text = "PE: { }";
            this.lbPE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPE.Click += new System.EventHandler(this.lbPE_Click);
            this.lbPE.MouseLeave += new System.EventHandler(this.MouseLeaveSTATUS);
            this.lbPE.MouseHover += new System.EventHandler(this.MouseHoverSTATUS);
            // 
            // lbPERodada
            // 
            this.lbPERodada.AutoSize = true;
            this.lbPERodada.Location = new System.Drawing.Point(147, 80);
            this.lbPERodada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPERodada.Name = "lbPERodada";
            this.lbPERodada.Size = new System.Drawing.Size(125, 19);
            this.lbPERodada.TabIndex = 6;
            this.lbPERodada.Text = "PE por rodada: { }";
            // 
            // lbDefesa
            // 
            this.lbDefesa.AutoSize = true;
            this.lbDefesa.Location = new System.Drawing.Point(147, 10);
            this.lbDefesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDefesa.Name = "lbDefesa";
            this.lbDefesa.Size = new System.Drawing.Size(77, 19);
            this.lbDefesa.TabIndex = 9;
            this.lbDefesa.Text = "Defesa: { }";
            this.lbDefesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDefesa.Click += new System.EventHandler(this.lbDefesa_Click);
            this.lbDefesa.MouseLeave += new System.EventHandler(this.MouseLeaveSTATUS);
            this.lbDefesa.MouseHover += new System.EventHandler(this.MouseHoverSTATUS);
            // 
            // lbAgilidade
            // 
            this.lbAgilidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAgilidade.AutoSize = true;
            this.lbAgilidade.Location = new System.Drawing.Point(844, 9);
            this.lbAgilidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAgilidade.Name = "lbAgilidade";
            this.lbAgilidade.Size = new System.Drawing.Size(92, 19);
            this.lbAgilidade.TabIndex = 10;
            this.lbAgilidade.Text = "Agilidade: { }";
            // 
            // lbForca
            // 
            this.lbForca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbForca.AutoSize = true;
            this.lbForca.Location = new System.Drawing.Point(787, 49);
            this.lbForca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbForca.Name = "lbForca";
            this.lbForca.Size = new System.Drawing.Size(71, 19);
            this.lbForca.TabIndex = 11;
            this.lbForca.Text = "Força: { }";
            // 
            // lbIntelecto
            // 
            this.lbIntelecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIntelecto.AutoSize = true;
            this.lbIntelecto.Location = new System.Drawing.Point(911, 49);
            this.lbIntelecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIntelecto.Name = "lbIntelecto";
            this.lbIntelecto.Size = new System.Drawing.Size(87, 19);
            this.lbIntelecto.TabIndex = 12;
            this.lbIntelecto.Text = "Intelecto: { }";
            // 
            // lbPresenca
            // 
            this.lbPresenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPresenca.AutoSize = true;
            this.lbPresenca.Location = new System.Drawing.Point(800, 85);
            this.lbPresenca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPresenca.Name = "lbPresenca";
            this.lbPresenca.Size = new System.Drawing.Size(90, 19);
            this.lbPresenca.TabIndex = 13;
            this.lbPresenca.Text = "Presença: { }";
            // 
            // lbVigor
            // 
            this.lbVigor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVigor.AutoSize = true;
            this.lbVigor.Location = new System.Drawing.Point(911, 85);
            this.lbVigor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVigor.Name = "lbVigor";
            this.lbVigor.Size = new System.Drawing.Size(68, 19);
            this.lbVigor.TabIndex = 14;
            this.lbVigor.Text = "Vigor: { }";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPericias);
            this.tabControl.Controls.Add(this.tabRituais);
            this.tabControl.Controls.Add(this.tabDesc);
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 358);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1103, 301);
            this.tabControl.TabIndex = 15;
            // 
            // tabPericias
            // 
            this.tabPericias.Controls.Add(this.lbFilter);
            this.tabPericias.Controls.Add(this.txtFilter);
            this.tabPericias.Controls.Add(this.btnDices);
            this.tabPericias.Controls.Add(this.dgvPericias);
            this.tabPericias.Location = new System.Drawing.Point(4, 28);
            this.tabPericias.Name = "tabPericias";
            this.tabPericias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPericias.Size = new System.Drawing.Size(1095, 269);
            this.tabPericias.TabIndex = 0;
            this.tabPericias.Text = "Pericias";
            this.tabPericias.UseVisualStyleBackColor = true;
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(3, 12);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(53, 19);
            this.lbFilter.TabIndex = 1;
            this.lbFilter.Text = "Pericia:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(62, 9);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(139, 26);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnDices
            // 
            this.btnDices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDices.Location = new System.Drawing.Point(961, 9);
            this.btnDices.Name = "btnDices";
            this.btnDices.Size = new System.Drawing.Size(126, 40);
            this.btnDices.TabIndex = 3;
            this.btnDices.Text = "Jogar dados";
            this.btnDices.UseVisualStyleBackColor = true;
            this.btnDices.Click += new System.EventHandler(this.btnDices_Click);
            // 
            // dgvPericias
            // 
            this.dgvPericias.AllowUserToAddRows = false;
            this.dgvPericias.AllowUserToDeleteRows = false;
            this.dgvPericias.AllowUserToOrderColumns = true;
            this.dgvPericias.AllowUserToResizeRows = false;
            this.dgvPericias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPericias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPericias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPericias.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPericias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPericias.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvPericias.Location = new System.Drawing.Point(3, 55);
            this.dgvPericias.MultiSelect = false;
            this.dgvPericias.Name = "dgvPericias";
            this.dgvPericias.ReadOnly = true;
            this.dgvPericias.RowHeadersVisible = false;
            this.dgvPericias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPericias.Size = new System.Drawing.Size(1089, 211);
            this.dgvPericias.TabIndex = 0;
            this.dgvPericias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPericias_CellClick);
            // 
            // tabRituais
            // 
            this.tabRituais.Controls.Add(this.pnlInfoRituais);
            this.tabRituais.Controls.Add(this.dgvRituals);
            this.tabRituais.Location = new System.Drawing.Point(4, 28);
            this.tabRituais.Name = "tabRituais";
            this.tabRituais.Padding = new System.Windows.Forms.Padding(3);
            this.tabRituais.Size = new System.Drawing.Size(1095, 269);
            this.tabRituais.TabIndex = 2;
            this.tabRituais.Text = "Rituais";
            this.tabRituais.UseVisualStyleBackColor = true;
            // 
            // pnlInfoRituais
            // 
            this.pnlInfoRituais.Controls.Add(this.lbRitualCusto);
            this.pnlInfoRituais.Controls.Add(this.lbRitualResistencia);
            this.pnlInfoRituais.Controls.Add(this.lbRitualDuracao);
            this.pnlInfoRituais.Controls.Add(this.lbRitualElemento);
            this.pnlInfoRituais.Controls.Add(this.lbRitualCirculo);
            this.pnlInfoRituais.Controls.Add(this.lbRitualAlvo);
            this.pnlInfoRituais.Controls.Add(this.lbRituallAlcance);
            this.pnlInfoRituais.Controls.Add(this.lbRitualExecucao);
            this.pnlInfoRituais.Controls.Add(this.lbRitualNome);
            this.pnlInfoRituais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfoRituais.Location = new System.Drawing.Point(3, 124);
            this.pnlInfoRituais.Name = "pnlInfoRituais";
            this.pnlInfoRituais.Size = new System.Drawing.Size(1089, 142);
            this.pnlInfoRituais.TabIndex = 1;
            // 
            // lbRitualNome
            // 
            this.lbRitualNome.AutoSize = true;
            this.lbRitualNome.Location = new System.Drawing.Point(6, 9);
            this.lbRitualNome.Name = "lbRitualNome";
            this.lbRitualNome.Size = new System.Drawing.Size(73, 19);
            this.lbRitualNome.TabIndex = 0;
            this.lbRitualNome.Text = "Nome: { }";
            // 
            // dgvRituals
            // 
            this.dgvRituals.AllowUserToAddRows = false;
            this.dgvRituals.AllowUserToDeleteRows = false;
            this.dgvRituals.AllowUserToResizeRows = false;
            this.dgvRituals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRituals.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRituals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRituals.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRituals.Location = new System.Drawing.Point(3, 3);
            this.dgvRituals.MultiSelect = false;
            this.dgvRituals.Name = "dgvRituals";
            this.dgvRituals.ReadOnly = true;
            this.dgvRituals.RowHeadersVisible = false;
            this.dgvRituals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRituals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRituals.Size = new System.Drawing.Size(1089, 115);
            this.dgvRituals.TabIndex = 0;
            this.dgvRituals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRituals_CellClick);
            // 
            // tabDesc
            // 
            this.tabDesc.Controls.Add(this.tabControlDesc);
            this.tabDesc.Location = new System.Drawing.Point(4, 28);
            this.tabDesc.Name = "tabDesc";
            this.tabDesc.Padding = new System.Windows.Forms.Padding(3);
            this.tabDesc.Size = new System.Drawing.Size(1095, 269);
            this.tabDesc.TabIndex = 3;
            this.tabDesc.Text = "Descrição";
            this.tabDesc.UseVisualStyleBackColor = true;
            // 
            // tabControlDesc
            // 
            this.tabControlDesc.Controls.Add(this.tabBackStory);
            this.tabControlDesc.Controls.Add(this.tabPersonality);
            this.tabControlDesc.Controls.Add(this.tabAparencia);
            this.tabControlDesc.Controls.Add(this.tabObjetivos);
            this.tabControlDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDesc.Location = new System.Drawing.Point(3, 3);
            this.tabControlDesc.Name = "tabControlDesc";
            this.tabControlDesc.SelectedIndex = 0;
            this.tabControlDesc.Size = new System.Drawing.Size(1089, 263);
            this.tabControlDesc.TabIndex = 0;
            // 
            // tabBackStory
            // 
            this.tabBackStory.Controls.Add(this.txtBackStory);
            this.tabBackStory.Location = new System.Drawing.Point(4, 28);
            this.tabBackStory.Name = "tabBackStory";
            this.tabBackStory.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackStory.Size = new System.Drawing.Size(1081, 231);
            this.tabBackStory.TabIndex = 0;
            this.tabBackStory.Text = "BackStory";
            this.tabBackStory.UseVisualStyleBackColor = true;
            // 
            // txtBackStory
            // 
            this.txtBackStory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackStory.Location = new System.Drawing.Point(3, 3);
            this.txtBackStory.MaxLength = 65534;
            this.txtBackStory.Multiline = true;
            this.txtBackStory.Name = "txtBackStory";
            this.txtBackStory.Size = new System.Drawing.Size(1075, 225);
            this.txtBackStory.TabIndex = 0;
            // 
            // tabPersonality
            // 
            this.tabPersonality.Controls.Add(this.txtPersonalidade);
            this.tabPersonality.Location = new System.Drawing.Point(4, 28);
            this.tabPersonality.Name = "tabPersonality";
            this.tabPersonality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonality.Size = new System.Drawing.Size(1081, 231);
            this.tabPersonality.TabIndex = 1;
            this.tabPersonality.Text = "Personalidade";
            this.tabPersonality.UseVisualStyleBackColor = true;
            // 
            // txtPersonalidade
            // 
            this.txtPersonalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPersonalidade.Location = new System.Drawing.Point(3, 3);
            this.txtPersonalidade.MaxLength = 65535;
            this.txtPersonalidade.Multiline = true;
            this.txtPersonalidade.Name = "txtPersonalidade";
            this.txtPersonalidade.Size = new System.Drawing.Size(1075, 225);
            this.txtPersonalidade.TabIndex = 0;
            // 
            // tabAparencia
            // 
            this.tabAparencia.Controls.Add(this.txtAparencia);
            this.tabAparencia.Location = new System.Drawing.Point(4, 28);
            this.tabAparencia.Name = "tabAparencia";
            this.tabAparencia.Size = new System.Drawing.Size(1081, 231);
            this.tabAparencia.TabIndex = 2;
            this.tabAparencia.Text = "Aparência";
            this.tabAparencia.UseVisualStyleBackColor = true;
            // 
            // txtAparencia
            // 
            this.txtAparencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAparencia.Location = new System.Drawing.Point(0, 0);
            this.txtAparencia.MaxLength = 65535;
            this.txtAparencia.Multiline = true;
            this.txtAparencia.Name = "txtAparencia";
            this.txtAparencia.Size = new System.Drawing.Size(1081, 231);
            this.txtAparencia.TabIndex = 0;
            // 
            // tabObjetivos
            // 
            this.tabObjetivos.Controls.Add(this.txtObjetivos);
            this.tabObjetivos.Location = new System.Drawing.Point(4, 28);
            this.tabObjetivos.Name = "tabObjetivos";
            this.tabObjetivos.Size = new System.Drawing.Size(1081, 231);
            this.tabObjetivos.TabIndex = 3;
            this.tabObjetivos.Text = "Objetivos";
            this.tabObjetivos.UseVisualStyleBackColor = true;
            // 
            // txtObjetivos
            // 
            this.txtObjetivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObjetivos.Location = new System.Drawing.Point(0, 0);
            this.txtObjetivos.MaxLength = 65535;
            this.txtObjetivos.Multiline = true;
            this.txtObjetivos.Name = "txtObjetivos";
            this.txtObjetivos.Size = new System.Drawing.Size(1081, 231);
            this.txtObjetivos.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.btnDelLogin);
            this.tabProfile.Controls.Add(this.btnChangePass);
            this.tabProfile.Location = new System.Drawing.Point(4, 28);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1095, 269);
            this.tabProfile.TabIndex = 1;
            this.tabProfile.Text = "Perfil";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // btnDelLogin
            // 
            this.btnDelLogin.Location = new System.Drawing.Point(135, 25);
            this.btnDelLogin.Name = "btnDelLogin";
            this.btnDelLogin.Size = new System.Drawing.Size(109, 48);
            this.btnDelLogin.TabIndex = 1;
            this.btnDelLogin.Text = "Retirar login automático";
            this.btnDelLogin.UseVisualStyleBackColor = true;
            this.btnDelLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(8, 25);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(121, 48);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Trocar senha";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.prBarSanidade);
            this.panel1.Controls.Add(this.prBarPE);
            this.panel1.Controls.Add(this.prBarPV);
            this.panel1.Controls.Add(this.lbSanidade);
            this.panel1.Controls.Add(this.lbPV);
            this.panel1.Controls.Add(this.lbPE);
            this.panel1.Controls.Add(this.lbPERodada);
            this.panel1.Controls.Add(this.lbDefesa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 209);
            this.panel1.TabIndex = 16;
            // 
            // prBarSanidade
            // 
            this.prBarSanidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prBarSanidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.prBarSanidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prBarSanidade.Location = new System.Drawing.Point(17, 175);
            this.prBarSanidade.Name = "prBarSanidade";
            this.prBarSanidade.Size = new System.Drawing.Size(1074, 23);
            this.prBarSanidade.TabIndex = 11;
            // 
            // prBarPE
            // 
            this.prBarPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prBarPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.prBarPE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prBarPE.Location = new System.Drawing.Point(17, 110);
            this.prBarPE.Name = "prBarPE";
            this.prBarPE.Size = new System.Drawing.Size(1074, 23);
            this.prBarPE.TabIndex = 10;
            // 
            // prBarPV
            // 
            this.prBarPV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prBarPV.BackColor = System.Drawing.Color.Silver;
            this.prBarPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.prBarPV.Location = new System.Drawing.Point(17, 40);
            this.prBarPV.Name = "prBarPV";
            this.prBarPV.Size = new System.Drawing.Size(1074, 23);
            this.prBarPV.TabIndex = 9;
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Location = new System.Drawing.Point(13, 85);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(54, 19);
            this.lbDT.TabIndex = 17;
            this.lbDT.Text = "DT: { }";
            // 
            // lbRitualExecucao
            // 
            this.lbRitualExecucao.AutoSize = true;
            this.lbRitualExecucao.Location = new System.Drawing.Point(6, 41);
            this.lbRitualExecucao.Name = "lbRitualExecucao";
            this.lbRitualExecucao.Size = new System.Drawing.Size(94, 19);
            this.lbRitualExecucao.TabIndex = 1;
            this.lbRitualExecucao.Text = "Execução: { }";
            // 
            // lbRituallAlcance
            // 
            this.lbRituallAlcance.AutoSize = true;
            this.lbRituallAlcance.Location = new System.Drawing.Point(6, 75);
            this.lbRituallAlcance.Name = "lbRituallAlcance";
            this.lbRituallAlcance.Size = new System.Drawing.Size(84, 19);
            this.lbRituallAlcance.TabIndex = 2;
            this.lbRituallAlcance.Text = "Alcance: { }";
            // 
            // lbRitualAlvo
            // 
            this.lbRitualAlvo.AutoSize = true;
            this.lbRitualAlvo.Location = new System.Drawing.Point(6, 108);
            this.lbRitualAlvo.Name = "lbRitualAlvo";
            this.lbRitualAlvo.Size = new System.Drawing.Size(64, 19);
            this.lbRitualAlvo.TabIndex = 3;
            this.lbRitualAlvo.Text = "Alvo: { }";
            // 
            // lbRitualCirculo
            // 
            this.lbRitualCirculo.AutoSize = true;
            this.lbRitualCirculo.Location = new System.Drawing.Point(208, 41);
            this.lbRitualCirculo.Name = "lbRitualCirculo";
            this.lbRitualCirculo.Size = new System.Drawing.Size(79, 19);
            this.lbRitualCirculo.TabIndex = 4;
            this.lbRitualCirculo.Text = "Círculo: { }";
            // 
            // lbRitualElemento
            // 
            this.lbRitualElemento.AutoSize = true;
            this.lbRitualElemento.Location = new System.Drawing.Point(208, 9);
            this.lbRitualElemento.Name = "lbRitualElemento";
            this.lbRitualElemento.Size = new System.Drawing.Size(91, 19);
            this.lbRitualElemento.TabIndex = 5;
            this.lbRitualElemento.Text = "Elemento: { }";
            // 
            // lbRitualDuracao
            // 
            this.lbRitualDuracao.AutoSize = true;
            this.lbRitualDuracao.Location = new System.Drawing.Point(208, 75);
            this.lbRitualDuracao.Name = "lbRitualDuracao";
            this.lbRitualDuracao.Size = new System.Drawing.Size(87, 19);
            this.lbRitualDuracao.TabIndex = 6;
            this.lbRitualDuracao.Text = "Duração: { }";
            // 
            // lbRitualResistencia
            // 
            this.lbRitualResistencia.AutoSize = true;
            this.lbRitualResistencia.Location = new System.Drawing.Point(208, 108);
            this.lbRitualResistencia.Name = "lbRitualResistencia";
            this.lbRitualResistencia.Size = new System.Drawing.Size(102, 19);
            this.lbRitualResistencia.TabIndex = 7;
            this.lbRitualResistencia.Text = "Resistência: { }";
            // 
            // lbRitualCusto
            // 
            this.lbRitualCusto.AutoSize = true;
            this.lbRitualCusto.Location = new System.Drawing.Point(447, 9);
            this.lbRitualCusto.Name = "lbRitualCusto";
            this.lbRitualCusto.Size = new System.Drawing.Size(71, 19);
            this.lbRitualCusto.TabIndex = 8;
            this.lbRitualCusto.Text = "Custo: { }";
            // 
            // frmPlayerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 659);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lbVigor);
            this.Controls.Add(this.lbPresenca);
            this.Controls.Add(this.lbIntelecto);
            this.Controls.Add(this.lbForca);
            this.Controls.Add(this.lbAgilidade);
            this.Controls.Add(this.lbNEX);
            this.Controls.Add(this.lbDeslocamento);
            this.Controls.Add(this.lbClasse);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbOrigem);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlayerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player { }";
            this.Resize += new System.EventHandler(this.frmPlayerMain_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPericias.ResumeLayout(false);
            this.tabPericias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPericias)).EndInit();
            this.tabRituais.ResumeLayout(false);
            this.pnlInfoRituais.ResumeLayout(false);
            this.pnlInfoRituais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRituals)).EndInit();
            this.tabDesc.ResumeLayout(false);
            this.tabControlDesc.ResumeLayout(false);
            this.tabBackStory.ResumeLayout(false);
            this.tabBackStory.PerformLayout();
            this.tabPersonality.ResumeLayout(false);
            this.tabPersonality.PerformLayout();
            this.tabAparencia.ResumeLayout(false);
            this.tabAparencia.PerformLayout();
            this.tabObjetivos.ResumeLayout(false);
            this.tabObjetivos.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrigem;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbClasse;
        private System.Windows.Forms.Label lbPV;
        private System.Windows.Forms.Label lbNEX;
        private System.Windows.Forms.Label lbDeslocamento;
        private System.Windows.Forms.Label lbSanidade;
        private System.Windows.Forms.Label lbPE;
        private System.Windows.Forms.Label lbPERodada;
        private System.Windows.Forms.Label lbDefesa;
        private System.Windows.Forms.Label lbAgilidade;
        private System.Windows.Forms.Label lbForca;
        private System.Windows.Forms.Label lbIntelecto;
        private System.Windows.Forms.Label lbPresenca;
        private System.Windows.Forms.Label lbVigor;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPericias;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.DataGridView dgvPericias;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Button btnDices;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TabPage tabRituais;
        private System.Windows.Forms.DataGridView dgvRituals;
        private System.Windows.Forms.Panel pnlInfoRituais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar prBarPV;
        private System.Windows.Forms.ProgressBar prBarSanidade;
        private System.Windows.Forms.ProgressBar prBarPE;
        private System.Windows.Forms.TabPage tabDesc;
        private System.Windows.Forms.TabControl tabControlDesc;
        private System.Windows.Forms.TabPage tabBackStory;
        private System.Windows.Forms.TextBox txtBackStory;
        private System.Windows.Forms.TabPage tabPersonality;
        private System.Windows.Forms.TabPage tabAparencia;
        private System.Windows.Forms.TabPage tabObjetivos;
        private System.Windows.Forms.TextBox txtPersonalidade;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.TextBox txtAparencia;
        private System.Windows.Forms.TextBox txtObjetivos;
        private System.Windows.Forms.Button btnDelLogin;
        private System.Windows.Forms.Label lbRitualNome;
        private System.Windows.Forms.Label lbRitualCirculo;
        private System.Windows.Forms.Label lbRitualAlvo;
        private System.Windows.Forms.Label lbRituallAlcance;
        private System.Windows.Forms.Label lbRitualExecucao;
        private System.Windows.Forms.Label lbRitualCusto;
        private System.Windows.Forms.Label lbRitualResistencia;
        private System.Windows.Forms.Label lbRitualDuracao;
        private System.Windows.Forms.Label lbRitualElemento;
    }
}