using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rad_sa_vise_formi_EM
{
    public partial class frmStudenti : Form
    {
        public frmStudenti()
        {
            InitializeComponent();
        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            frmUnosNovogStudenta NoviStudent = new frmUnosNovogStudenta();
            NoviStudent.Show();

        }

        private void ButtonObrisiStudent_Click(object sender, EventArgs e)
        {
            if (!(listBoxStudenti.SelectedIndex < 0))

                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
        }

        private void ButtonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }
    }
}
