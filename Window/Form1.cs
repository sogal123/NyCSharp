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
            int frekvens = Convert.ToInt32(cbFrekvens.SelectedItem);

            podcastController.CreatePodcast(tbNamn.Text, tbUrl.Text, frekvens);


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
            foreach(var pod in podcastLista)
            {
                if (pod != null)
                {
                    ListViewItem lista = new ListViewItem(pod.Namn);
                    lista.SubItems.Add(pod.Url);
                    lista.SubItems.Add(pod.UppdateringsFrekvens.ToString());
                        //Add(lista);
                    lvPodcast.Items.Add(lista);
                }
                
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
