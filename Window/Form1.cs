using BusinessLayer;
using DataAccessLayer;
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
        List<Podcast> podcastLista;
        AvsnittController avsnittController;
        PodcastRepository podcastRepository;
        KategoriController kategoriController;
        string valdPodd;
        string valdKategori;
        int valdPoddInt = 1;

        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            avsnittController = new AvsnittController();
            podcastRepository = new PodcastRepository();
            kategoriController = new KategoriController();
            podcastLista = podcastController.getAll();

            fyllFeed();
            fyllCb();
            fyllKategori();
        }


        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                //Validator.FörKortInput(tbNamn.Text);
                //Validator.TommaTextFält(tbUrl.Text);
                Validator.TommaCbs(" ", cbKategori.SelectedItem); Validator.TommaCbs(" ", cbFrekvens.SelectedItem);
                Validator.TommaTextFält(" ", tbUrl.Text); Validator.TommaTextFält(" ", tbNamn.Text);

                podcastController.CreatePodcast(tbNamn.Text, tbUrl.Text, cbFrekvens.Text, cbKategori.Text);


               
                
                MessageBox.Show(tbNamn.Text + " är tillagd som podcast!");
                Console.WriteLine("Tillagd podcast" + tbNamn.Text);
                fyllFeed();
            }
            catch (Exception error)
            {
                Felmeddelande(error);
                Console.WriteLine(error.Message);
            }

            //datamanager.FeedLäsare(tbUrl.Text);
            //}
            //catch (FileNotFoundException error)
            //{
            //    Console.WriteLine(error.Message + "Hittar inte filen");
            //}

            //cbFrekvens.Text,string namn, int uppdateringsFrekvens, string url, string kategori, List< Avsnitt > avsnitt
        }

        private void Felmeddelande(Exception e)
        {
            MessageBox.Show("Något gick fel. " + e.Message);
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

                    ListViewItem lista = new ListViewItem(podd.Namn);
                    lista.SubItems.Add(antalAvsnitt);
                    lista.SubItems.Add(podd.UppdateringsFrekvens);
                    lista.SubItems.Add(podd.Kategori);
                    lvPodcast.Items.Add(lista);


                    lvPodcast.FullRowSelect = true;
                    lvPodcast.View = View.Details;
                    lvPodcast.GridLines = true;
                    lvPodcast.Sorting = SortOrder.Descending;
                    lvPodcast.Refresh();



                }
            }
        }

        private void fyllKategori()
        {
            var kategoriLista = kategoriController.GetAll();

            lbKategori.Items.Clear();
            cbKategori.Items.Clear();
            foreach (var kategori in kategoriLista)
            {
                if (kategoriLista != null)
                {
                    lbKategori.Items.Add(kategori.KategoriNamn);
                    cbKategori.Items.Add(kategori.KategoriNamn);
                }
            }
        }




        private void fyllCb()
        {

            cbFrekvens.Items.Add("1min");
            cbFrekvens.Items.Add("2min");
            cbFrekvens.Items.Add("3min");
            cbFrekvens.SelectedIndex = 0;

            cbKategori.SelectedIndex = -1;
        }
        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {



            try
            {
                //Validering 
                Validator.TommaCbs(" ", cbKategori.SelectedItem); Validator.TommaCbs(" ", cbFrekvens.SelectedItem);
                Validator.TommaTextFält(" ", tbUrl.Text); Validator.TommaTextFält(" ", tbNamn.Text);
                var poddLista = podcastController.getAll();
                Podcast podd = poddLista[valdPoddInt];
                string url = tbUrl.Text;
                string namn = tbNamn.Text;
                string frekvens = cbFrekvens.Text;
                string kategori = cbKategori.Text;
                //int i = lvPodcast.SelectedItems[0];

                //for (int i = lvPodcast.SelectedItems.Count - 1; i >= 0; i--)
                //{
                //    podcastController.DeletePodcast(valdPodd);
                //    Console.WriteLine(i + "Podcasten är borttagen");
                //    fyllFeed();
                //}
                //foreach (Podcast p in podcastLista)
                {
                    if (podd.Namn.Equals(namn))
                    {

                        podcastController.UpdatePodcast(valdPoddInt, namn, url, frekvens, kategori);

                        fyllFeed();
                        MessageBox.Show("Podcast sparad!");
                    }

                }
            }
            catch (Exception error)
            {
                Felmeddelande(error);
                
            }



        }

        private void fyllTB()
        {

            var valdPodd = lvPodcast.SelectedItems[0].Text;
            if (lvPodcast.SelectedItems.Count == 1)
            {

                var poddLista = podcastController.getAll();
                foreach (Podcast podd in poddLista)
                {
                    if (podd.Namn.Equals(valdPodd))
                    {
                        tbNamn.Text = podd.Namn;
                        tbUrl.Text = podd.Url;
                        cbFrekvens.Text = podd.UppdateringsFrekvens;
                        cbKategori.Text = podd.Kategori;
                    }

                }
            }
        }

        private void lvPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPodcast.View = View.Details;
            lvPodcast.GridLines = true;
            lvPodcast.FullRowSelect = true;
            lvPodcast.Sorting = SortOrder.Descending;

            lbAvsnittsLista.Items.Clear();
            if (lvPodcast.SelectedItems.Count == 1)
            {

                valdPodd = lvPodcast.SelectedItems[0].Text;

                foreach (Podcast podd in podcastController.getAll())
                {


                    if (podd.Namn.Equals(valdPodd))
                    {
                        foreach (Avsnitt avsnitt in podd.AvsnittLista)
                        {
                            lbAvsnittsLista.Items.Add(avsnitt.Namn);
                            fyllTB();
                        }
                    }
                }
            }
        }

        private void lbAvsnittsLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvsnittsLista.SelectedItems.Count == 1)
            {
                var ettAvsnitt = lbAvsnittsLista.SelectedItems[0];

                foreach (var podd in podcastController.getAll())
                {

                    foreach (var avsnitt in podd.AvsnittLista)
                    {
                        if (avsnitt.Namn.Equals(ettAvsnitt))
                        {
                            tbBeskrivning.Text = avsnitt.AvsnittsBeskrivning;

                        }
                    }

                }


            }
        }


        private void lbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            try
            {
                Validator.TommaTextFält(" ", tbNyKategori.Text);
            }
            catch (Exception error)
            {
                Felmeddelande(error);
            }
        }

            private void btnNyKategori_Click(object sender, EventArgs e)
            {
            try
            {
                Validator.TommaTextFält(" ", tbNyKategori.Text);
                string KategoriNamn = tbNyKategori.Text;

                Kategori kategori = new Kategori(KategoriNamn);
                kategoriController.CreateKategori(kategori);

                tbNyKategori.Text = string.Empty;
                MessageBox.Show(KategoriNamn + " tillagd som en kategori!");

                kategoriController.GetAll();
                fyllKategori();
            }
            catch (Exception error)
            {
                Felmeddelande(error);
            }
}



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            if (lvPodcast.SelectedItems.Count >= 0)
            {

                var confirmation = MessageBox.Show("Are you sure you want to delete the podcast " + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation == DialogResult.OK)
                {

                    for (int i = lvPodcast.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        podcastController.DeletePodcast(valdPodd);
                        Console.WriteLine(i + "Podcasten är borttagen");
                        fyllFeed();
                    }
                }
                else
                {
                    MessageBox.Show("Gick inte att ta bort podcast");
                }
            }


        }
        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbKategori.SelectedItems.Count >= 0)
                {
                    Validator.TommaTextFält(" ", tbNyKategori.Text);

                    var confirmation = MessageBox.Show("Are you sure you want to delete the category " + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (confirmation == DialogResult.OK)
                    {
                        for (int i = lbKategori.SelectedItems.Count - 1; i >= 0; i--)
                        {

                            {
                                kategoriController.DeleteKategori(valdKategori);
                                Console.WriteLine(i + "Kategorin är borttagen");
                                Console.WriteLine(valdKategori);
                                fyllKategori();
                            }
                        }
                    }
                }
            }
            catch (Exception error)

            {
                Felmeddelande(error);

            }
        }


        private void TickTimer()
        {
            var timer = new Timer();
            {

            }
        }

        private void lbKategori_SelectedIndexChanged_1(object sender, EventArgs e)


        {


            if (lbKategori.SelectedItems.Count > 0)
            {
                valdKategori = lbKategori.SelectedItems[0].Text;

                tbNyKategori.Text = valdKategori;

                var poddLista = podcastController.getAll();
                lvPodcast.Items.Clear();

                foreach (Podcast podd in poddLista)

                {
                    if (podd.Kategori.Equals(valdKategori) && podd != null)
                    {
                        string antalAvsnitt = podd.AvsnittLista.Count.ToString();

                        ListViewItem katLista = new ListViewItem(podd.Namn);
                        katLista.SubItems.Add(antalAvsnitt);
                        katLista.SubItems.Add(podd.UppdateringsFrekvens);
                        katLista.SubItems.Add(podd.Kategori);

                        lvPodcast.Items.Add(katLista);

                        Console.WriteLine(katLista);

                    }
                }

            }
        }
    }

}










//int valdPoddIndex = lvPodcast.SelectedItems.IndexOf(ListViewItem selectedPodcast);

//if (lvPodcast.SelectedIndex)
//    podcastController.DeletePodcast(namn);
//Console.WriteLine(namn + " är borttagen");


//
////int valdPodd = selectedPodcast ? lvPodcast.SelectedItems[0].Index :[" "] ;
//string poddNamn = lvPodcast.SelectedItems[0].ToString();

//foreach (ListViewItem podd in lvPodcast.SelectedItems)
//{
//    
//}



//
//if (selectedPodcast > 0)
//{


//DialogResult confirmation = MessageBox.Show("Är du säker att du vill ta bort " + poddNamn + "?" + MessageBoxButtons.YesNo);
//if (confirmation == DialogResult.Yes) { 
//IndexOf(valdPodd);
//

//}

//}

//public int IndexOf(ListViewItem item)
//{
//    int valdPodd = IndexOf(item);
//    return valdPodd;
//}




