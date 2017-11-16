namespace Buffet
{
    partial class FrmConsulta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadChamadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnChamada = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEmAndamento = new System.Windows.Forms.TabPage();
            this.tpFinalizado = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadUsuárioToolStripMenuItem,
            this.cadChamadasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // cadUsuárioToolStripMenuItem
            // 
            this.cadUsuárioToolStripMenuItem.Name = "cadUsuárioToolStripMenuItem";
            this.cadUsuárioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cadUsuárioToolStripMenuItem.Text = "Cad. Usuário";
            // 
            // cadChamadasToolStripMenuItem
            // 
            this.cadChamadasToolStripMenuItem.Name = "cadChamadasToolStripMenuItem";
            this.cadChamadasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cadChamadasToolStripMenuItem.Text = "Cad. Chamadas";
            this.cadChamadasToolStripMenuItem.Click += new System.EventHandler(this.cadChamadasToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 57);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(275, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnChamada
            // 
            this.btnChamada.Location = new System.Drawing.Point(293, 57);
            this.btnChamada.Name = "btnChamada";
            this.btnChamada.Size = new System.Drawing.Size(275, 23);
            this.btnChamada.TabIndex = 3;
            this.btnChamada.Text = "Chamada";
            this.btnChamada.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEmAndamento);
            this.tabControl1.Controls.Add(this.tpFinalizado);
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 273);
            this.tabControl1.TabIndex = 4;
            // 
            // tpEmAndamento
            // 
            this.tpEmAndamento.Location = new System.Drawing.Point(4, 22);
            this.tpEmAndamento.Name = "tpEmAndamento";
            this.tpEmAndamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmAndamento.Size = new System.Drawing.Size(548, 247);
            this.tpEmAndamento.TabIndex = 0;
            this.tpEmAndamento.Text = "Em Andamento";
            this.tpEmAndamento.UseVisualStyleBackColor = true;
            // 
            // tpFinalizado
            // 
            this.tpFinalizado.Location = new System.Drawing.Point(4, 22);
            this.tpFinalizado.Name = "tpFinalizado";
            this.tpFinalizado.Padding = new System.Windows.Forms.Padding(3);
            this.tpFinalizado.Size = new System.Drawing.Size(548, 117);
            this.tpFinalizado.TabIndex = 1;
            this.tpFinalizado.Text = "Finalizados";
            this.tpFinalizado.UseVisualStyleBackColor = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnChamada);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadChamadasToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnChamada;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEmAndamento;
        private System.Windows.Forms.TabPage tpFinalizado;
    }
}