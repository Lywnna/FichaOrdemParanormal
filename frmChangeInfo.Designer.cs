namespace FichaOrdemParanormal
{
    partial class frmChangeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeInfo));
            this.lbInfo = new System.Windows.Forms.Label();
            this.txtInfoNova = new System.Windows.Forms.TextBox();
            this.lbAlterar = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(18, 14);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(80, 20);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Info atual:";
            // 
            // txtInfoNova
            // 
            this.txtInfoNova.Location = new System.Drawing.Point(22, 95);
            this.txtInfoNova.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfoNova.Name = "txtInfoNova";
            this.txtInfoNova.Size = new System.Drawing.Size(195, 26);
            this.txtInfoNova.TabIndex = 1;
            // 
            // lbAlterar
            // 
            this.lbAlterar.AutoSize = true;
            this.lbAlterar.Location = new System.Drawing.Point(18, 71);
            this.lbAlterar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAlterar.Name = "lbAlterar";
            this.lbAlterar.Size = new System.Drawing.Size(80, 20);
            this.lbAlterar.TabIndex = 2;
            this.lbAlterar.Text = "Info atual:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 129);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 37);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(123, 129);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 37);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Cancelar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 181);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbAlterar);
            this.Controls.Add(this.txtInfoNova);
            this.Controls.Add(this.lbInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(260, 220);
            this.MinimumSize = new System.Drawing.Size(260, 220);
            this.Name = "frmChangeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterando { }";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox txtInfoNova;
        private System.Windows.Forms.Label lbAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
    }
}