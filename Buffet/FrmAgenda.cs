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

        private readonly List<ButtonSize> _tamanho = new List<ButtonSize>();

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            _tamanho.Clear();
            foreach (Control control in panel1.Controls)
                _tamanho.Add(new ButtonSize {name = control.Name, location = control.Location, size = control.Size});

            //monthCalendar1.AddAnnuallyBoldedDate(Convert.ToDateTime("14/11/2017"));
            //monthCalendar1.UpdateBoldedDates();
        }

        private void Diminuir(PictureBox pb)
        {
            _tamanho.ForEach(x =>
            {
                if (x.name == pb.Name)
                {
                    pb.Location = x.location;
                    pb.Size = x.size;
                }
            });
        }

        private void Aumentar(PictureBox pb)
        {
            _tamanho.ForEach(x =>
            {
                if (x.name == pb.Name)
                {
                    pb.Location = new Point(x.location.X - 5, x.location.Y - 5);
                    pb.Size = new Size(x.size.Width + 10, x.size.Height + 10);
                }
            });
        }

        private void usuario_MouseLeave(object sender, EventArgs e)
        {
             Diminuir(usuario);
        }

        private void usuario_MouseMove(object sender, MouseEventArgs e)
        {
            Aumentar(usuario);         
        }

        private void consulta_MouseLeave(object sender, EventArgs e)
        {
            Diminuir(consulta);
        }

        private void consulta_MouseMove(object sender, MouseEventArgs e)
        {
            Aumentar(consulta);
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            var frmConsulta = new FrmConsulta {MdiParent = ParentForm};
            frmConsulta.ShowDialog();
        }

        private void fechar_MouseLeave(object sender, EventArgs e)
        {
            Diminuir(fechar);
        }

        private void fechar_MouseMove(object sender, MouseEventArgs e)
        {
            Aumentar(fechar);
        }
    }
}
