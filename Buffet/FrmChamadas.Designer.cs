namespace Buffet
{
    partial class FrmChamadas
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtHorarioLigar = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataEvento = new System.Windows.Forms.Label();
            this.lblNumPessoas = new System.Windows.Forms.Label();
            this.txtNumPessoas = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblCardapio = new System.Windows.Forms.Label();
            this.txtCardapio = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblHoraLigar = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.mtxtInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblIndicacao = new System.Windows.Forms.Label();
            this.txtIndicacao = new System.Windows.Forms.TextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.mtxtFone = new System.Windows.Forms.MaskedTextBox();
            this.lblNumChamada = new System.Windows.Forms.Label();
            this.txtNumChamada = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(372, 82);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(291, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(210, 82);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(129, 82);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(48, 82);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 15, 0, 0, 0, 0);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 201);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 13;
            // 
            // mtxtHorarioLigar
            // 
            this.mtxtHorarioLigar.Location = new System.Drawing.Point(198, 315);
            this.mtxtHorarioLigar.Mask = "90:00";
            this.mtxtHorarioLigar.Name = "mtxtHorarioLigar";
            this.mtxtHorarioLigar.Size = new System.Drawing.Size(100, 20);
            this.mtxtHorarioLigar.TabIndex = 14;
            this.mtxtHorarioLigar.ValidatingType = typeof(System.DateTime);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(58, 185);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // lblDataEvento
            // 
            this.lblDataEvento.AutoSize = true;
            this.lblDataEvento.Location = new System.Drawing.Point(38, 241);
            this.lblDataEvento.Name = "lblDataEvento";
            this.lblDataEvento.Size = new System.Drawing.Size(82, 13);
            this.lblDataEvento.TabIndex = 16;
            this.lblDataEvento.Text = "Data do Evento";
            // 
            // lblNumPessoas
            // 
            this.lblNumPessoas.AutoSize = true;
            this.lblNumPessoas.Location = new System.Drawing.Point(281, 185);
            this.lblNumPessoas.Name = "lblNumPessoas";
            this.lblNumPessoas.Size = new System.Drawing.Size(62, 13);
            this.lblNumPessoas.TabIndex = 17;
            this.lblNumPessoas.Text = "N° Pessoas";
            // 
            // txtNumPessoas
            // 
            this.txtNumPessoas.Location = new System.Drawing.Point(263, 201);
            this.txtNumPessoas.Name = "txtNumPessoas";
            this.txtNumPessoas.Size = new System.Drawing.Size(100, 20);
            this.txtNumPessoas.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(107, 299);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(78, 315);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 19;
            // 
            // lblCardapio
            // 
            this.lblCardapio.AutoSize = true;
            this.lblCardapio.Location = new System.Drawing.Point(408, 244);
            this.lblCardapio.Name = "lblCardapio";
            this.lblCardapio.Size = new System.Drawing.Size(49, 13);
            this.lblCardapio.TabIndex = 22;
            this.lblCardapio.Text = "Cardápio";
            // 
            // txtCardapio
            // 
            this.txtCardapio.Location = new System.Drawing.Point(379, 260);
            this.txtCardapio.Name = "txtCardapio";
            this.txtCardapio.Size = new System.Drawing.Size(100, 20);
            this.txtCardapio.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(408, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(379, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // lblHoraLigar
            // 
            this.lblHoraLigar.AutoSize = true;
            this.lblHoraLigar.Location = new System.Drawing.Point(207, 299);
            this.lblHoraLigar.Name = "lblHoraLigar";
            this.lblHoraLigar.Size = new System.Drawing.Size(91, 13);
            this.lblHoraLigar.TabIndex = 25;
            this.lblHoraLigar.Text = "Horário para Ligar";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(154, 241);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 27;
            this.lblInicio.Text = "Início";
            // 
            // mtxtInicio
            // 
            this.mtxtInicio.Location = new System.Drawing.Point(145, 257);
            this.mtxtInicio.Mask = "90:00";
            this.mtxtInicio.Name = "mtxtInicio";
            this.mtxtInicio.Size = new System.Drawing.Size(100, 20);
            this.mtxtInicio.TabIndex = 26;
            this.mtxtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(272, 241);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(85, 13);
            this.lblLocal.TabIndex = 29;
            this.lblLocal.Text = "Local do Evento";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(263, 257);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(100, 20);
            this.txtLocal.TabIndex = 28;
            // 
            // lblIndicacao
            // 
            this.lblIndicacao.AutoSize = true;
            this.lblIndicacao.Location = new System.Drawing.Point(325, 299);
            this.lblIndicacao.Name = "lblIndicacao";
            this.lblIndicacao.Size = new System.Drawing.Size(54, 13);
            this.lblIndicacao.TabIndex = 31;
            this.lblIndicacao.Text = "Indicação";
            // 
            // txtIndicacao
            // 
            this.txtIndicacao.Location = new System.Drawing.Point(316, 315);
            this.txtIndicacao.Name = "txtIndicacao";
            this.txtIndicacao.Size = new System.Drawing.Size(100, 20);
            this.txtIndicacao.TabIndex = 30;
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(154, 185);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(49, 13);
            this.lblFone.TabIndex = 33;
            this.lblFone.Text = "Telefone";
            // 
            // mtxtFone
            // 
            this.mtxtFone.Location = new System.Drawing.Point(145, 201);
            this.mtxtFone.Mask = "(00) 00000-9999";
            this.mtxtFone.Name = "mtxtFone";
            this.mtxtFone.Size = new System.Drawing.Size(100, 20);
            this.mtxtFone.TabIndex = 32;
            // 
            // lblNumChamada
            // 
            this.lblNumChamada.AutoSize = true;
            this.lblNumChamada.Location = new System.Drawing.Point(214, 136);
            this.lblNumChamada.Name = "lblNumChamada";
            this.lblNumChamada.Size = new System.Drawing.Size(67, 13);
            this.lblNumChamada.TabIndex = 35;
            this.lblNumChamada.Text = "N° Chamada";
            // 
            // txtNumChamada
            // 
            this.txtNumChamada.Location = new System.Drawing.Point(198, 152);
            this.txtNumChamada.Name = "txtNumChamada";
            this.txtNumChamada.Size = new System.Drawing.Size(100, 20);
            this.txtNumChamada.TabIndex = 34;
            // 
            // FrmChamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 372);
            this.Controls.Add(this.lblNumChamada);
            this.Controls.Add(this.txtNumChamada);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.mtxtFone);
            this.Controls.Add(this.lblIndicacao);
            this.Controls.Add(this.txtIndicacao);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.mtxtInicio);
            this.Controls.Add(this.lblHoraLigar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCardapio);
            this.Controls.Add(this.txtCardapio);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNumPessoas);
            this.Controls.Add(this.lblNumPessoas);
            this.Controls.Add(this.lblDataEvento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mtxtHorarioLigar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmChamadas";
            this.Text = "FrmChamadas";
            this.Load += new System.EventHandler(this.FrmChamadas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtHorarioLigar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataEvento;
        private System.Windows.Forms.Label lblNumPessoas;
        private System.Windows.Forms.TextBox txtNumPessoas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblCardapio;
        private System.Windows.Forms.TextBox txtCardapio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblHoraLigar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.MaskedTextBox mtxtInicio;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblIndicacao;
        private System.Windows.Forms.TextBox txtIndicacao;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.MaskedTextBox mtxtFone;
        private System.Windows.Forms.Label lblNumChamada;
        private System.Windows.Forms.TextBox txtNumChamada;
    }
}