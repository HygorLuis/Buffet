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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var frmCliente = new FrmCliente();
            frmCliente.Show();
            Close();
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            FrmChamada.FrmAnterior = new FrmConsulta();
            var frmChamadas = new FrmChamada();
            frmChamadas.Show();
            Close();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
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

            monthCalendar1.AddAnnuallyBoldedDate(Convert.ToDateTime("14/11/2017"));
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
