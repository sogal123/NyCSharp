using BusinessLayer;
using DataAccessLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Window
{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        //List<Podcast> podcastLista;
        AvsnittController avsnittController;
        PodcastRepository podcastRepository;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            avsnittController = new AvsnittController();
            podcastRepository = new PodcastRepository();
            fyllFeed();
            fyllCb();
        }


        private void btnNyPodcast_Click(object sender, EventArgs e)
        {



          
                podcastController.CreatePodcast(tbNamn.Text, tbUrl.Text, cbFrekvens.Text, cbKategori.Text);
                
               
                podcastController.getAll();
                fyllFeed();
                

            //datamanager.FeedLäsare(tbUrl.Text);
            //}
            //catch (FileNotFoundException error)
            //{
            //    Console.WriteLine(error.Message + "Hittar inte filen");
            //}

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
            //lvPodcast.Clear();
            var poddLista = podcastController.getAll();
           
            
            lvPodcast.Items.Clear();
            foreach (var podd in poddLista)
            {


                if (podd != null)
                {
                    string antalAvsnitt = podd.AvsnittLista.Count.ToString();

                    ListViewItem lista = new ListViewItem(antalAvsnitt);
                    lista.SubItems.Add(podd.Namn);
                    lista.SubItems.Add(podd.UppdateringsFrekvens);
                    lista.SubItems.Add(podd.Kategori);
                    lvPodcast.Items.Add(lista);


                    lvPodcast.FullRowSelect = true;
                    lvPodcast.View = View.Details;
                    lvPodcast.GridLines = true;
                    lvPodcast.Sorting = SortOrder.Descending;



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

            cbKategori.Items.Add(" ");
            cbKategori.Items.Add("Humor");
            cbKategori.Items.Add("Historia");
            cbKategori.SelectedIndex = -1;
        }

        private void lvPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPodcast.View = View.Details;
            lvPodcast.GridLines = true;
            lvPodcast.FullRowSelect = true;
            lvPodcast.Sorting = SortOrder.Descending;

            //if (lvPodcast.SelectedItems.Count == )
        }
    }
}
