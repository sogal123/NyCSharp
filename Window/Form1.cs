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
            fyllFeed();
            fyllCbFrekvens();
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

        private void fyllFeed()
        {
            lvPodcast.Clear();
            var podcastLista = podcastController.getAll();
            //podcastLista.ToList();
            foreach(var item in podcastLista)
            {
                ListViewItem lista = new ListViewItem(item.Namn);
                //lista.SubItems.Add()
                lvPodcast.Items.Add(lista);
            }

        }
        private void fyllCbFrekvens()
            {

            cbFrekvens.Items.Add("60s");
            cbFrekvens.Items.Add("120s");
            cbFrekvens.Items.Add("180s");
            cbFrekvens.SelectedIndex = -1;
            
        }


            

        
    }
}
