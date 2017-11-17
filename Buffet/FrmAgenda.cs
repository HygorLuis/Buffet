using System;
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
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            //monthCalendar1.AddAnnuallyBoldedDate(Convert.ToDateTime("14/11/2017"));
            //monthCalendar1.UpdateBoldedDates();
        }

        private void usuario_MouseLeave(object sender, EventArgs e)
        {
            usuario.Location = new Point(12, 12);
            usuario.Size = new Size(55,50);
        }

        private void usuario_MouseMove(object sender, MouseEventArgs e)
        {
            usuario.Location = new Point(7, 7);
            usuario.Size = new Size(65, 60);
        }

        private void consulta_MouseLeave(object sender, EventArgs e)
        {
            consulta.Location = new Point(86, 12);
            consulta.Size = new Size(55, 50);
        }

        private void consulta_MouseMove(object sender, MouseEventArgs e)
        {
            consulta.Location = new Point(81, 7);
            consulta.Size = new Size(65, 60);
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            var frmConsulta = new FrmConsulta();
            frmConsulta.MdiParent = ParentForm;
            frmConsulta.ShowDialog();
        }
    }
}
