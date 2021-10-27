using BusinessLayer;
using DataAccessLayer;
using Model;
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
        DataManager datamanager;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            datamanager = new DataManager();
           fyllFeed();
            fyllCb();
        }

        
        private void btnNyPodcast_Click(object sender, EventArgs e)
        {

                        
            podcastController.CreatePodcast(tbNamn.Text, tbUrl.Text, cbFrekvens.Text, cbKategori.Text);
            string url = tbUrl.Text;
            datamanager.Feedläsare(url);


            //cbFrekvens.Text,string namn, int uppdateringsFrekvens, string url, string kategori, List< Avsnitt > avsnitt

        }





        //private void btnSparaPodcast_Click(object sender, EventArgs e)
        //{
        //    lvPodcast.Clear();
        //    var podcastLista = podcastController.getAll();

        //    foreach (var podd in podcastLista)
        //    {
        //        if (podd != null)
        //        {
        //            ListViewItem lista = new ListViewItem(podd.Namn);
        //            lista.SubItems.Add(podd.UppdateringsFrekvens);
        //            lista.SubItems.Add(podd.Kategori);

        //            lvPodcast.Items.Add(lista);
        //            lvPodcast.FullRowSelect = true;
        //        }

        private void fyllFeed()
        {
            lvPodcast.Clear();
            var podcastLista = podcastController.getAll();

            foreach (var podd in podcastLista)
            {
                if (podd != null)
                {
                    ListViewItem lista = new ListViewItem(podd.Namn);
                    lista.SubItems.Add(podd.UppdateringsFrekvens);
                    lista.SubItems.Add(podd.Kategori);

                    lvPodcast.Items.Add(lista);
                    lvPodcast.FullRowSelect = true;

                }
            }
        }
                    
            
        
        private void fyllCb()
            {

            cbFrekvens.Items.Add(" ");
            cbFrekvens.Items.Add("1min");
            cbFrekvens.Items.Add("2min");
            cbFrekvens.Items.Add("3min");
            cbFrekvens.SelectedIndex = 0;

            cbKategori.Items.Add("Humor");
            cbKategori.Items.Add("Historia");
            cbKategori.SelectedIndex = -1;
        }


            

        
    }
}
