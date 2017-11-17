namespace Buffet
{
    partial class FrmCliente
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
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.cboTipoPessoa = new System.Windows.Forms.ComboBox();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTipoFone2 = new System.Windows.Forms.Label();
            this.cboTipoFone2 = new System.Windows.Forms.ComboBox();
            this.lblFone2 = new System.Windows.Forms.Label();
            this.mtxtFone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoFone1 = new System.Windows.Forms.Label();
            this.cboTipoFone1 = new System.Windows.Forms.ComboBox();
            this.lblFone1 = new System.Windows.Forms.Label();
            this.mtxtFone1 = new System.Windows.Forms.MaskedTextBox();
            this.btnChamada = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCliente
            // 
            this.cboCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(158, 21);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(265, 21);
            this.cboCliente.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(380, 62);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(299, 62);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(218, 62);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 44;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(137, 62);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 43;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(56, 62);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 42;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(82, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 47;
            this.lblCliente.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtCPFCNPJ);
            this.groupBox1.Controls.Add(this.lblTipoPessoa);
            this.groupBox1.Controls.Add(this.cboTipoPessoa);
            this.groupBox1.Controls.Add(this.lblCPFCNPJ);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(31, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 72);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cliente";
            // 
            // mtxtCPFCNPJ
            // 
            this.mtxtCPFCNPJ.Location = new System.Drawing.Point(295, 39);
            this.mtxtCPFCNPJ.Name = "mtxtCPFCNPJ";
            this.mtxtCPFCNPJ.Size = new System.Drawing.Size(136, 20);
            this.mtxtCPFCNPJ.TabIndex = 22;
            this.mtxtCPFCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(195, 22);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(66, 13);
            this.lblTipoPessoa.TabIndex = 21;
            this.lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // cboTipoPessoa
            // 
            this.cboTipoPessoa.FormattingEnabled = true;
            this.cboTipoPessoa.Location = new System.Drawing.Point(168, 38);
            this.cboTipoPessoa.Name = "cboTipoPessoa";
            this.cboTipoPessoa.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPessoa.TabIndex = 20;
            this.cboTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cboTipoPessoa_SelectedIndexChanged);
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Location = new System.Drawing.Point(332, 23);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(59, 13);
            this.lblCPFCNPJ.TabIndex = 19;
            this.lblCPFCNPJ.Text = "CPF/CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(68, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(149, 20);
            this.txtNome.TabIndex = 16;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblTipoFone2);
            this.groupBox2.Controls.Add(this.cboTipoFone2);
            this.groupBox2.Controls.Add(this.lblFone2);
            this.groupBox2.Controls.Add(this.mtxtFone2);
            this.groupBox2.Controls.Add(this.lblTipoFone1);
            this.groupBox2.Controls.Add(this.cboTipoFone1);
            this.groupBox2.Controls.Add(this.lblFone1);
            this.groupBox2.Controls.Add(this.mtxtFone1);
            this.groupBox2.Location = new System.Drawing.Point(31, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 149);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(202, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblTipoFone2
            // 
            this.lblTipoFone2.AutoSize = true;
            this.lblTipoFone2.Location = new System.Drawing.Point(265, 31);
            this.lblTipoFone2.Name = "lblTipoFone2";
            this.lblTipoFone2.Size = new System.Drawing.Size(28, 13);
            this.lblTipoFone2.TabIndex = 41;
            this.lblTipoFone2.Text = "Tipo";
            // 
            // cboTipoFone2
            // 
            this.cboTipoFone2.FormattingEnabled = true;
            this.cboTipoFone2.Location = new System.Drawing.Point(235, 47);
            this.cboTipoFone2.Name = "cboTipoFone2";
            this.cboTipoFone2.Size = new System.Drawing.Size(90, 21);
            this.cboTipoFone2.TabIndex = 40;
            this.cboTipoFone2.SelectedIndexChanged += new System.EventHandler(this.cboTipoFone2_SelectedIndexChanged);
            // 
            // lblFone2
            // 
            this.lblFone2.AutoSize = true;
            this.lblFone2.Location = new System.Drawing.Point(355, 31);
            this.lblFone2.Name = "lblFone2";
            this.lblFone2.Size = new System.Drawing.Size(58, 13);
            this.lblFone2.TabIndex = 39;
            this.lblFone2.Text = "Telefone 2";
            // 
            // mtxtFone2
            // 
            this.mtxtFone2.Location = new System.Drawing.Point(331, 47);
            this.mtxtFone2.Mask = "(00) 00000-9999";
            this.mtxtFone2.Name = "mtxtFone2";
            this.mtxtFone2.Size = new System.Drawing.Size(100, 20);
            this.mtxtFone2.TabIndex = 38;
            this.mtxtFone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoFone1
            // 
            this.lblTipoFone1.AutoSize = true;
            this.lblTipoFone1.Location = new System.Drawing.Point(43, 32);
            this.lblTipoFone1.Name = "lblTipoFone1";
            this.lblTipoFone1.Size = new System.Drawing.Size(28, 13);
            this.lblTipoFone1.TabIndex = 37;
            this.lblTipoFone1.Text = "Tipo";
            // 
            // cboTipoFone1
            // 
            this.cboTipoFone1.FormattingEnabled = true;
            this.cboTipoFone1.Location = new System.Drawing.Point(13, 48);
            this.cboTipoFone1.Name = "cboTipoFone1";
            this.cboTipoFone1.Size = new System.Drawing.Size(90, 21);
            this.cboTipoFone1.TabIndex = 36;
            this.cboTipoFone1.SelectedIndexChanged += new System.EventHandler(this.cboTipoFone_SelectedIndexChanged);
            // 
            // lblFone1
            // 
            this.lblFone1.AutoSize = true;
            this.lblFone1.Location = new System.Drawing.Point(133, 32);
            this.lblFone1.Name = "lblFone1";
            this.lblFone1.Size = new System.Drawing.Size(58, 13);
            this.lblFone1.TabIndex = 35;
            this.lblFone1.Text = "Telefone 1";
            // 
            // mtxtFone1
            // 
            this.mtxtFone1.Location = new System.Drawing.Point(109, 48);
            this.mtxtFone1.Mask = "(00) 00000-9999";
            this.mtxtFone1.Name = "mtxtFone1";
            this.mtxtFone1.Size = new System.Drawing.Size(100, 20);
            this.mtxtFone1.TabIndex = 34;
            this.mtxtFone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChamada
            // 
            this.btnChamada.Location = new System.Drawing.Point(218, 371);
            this.btnChamada.Name = "btnChamada";
            this.btnChamada.Size = new System.Drawing.Size(75, 23);
            this.btnChamada.TabIndex = 50;
            this.btnChamada.Text = "Chamada";
            this.btnChamada.UseVisualStyleBackColor = true;
            this.btnChamada.Click += new System.EventHandler(this.btnChamada_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 407);
            this.Controls.Add(this.btnChamada);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtCPFCNPJ;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.ComboBox cboTipoPessoa;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTipoFone1;
        private System.Windows.Forms.ComboBox cboTipoFone1;
        private System.Windows.Forms.Label lblFone1;
        private System.Windows.Forms.MaskedTextBox mtxtFone1;
        private System.Windows.Forms.Label lblTipoFone2;
        private System.Windows.Forms.ComboBox cboTipoFone2;
        private System.Windows.Forms.Label lblFone2;
        private System.Windows.Forms.MaskedTextBox mtxtFone2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnChamada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}