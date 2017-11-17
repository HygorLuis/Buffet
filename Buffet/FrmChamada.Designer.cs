namespace Buffet
{
    partial class FrmChamada
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
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lvChamadas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHoraLigar = new System.Windows.Forms.Label();
            this.mtxtHorarioLigar = new System.Windows.Forms.MaskedTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblNumChamada = new System.Windows.Forms.Label();
            this.txtNumChamada = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.mtxtInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEvento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtlrParc = new System.Windows.Forms.TextBox();
            this.lblVlrParc = new System.Windows.Forms.Label();
            this.txtParc = new System.Windows.Forms.TextBox();
            this.lblParc = new System.Windows.Forms.Label();
            this.txtVlrPessoa = new System.Windows.Forms.TextBox();
            this.lblPorPessoa = new System.Windows.Forms.Label();
            this.txtNumPessoas = new System.Windows.Forms.TextBox();
            this.lblNumPessoas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(417, 192);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(336, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(255, 192);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(174, 192);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(93, 192);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(26, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 49;
            this.lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(102, 27);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(265, 21);
            this.cboCliente.TabIndex = 48;
            // 
            // lvChamadas
            // 
            this.lvChamadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvChamadas.Location = new System.Drawing.Point(83, 58);
            this.lvChamadas.Name = "lvChamadas";
            this.lvChamadas.Size = new System.Drawing.Size(422, 123);
            this.lvChamadas.TabIndex = 50;
            this.lvChamadas.UseCompatibleStateImageBehavior = false;
            this.lvChamadas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° Chamada";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data do Evento";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Horário para Ligar";
            this.columnHeader4.Width = 100;
            // 
            // cboFiltro
            // 
            this.cboFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(440, 26);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(121, 21);
            this.cboFiltro.TabIndex = 51;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(379, 26);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(55, 20);
            this.lblFiltro.TabIndex = 52;
            this.lblFiltro.Text = "Filtro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHoraLigar);
            this.groupBox1.Controls.Add(this.mtxtHorarioLigar);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.lblNumChamada);
            this.groupBox1.Controls.Add(this.txtNumChamada);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.mtxtInicio);
            this.groupBox1.Controls.Add(this.lblDataEvento);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(21, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 71);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Evento";
            // 
            // lblHoraLigar
            // 
            this.lblHoraLigar.AutoSize = true;
            this.lblHoraLigar.Location = new System.Drawing.Point(441, 23);
            this.lblHoraLigar.Name = "lblHoraLigar";
            this.lblHoraLigar.Size = new System.Drawing.Size(91, 13);
            this.lblHoraLigar.TabIndex = 51;
            this.lblHoraLigar.Text = "Horário para Ligar";
            // 
            // mtxtHorarioLigar
            // 
            this.mtxtHorarioLigar.Location = new System.Drawing.Point(436, 39);
            this.mtxtHorarioLigar.Mask = "90:00";
            this.mtxtHorarioLigar.Name = "mtxtHorarioLigar";
            this.mtxtHorarioLigar.Size = new System.Drawing.Size(100, 20);
            this.mtxtHorarioLigar.TabIndex = 50;
            this.mtxtHorarioLigar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtHorarioLigar.ValidatingType = typeof(System.DateTime);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(346, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 49;
            this.lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(314, 39);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 48;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumChamada
            // 
            this.lblNumChamada.AutoSize = true;
            this.lblNumChamada.Location = new System.Drawing.Point(28, 23);
            this.lblNumChamada.Name = "lblNumChamada";
            this.lblNumChamada.Size = new System.Drawing.Size(67, 13);
            this.lblNumChamada.TabIndex = 41;
            this.lblNumChamada.Text = "N° Chamada";
            // 
            // txtNumChamada
            // 
            this.txtNumChamada.Location = new System.Drawing.Point(12, 39);
            this.txtNumChamada.Name = "txtNumChamada";
            this.txtNumChamada.Size = new System.Drawing.Size(100, 20);
            this.txtNumChamada.TabIndex = 40;
            this.txtNumChamada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(255, 23);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 39;
            this.lblInicio.Text = "Início";
            // 
            // mtxtInicio
            // 
            this.mtxtInicio.Location = new System.Drawing.Point(251, 39);
            this.mtxtInicio.Mask = "90:00";
            this.mtxtInicio.Name = "mtxtInicio";
            this.mtxtInicio.Size = new System.Drawing.Size(43, 20);
            this.mtxtInicio.TabIndex = 38;
            this.mtxtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataEvento
            // 
            this.lblDataEvento.AutoSize = true;
            this.lblDataEvento.Location = new System.Drawing.Point(139, 23);
            this.lblDataEvento.Name = "lblDataEvento";
            this.lblDataEvento.Size = new System.Drawing.Size(82, 13);
            this.lblDataEvento.TabIndex = 37;
            this.lblDataEvento.Text = "Data do Evento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 15, 0, 0, 0, 0);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 125);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 45;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 109);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 13);
            this.lblValor.TabIndex = 44;
            this.lblValor.Text = "Valor Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblComplemento);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.lblCep);
            this.groupBox2.Controls.Add(this.mtxtCep);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Location = new System.Drawing.Point(157, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 121);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local do Evento";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(21, 66);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 39;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(24, 82);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(378, 20);
            this.txtComplemento.TabIndex = 38;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(299, 21);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 37;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(302, 37);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 36;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(230, 21);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(26, 13);
            this.lblCep.TabIndex = 35;
            this.lblCep.Text = "Cep";
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(233, 37);
            this.mtxtCep.Mask = "00000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(63, 20);
            this.mtxtCep.TabIndex = 34;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(177, 21);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 33;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(180, 37);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(47, 20);
            this.txtNumero.TabIndex = 32;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(22, 21);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 31;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(24, 37);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(150, 20);
            this.txtEndereco.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(157, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 110);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cardápio";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 85);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtlrParc);
            this.groupBox4.Controls.Add(this.lblVlrParc);
            this.groupBox4.Controls.Add(this.txtParc);
            this.groupBox4.Controls.Add(this.lblParc);
            this.groupBox4.Controls.Add(this.txtVlrPessoa);
            this.groupBox4.Controls.Add(this.lblPorPessoa);
            this.groupBox4.Controls.Add(this.txtNumPessoas);
            this.groupBox4.Controls.Add(this.lblNumPessoas);
            this.groupBox4.Controls.Add(this.txtValor);
            this.groupBox4.Controls.Add(this.lblValor);
            this.groupBox4.Location = new System.Drawing.Point(8, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 242);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valores";
            // 
            // txtlrParc
            // 
            this.txtlrParc.Location = new System.Drawing.Point(12, 212);
            this.txtlrParc.Name = "txtlrParc";
            this.txtlrParc.Size = new System.Drawing.Size(100, 20);
            this.txtlrParc.TabIndex = 53;
            this.txtlrParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVlrParc
            // 
            this.lblVlrParc.AutoSize = true;
            this.lblVlrParc.Location = new System.Drawing.Point(9, 196);
            this.lblVlrParc.Name = "lblVlrParc";
            this.lblVlrParc.Size = new System.Drawing.Size(81, 13);
            this.lblVlrParc.TabIndex = 52;
            this.lblVlrParc.Text = "Valor Parcela(s)";
            // 
            // txtParc
            // 
            this.txtParc.Location = new System.Drawing.Point(12, 169);
            this.txtParc.Name = "txtParc";
            this.txtParc.Size = new System.Drawing.Size(100, 20);
            this.txtParc.TabIndex = 51;
            this.txtParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblParc
            // 
            this.lblParc.AutoSize = true;
            this.lblParc.Location = new System.Drawing.Point(9, 153);
            this.lblParc.Name = "lblParc";
            this.lblParc.Size = new System.Drawing.Size(69, 13);
            this.lblParc.TabIndex = 50;
            this.lblParc.Text = "N° Parcela(s)";
            // 
            // txtVlrPessoa
            // 
            this.txtVlrPessoa.Location = new System.Drawing.Point(12, 81);
            this.txtVlrPessoa.Name = "txtVlrPessoa";
            this.txtVlrPessoa.Size = new System.Drawing.Size(100, 20);
            this.txtVlrPessoa.TabIndex = 49;
            this.txtVlrPessoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorPessoa
            // 
            this.lblPorPessoa.AutoSize = true;
            this.lblPorPessoa.Location = new System.Drawing.Point(9, 65);
            this.lblPorPessoa.Name = "lblPorPessoa";
            this.lblPorPessoa.Size = new System.Drawing.Size(87, 13);
            this.lblPorPessoa.TabIndex = 48;
            this.lblPorPessoa.Text = "Valor por Pessoa";
            // 
            // txtNumPessoas
            // 
            this.txtNumPessoas.Location = new System.Drawing.Point(12, 36);
            this.txtNumPessoas.Name = "txtNumPessoas";
            this.txtNumPessoas.Size = new System.Drawing.Size(100, 20);
            this.txtNumPessoas.TabIndex = 45;
            this.txtNumPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumPessoas
            // 
            this.lblNumPessoas.AutoSize = true;
            this.lblNumPessoas.Location = new System.Drawing.Point(9, 20);
            this.lblNumPessoas.Name = "lblNumPessoas";
            this.lblNumPessoas.Size = new System.Drawing.Size(62, 13);
            this.lblNumPessoas.TabIndex = 44;
            this.lblNumPessoas.Text = "N° Pessoas";
            // 
            // FrmChamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 560);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.lvChamadas);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmChamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Chamadas";
            this.Load += new System.EventHandler(this.FrmChamadas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ListView lvChamadas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNumChamada;
        private System.Windows.Forms.TextBox txtNumChamada;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.MaskedTextBox mtxtInicio;
        private System.Windows.Forms.Label lblDataEvento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblHoraLigar;
        private System.Windows.Forms.MaskedTextBox mtxtHorarioLigar;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVlrPessoa;
        private System.Windows.Forms.Label lblPorPessoa;
        private System.Windows.Forms.TextBox txtNumPessoas;
        private System.Windows.Forms.Label lblNumPessoas;
        private System.Windows.Forms.TextBox txtParc;
        private System.Windows.Forms.Label lblParc;
        private System.Windows.Forms.TextBox txtlrParc;
        private System.Windows.Forms.Label lblVlrParc;
    }
}