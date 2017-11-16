using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Buffet
{
    public partial class FrmChamada : Form
    {
        public FrmChamada()
        {
            InitializeComponent();
        }

        public static Form FrmAnterior;

        private void FrmChamadas_Load(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(Connections.LocalHost))
            {
                connection.Open();
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = @"SELECT * FROM chamadas WHERE Excluido != 0;";
                    var rd = sqlCommand.ExecuteReader();

                    if (rd.Read())
                    {
                        EnabledField(false);
                    }
                    else
                    {
                        btnAlterar.Enabled = false;
                        btnGravar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnExcluir.Enabled = false;
                    }
                }
                connection.Close();
            }

            //----------FILTRO----------
            var filtro = new Dictionary<string, int>
            {
                {"Em Andamento", 0},
                {"Finalizados", 1},
                {"Todos", 2}
            };

            cboFiltro.DataSource = null;
            cboFiltro.Items.Clear();
            cboFiltro.ValueMember = "Value";
            cboFiltro.DisplayMember = "Key";
            cboFiltro.DataSource = new BindingSource(filtro, null);
            cboFiltro.SelectedIndex = 0;
            //--------------------------

            if (FrmAnterior.Equals(new FrmConsulta()))
                sairToolStripMenuItem.Visible = false;

        }

        private void EnabledField(bool enabled)
        {
            btnIncluir.Enabled = !enabled;
            btnAlterar.Enabled = !enabled;
            btnGravar.Enabled = enabled;
            btnCancelar.Enabled = enabled;
            btnExcluir.Enabled = !enabled;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var frmConsulta = new FrmConsulta();
            FrmAnterior.Show();
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmConsulta = new FrmConsulta();
            frmConsulta.Show();
            Close();
        }
    }
}
