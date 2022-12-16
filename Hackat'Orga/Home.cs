using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Hackat_Orga.Models;


namespace Hackat_Orga
{
    public partial class Home : Form
    {
        bdtproutiere7Context cnx = new bdtproutiere7Context();
        public Home()
        {

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ICollection<Hackaton> listhackatons = cnx.Hackatons.ToList();
            dataGridHack.Rows.Clear();
            dataGridHack.Columns.Clear();
            dataGridHack.Columns.Add("Theme", "Theme");
            dataGridHack.Columns.Add("DateDebut", "DateDebut");
            dataGridHack.Columns.Add("DateFin", "DateFin");
            dataGridHack.Columns.Add("HeureDebut", "HeureDebut");
            dataGridHack.Columns.Add("HeureFin", "HeureFin");
            dataGridHack.Columns.Add("Lieu", "Lieu");
            dataGridHack.Columns.Add("Rue", "Rue");
            dataGridHack.Columns.Add("Ville", "Ville");
            dataGridHack.Columns.Add("Cp", "Cp");
            dataGridHack.Columns.Add("Description", "Description");
            dataGridHack.Columns.Add("Image", "Image");
            dataGridHack.Columns.Add("DateLimite", "DateLimite");
            dataGridHack.Columns.Add("NbPlaces", "NbPlaces");
            for (int i = 0; i < listhackatons.Count; i++)
            {
                dataGridHack.Rows.Add(listhackatons.ElementAt(i).Theme, listhackatons.ElementAt(i).DateDebut, listhackatons.ElementAt(i).DateFin, listhackatons.ElementAt(i).HeureDebut, listhackatons.ElementAt(i).HeureFin, listhackatons.ElementAt(i).Lieu, listhackatons.ElementAt(i).Rue, listhackatons.ElementAt(i).Ville, listhackatons.ElementAt(i).Cp, listhackatons.ElementAt(i).Description, listhackatons.ElementAt(i).Image, listhackatons.ElementAt(i).DateLimite, listhackatons.ElementAt(i).NbPlaces);
            }
        }

        private void dataGridHack_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            string valeur = dataGridHack.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            label2.Text = valeur;
            /* On récupère l'id de la ligne correspondant à la cellule modifiée */
            int id = Convert.ToInt32(dataGridHack.Rows[e.RowIndex].Cells[0].Value);
            /* On récupère l'objet correspondant à l'id */
            Hackaton hackaton = cnx.Hackatons.Find(id);
            /* On modifie la valeur de l'objet */
            hackaton.Theme = valeur;
            /* On sauvegarde les modifications */
            cnx.SaveChanges();
            
            /* On enregistre la valeur dans la base de données */





        }

        private void dataGridHack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridHack.Rows[e.RowIndex];
                string theme = row.Cells["Theme"].Value.ToString();
                string datedebut = row.Cells["DateDebut"].Value.ToString();
                string datefin = row.Cells["DateFin"].Value.ToString();
                string heuredebut = row.Cells["HeureDebut"].Value.ToString();
                string heurefin = row.Cells["HeureFin"].Value.ToString();
                string lieu = row.Cells["Lieu"].Value.ToString();
                string rue = row.Cells["Rue"].Value.ToString();
                string ville = row.Cells["Ville"].Value.ToString();
                string cp = row.Cells["Cp"].Value.ToString();
                string description = row.Cells["Description"].Value.ToString();
                string image = row.Cells["Image"].Value.ToString();
                string datelimite = row.Cells["DateLimite"].Value.ToString();
                string nbplaces = row.Cells["NbPlaces"].Value.ToString();
                MessageBox.Show("Theme : " + theme + "\nDateDebut : " + datedebut + "\nDateFin : " + datefin + "\nHeureDebut : " + heuredebut + "\nHeureFin : " + heurefin + "\nLieu : " + lieu + "\nRue : " + rue + "\nVille : " + ville + "\nCp : " + cp + "\nDescription : " + description + "\nImage : " + image + "\nDateLimite : " + datelimite + "\nNbPlaces : " + nbplaces);
            }
            */
        }
    }
}
