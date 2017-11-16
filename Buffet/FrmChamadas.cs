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
    public partial class FrmChamadas : Form
    {
        public FrmChamadas()
        {
            InitializeComponent();
        }

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
            var frmConsulta = new FrmConsulta();
            frmConsulta.Show();
            Close();
        }
    }
}
