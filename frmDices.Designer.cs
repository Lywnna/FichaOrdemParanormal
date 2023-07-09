namespace FichaOrdemParanormal
{
    partial class frmDices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDices));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbPresets = new System.Windows.Forms.GroupBox();
            this.rbD100 = new System.Windows.Forms.RadioButton();
            this.rbD20 = new System.Windows.Forms.RadioButton();
            this.rbD12 = new System.Windows.Forms.RadioButton();
            this.rbD10 = new System.Windows.Forms.RadioButton();
            this.rbD8 = new System.Windows.Forms.RadioButton();
            this.rbD6 = new System.Windows.Forms.RadioButton();
            this.rbD4 = new System.Windows.Forms.RadioButton();
            this.rbD3 = new System.Windows.Forms.RadioButton();
            this.rbD2 = new System.Windows.Forms.RadioButton();
            this.lbDices = new System.Windows.Forms.Label();
            this.txtDices = new System.Windows.Forms.TextBox();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.lbSides = new System.Windows.Forms.Label();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.lbMods = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.gbPresets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(13, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(63, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Dados";
            // 
            // gbPresets
            // 
            this.gbPresets.Controls.Add(this.rbD100);
            this.gbPresets.Controls.Add(this.rbD20);
            this.gbPresets.Controls.Add(this.rbD12);
            this.gbPresets.Controls.Add(this.rbD10);
            this.gbPresets.Controls.Add(this.rbD8);
            this.gbPresets.Controls.Add(this.rbD6);
            this.gbPresets.Controls.Add(this.rbD4);
            this.gbPresets.Controls.Add(this.rbD3);
            this.gbPresets.Controls.Add(this.rbD2);
            this.gbPresets.Location = new System.Drawing.Point(12, 35);
            this.gbPresets.Name = "gbPresets";
            this.gbPresets.Size = new System.Drawing.Size(200, 121);
            this.gbPresets.TabIndex = 2;
            this.gbPresets.TabStop = false;
            this.gbPresets.Text = "Presets";
            // 
            // rbD100
            // 
            this.rbD100.AutoSize = true;
            this.rbD100.Location = new System.Drawing.Point(124, 83);
            this.rbD100.Name = "rbD100";
            this.rbD100.Size = new System.Drawing.Size(62, 23);
            this.rbD100.TabIndex = 11;
            this.rbD100.Text = "D100";
            this.rbD100.UseVisualStyleBackColor = true;
            this.rbD100.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD20
            // 
            this.rbD20.AutoSize = true;
            this.rbD20.Location = new System.Drawing.Point(63, 83);
            this.rbD20.Name = "rbD20";
            this.rbD20.Size = new System.Drawing.Size(54, 23);
            this.rbD20.TabIndex = 10;
            this.rbD20.Text = "D20";
            this.rbD20.UseVisualStyleBackColor = true;
            this.rbD20.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD12
            // 
            this.rbD12.AutoSize = true;
            this.rbD12.Location = new System.Drawing.Point(6, 83);
            this.rbD12.Name = "rbD12";
            this.rbD12.Size = new System.Drawing.Size(54, 23);
            this.rbD12.TabIndex = 9;
            this.rbD12.Text = "D12";
            this.rbD12.UseVisualStyleBackColor = true;
            this.rbD12.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD10
            // 
            this.rbD10.AutoSize = true;
            this.rbD10.Location = new System.Drawing.Point(124, 54);
            this.rbD10.Name = "rbD10";
            this.rbD10.Size = new System.Drawing.Size(54, 23);
            this.rbD10.TabIndex = 8;
            this.rbD10.Text = "D10";
            this.rbD10.UseVisualStyleBackColor = true;
            this.rbD10.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD8
            // 
            this.rbD8.AutoSize = true;
            this.rbD8.Location = new System.Drawing.Point(63, 54);
            this.rbD8.Name = "rbD8";
            this.rbD8.Size = new System.Drawing.Size(46, 23);
            this.rbD8.TabIndex = 7;
            this.rbD8.Text = "D8";
            this.rbD8.UseVisualStyleBackColor = true;
            this.rbD8.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD6
            // 
            this.rbD6.AutoSize = true;
            this.rbD6.Location = new System.Drawing.Point(6, 54);
            this.rbD6.Name = "rbD6";
            this.rbD6.Size = new System.Drawing.Size(46, 23);
            this.rbD6.TabIndex = 6;
            this.rbD6.Text = "D6";
            this.rbD6.UseVisualStyleBackColor = true;
            this.rbD6.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD4
            // 
            this.rbD4.AutoSize = true;
            this.rbD4.Location = new System.Drawing.Point(124, 25);
            this.rbD4.Name = "rbD4";
            this.rbD4.Size = new System.Drawing.Size(46, 23);
            this.rbD4.TabIndex = 5;
            this.rbD4.Text = "D4";
            this.rbD4.UseVisualStyleBackColor = true;
            this.rbD4.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD3
            // 
            this.rbD3.AutoSize = true;
            this.rbD3.Location = new System.Drawing.Point(63, 25);
            this.rbD3.Name = "rbD3";
            this.rbD3.Size = new System.Drawing.Size(46, 23);
            this.rbD3.TabIndex = 4;
            this.rbD3.Text = "D3";
            this.rbD3.UseVisualStyleBackColor = true;
            this.rbD3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbD2
            // 
            this.rbD2.AutoSize = true;
            this.rbD2.Location = new System.Drawing.Point(6, 25);
            this.rbD2.Name = "rbD2";
            this.rbD2.Size = new System.Drawing.Size(46, 23);
            this.rbD2.TabIndex = 3;
            this.rbD2.Text = "D2";
            this.rbD2.UseVisualStyleBackColor = true;
            this.rbD2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // lbDices
            // 
            this.lbDices.AutoSize = true;
            this.lbDices.Location = new System.Drawing.Point(222, 54);
            this.lbDices.Name = "lbDices";
            this.lbDices.Size = new System.Drawing.Size(52, 19);
            this.lbDices.TabIndex = 0;
            this.lbDices.Text = "Dados:";
            // 
            // txtDices
            // 
            this.txtDices.Location = new System.Drawing.Point(328, 51);
            this.txtDices.MaxLength = 3;
            this.txtDices.Name = "txtDices";
            this.txtDices.Size = new System.Drawing.Size(158, 26);
            this.txtDices.TabIndex = 3;
            this.txtDices.TextChanged += new System.EventHandler(this.DiceTextChanged);
            // 
            // txtSides
            // 
            this.txtSides.Location = new System.Drawing.Point(328, 83);
            this.txtSides.MaxLength = 5;
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(158, 26);
            this.txtSides.TabIndex = 5;
            this.txtSides.TextChanged += new System.EventHandler(this.DiceTextChanged);
            // 
            // lbSides
            // 
            this.lbSides.AutoSize = true;
            this.lbSides.Location = new System.Drawing.Point(222, 86);
            this.lbSides.Name = "lbSides";
            this.lbSides.Size = new System.Drawing.Size(50, 19);
            this.lbSides.TabIndex = 4;
            this.lbSides.Text = "Lados:";
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(328, 115);
            this.txtMod.MaxLength = 5;
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(158, 26);
            this.txtMod.TabIndex = 7;
            this.txtMod.TextChanged += new System.EventHandler(this.txtMod_TextChanged);
            // 
            // lbMods
            // 
            this.lbMods.AutoSize = true;
            this.lbMods.Location = new System.Drawing.Point(222, 118);
            this.lbMods.Name = "lbMods";
            this.lbMods.Size = new System.Drawing.Size(100, 19);
            this.lbMods.TabIndex = 6;
            this.lbMods.Text = "Modificadores:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(18, 181);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(468, 78);
            this.txtResult.TabIndex = 8;
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Location = new System.Drawing.Point(14, 159);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(72, 19);
            this.lbResults.TabIndex = 9;
            this.lbResults.Text = "Resultado:";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(328, 9);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(154, 36);
            this.btnPlayAgain.TabIndex = 10;
            this.btnPlayAgain.Text = "Jogar novamente";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // frmDices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 271);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.lbMods);
            this.Controls.Add(this.txtSides);
            this.Controls.Add(this.lbSides);
            this.Controls.Add(this.txtDices);
            this.Controls.Add(this.lbDices);
            this.Controls.Add(this.gbPresets);
            this.Controls.Add(this.lbTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(510, 310);
            this.MinimumSize = new System.Drawing.Size(510, 310);
            this.Name = "frmDices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados";
            this.gbPresets.ResumeLayout(false);
            this.gbPresets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbPresets;
        private System.Windows.Forms.RadioButton rbD100;
        private System.Windows.Forms.RadioButton rbD20;
        private System.Windows.Forms.RadioButton rbD12;
        private System.Windows.Forms.RadioButton rbD10;
        private System.Windows.Forms.RadioButton rbD8;
        private System.Windows.Forms.RadioButton rbD6;
        private System.Windows.Forms.RadioButton rbD4;
        private System.Windows.Forms.RadioButton rbD3;
        private System.Windows.Forms.RadioButton rbD2;
        private System.Windows.Forms.Label lbDices;
        private System.Windows.Forms.TextBox txtDices;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Label lbSides;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Label lbMods;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}