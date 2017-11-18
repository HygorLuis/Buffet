namespace Buffet
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChamada = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnLigado = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboMelhorHr = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEventProx = new System.Windows.Forms.ComboBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consulta = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChamada);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.btnLigado);
            this.groupBox1.Controls.Add(this.lblFiltro);
            this.groupBox1.Controls.Add(this.cboMelhorHr);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 303);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes para Ligar";
            // 
            // btnChamada
            // 
            this.btnChamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamada.Location = new System.Drawing.Point(271, 269);
            this.btnChamada.Name = "btnChamada";
            this.btnChamada.Size = new System.Drawing.Size(75, 23);
            this.btnChamada.TabIndex = 56;
            this.btnChamada.Text = "Chamada";
            this.btnChamada.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Location = new System.Drawing.Point(177, 269);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 55;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnLigado
            // 
            this.btnLigado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLigado.Location = new System.Drawing.Point(84, 269);
            this.btnLigado.Name = "btnLigado";
            this.btnLigado.Size = new System.Drawing.Size(75, 23);
            this.btnLigado.TabIndex = 54;
            this.btnLigado.Text = "Ligado";
            this.btnLigado.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(113, 32);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(92, 20);
            this.lblFiltro.TabIndex = 53;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // cboMelhorHr
            // 
            this.cboMelhorHr.FormattingEnabled = true;
            this.cboMelhorHr.Location = new System.Drawing.Point(211, 32);
            this.cboMelhorHr.Name = "cboMelhorHr";
            this.cboMelhorHr.Size = new System.Drawing.Size(121, 21);
            this.cboMelhorHr.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9});
            this.listView1.Location = new System.Drawing.Point(14, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 193);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Horário Ligar";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefone";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "E-Mail";
            this.columnHeader9.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboEventProx);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Location = new System.Drawing.Point(496, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 303);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eventos Próximos";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(257, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Chamada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Filtrar por:";
            // 
            // cboEventProx
            // 
            this.cboEventProx.FormattingEnabled = true;
            this.cboEventProx.Location = new System.Drawing.Point(292, 30);
            this.cboEventProx.Name = "cboEventProx";
            this.cboEventProx.Size = new System.Drawing.Size(121, 21);
            this.cboEventProx.TabIndex = 54;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Location = new System.Drawing.Point(16, 70);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(558, 193);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data Evento";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Início";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Local";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "N° Pessoas";
            this.columnHeader8.Width = 80;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(8, 327);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.fechar);
            this.panel1.Controls.Add(this.consulta);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Location = new System.Drawing.Point(183, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 100);
            this.panel1.TabIndex = 5;
            // 
            // consulta
            // 
            this.consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consulta.Image = ((System.Drawing.Image)(resources.GetObject("consulta.Image")));
            this.consulta.Location = new System.Drawing.Point(86, 12);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(55, 50);
            this.consulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.consulta.TabIndex = 1;
            this.consulta.TabStop = false;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            this.consulta.MouseLeave += new System.EventHandler(this.consulta_MouseLeave);
            this.consulta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.consulta_MouseMove);
            // 
            // usuario
            // 
            this.usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuario.Image = ((System.Drawing.Image)(resources.GetObject("usuario.Image")));
            this.usuario.Location = new System.Drawing.Point(12, 12);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(55, 50);
            this.usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usuario.TabIndex = 0;
            this.usuario.TabStop = false;
            this.usuario.MouseLeave += new System.EventHandler(this.usuario_MouseLeave);
            this.usuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.usuario_MouseMove);
            // 
            // fechar
            // 
            this.fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechar.Image = ((System.Drawing.Image)(resources.GetObject("fechar.Image")));
            this.fechar.Location = new System.Drawing.Point(672, 12);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(55, 50);
            this.fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fechar.TabIndex = 2;
            this.fechar.TabStop = false;
            this.fechar.MouseLeave += new System.EventHandler(this.fechar_MouseLeave);
            this.fechar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fechar_MouseMove);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMelhorHr;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEventProx;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnLigado;
        private System.Windows.Forms.Button btnChamada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox usuario;
        private System.Windows.Forms.PictureBox consulta;
        private System.Windows.Forms.PictureBox fechar;
    }
}