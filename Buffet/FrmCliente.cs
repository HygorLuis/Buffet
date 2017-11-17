using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            //----------TIPO PESSOA----------
            var tipoPessoa = new Dictionary<string, string>
            {
                {"Física", "F"},
                {"Jurídica", "J"}
            };

            cboTipoPessoa.DataSource = null;
            cboTipoPessoa.Items.Clear();
            cboTipoPessoa.ValueMember = "Value";
            cboTipoPessoa.DisplayMember = "Key";
            cboTipoPessoa.DataSource = new BindingSource(tipoPessoa, null);
            //------------------------------

            //------TIPO FONE 1 e 2------
            var tipoFone = new Dictionary<string, int>
            {
                {"Fixo", 0},
                {"Celular", 1}
            };

            cboTipoFone1.DataSource = null;
            cboTipoFone1.Items.Clear();
            cboTipoFone1.ValueMember = "Value";
            cboTipoFone1.DisplayMember = "Key";
            cboTipoFone1.DataSource = new BindingSource(tipoFone, null);

            cboTipoFone2.DataSource = null;
            cboTipoFone2.Items.Clear();
            cboTipoFone2.ValueMember = "Value";
            cboTipoFone2.DisplayMember = "Key";
            cboTipoFone2.DataSource = new BindingSource(tipoFone, null);
            //------------------------------
        }

        private void cboTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPessoa.SelectedValue != null)
                mtxtCPFCNPJ.Mask = cboTipoPessoa.SelectedValue.Equals("F") ? "000.000.000-00" : "00.000.000/0000-00";
        }

        private void cboTipoFone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoFone1.SelectedValue != null)
                mtxtFone1.Mask = cboTipoFone1.SelectedValue.Equals(0) ? "(00) 0000-0000" : "(00) 00000-0000";
        }

        private void cboTipoFone2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoFone2.SelectedValue != null)
                mtxtFone2.Mask = cboTipoFone2.SelectedValue.Equals(0) ? "(00) 0000-0000" : "(00) 00000-0000";
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmConsulta = new FrmConsulta();
            frmConsulta.Show();
            Close();
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            FrmChamada.FrmAnterior = new FrmCliente();
            var frmChamadas = new FrmChamada();
            frmChamadas.ShowDialog();
            //Close();
        }
    }
}
