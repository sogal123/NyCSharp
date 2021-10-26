using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window
{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
        }

        private void cbFrekvens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            podcastController.CreatePodcast(tbNamn.Text, tbUrl.Text);

            //cbFrekvens.Text,string namn, int uppdateringsFrekvens, string url, string kategori, List< Avsnitt > avsnitt

        }





        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {

        }
    }
}
