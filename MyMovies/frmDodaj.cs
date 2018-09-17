using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMovies
{
    public partial class frmDodaj : Form
    {
        public frmDodaj()
        {
            InitializeComponent();
        }

        private void frm_Dodaj_lokalizacja_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStart frmStart = new frmStart();
            this.Hide();
            frmStart.ShowDialog();
            this.Close();
        }
    }
}
