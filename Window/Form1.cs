using BusinessLayer;
using DataAccessLayer;
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
        private PodcastController podcastController;
        private DataManager datamanager;

        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            datamanager = new DataManager();
            fyllFeed();
            fyllCb();
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

        private void btnNyPodcast_MouseClick(object sender, MouseEventArgs e)
        {
            var namn = tbNamn.Text;
            var url = tbUrl.Text;
            var uppdateringsFrekvens = cbFrekvens.SelectedItem.ToString();
            var kategori = cbKategori.SelectedItem.ToString();

            podcastController.CreatePodcastAsync(namn, url, uppdateringsFrekvens, kategori);
        }
    }
}