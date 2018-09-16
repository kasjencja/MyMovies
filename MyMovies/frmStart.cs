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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
            using (var db = new movieFilesEntities()) {
                var query = from recWatched in db.recentlyWatched select recWatched;
                foreach (var movie in query) {
                    this.frm_Start_dgw.Rows.Add(movie.name, movie.director, movie.rating, movie.watchingDate);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Start_txtb_nazwa_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frm_Start_dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
