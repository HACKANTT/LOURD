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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ICollection<Hackaton> listhackatons = cnx.Hackatons.ToList();
            listBox1.Items.Clear();
            listBox1.Items.Add(listhackatons);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ICollection<Hackaton> listhackatons = cnx.Hackatons.ToList();
            listBox1.Items.Clear();
            for (int i = 0; i < listhackatons.Count; i++)
            {
                listBox1.Items.Add(listhackatons.ElementAt(i).Theme);
            }
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

        private void dataGridHack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
