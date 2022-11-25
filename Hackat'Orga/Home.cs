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
            listBox1.Items.Add(listhackatons();
        }
    }
}
