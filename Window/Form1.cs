﻿using BusinessLayer;
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
            fyllCb();
        }

        
        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            
            
            podcastController.CreatePodcast(tbNamn.Text, tbUrl.Text, cbFrekvens.Text);


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
                   // lista.SubItems.Add(pod.UppdateringsFrekvens.ToString());
                        //Add(lista);
                    lvPodcast.Items.Add(lista);
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
