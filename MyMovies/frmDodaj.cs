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

        private bool obejrzanyFilm;
        Nullable<System.DateTime> dataObejrzenia;
        Nullable<Byte> ocenaFilmu;


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

        private void frm_Dodaj_btn_dodaj_Click(object sender, EventArgs e)
        {

            if (frm_Dodaj_obejrzany.Checked == true){
                obejrzanyFilm = true;
                dataObejrzenia = DateTime.Now;
                if (frm_Dodaj_ocena.SelectedItem.ToString() != "Ocena") {
                    ocenaFilmu = byte.Parse(frm_Dodaj_ocena.SelectedItem.ToString());
                }
            } else { obejrzanyFilm = false; dataObejrzenia = null; ocenaFilmu = null; }


            using (var db = new movieFilesEntities()) {
                Table table = new Table
                {
                    name = frm_Dodaj_nazwa.Text.Trim().ToString(),
                    director = frm_Dodaj_rezyser.Text.Trim().ToString(),
                    seen = obejrzanyFilm,
                    rating = ocenaFilmu,
                    poster = null,
                    watchingDate = dataObejrzenia,
                    localization = frm_Dodaj_lokalizacja.Text.Trim().ToString(),
                    genre = frm_Dodaj_gatunek.Text.Trim().ToString()
                };
                db.Table.Add(table);
            }
        }
    }
}
