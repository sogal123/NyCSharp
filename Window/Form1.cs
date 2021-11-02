using BusinessLayer;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Window
{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        List<Podcast> podcastLista;
        AvsnittController avsnittController;
        KategoriController kategoriController;

        string valdPodd;
        string valdKategori;


        public System.Timers.Timer enMinutTimer { get; set; }
        public System.Timers.Timer tvåMinuterTimer { get; set; }
        public System.Timers.Timer treMinuterTimer { get; set; }
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            avsnittController = new AvsnittController();
            kategoriController = new KategoriController();
            podcastLista = podcastController.getAll();

            enMinutTimer = new System.Timers.Timer();
            tvåMinuterTimer = new System.Timers.Timer();
            treMinuterTimer = new System.Timers.Timer();

            fyllFeed();
            fyllCb();
            fyllKategori();
            Timer();
        }

        private void Timer()
        {
            {

                enMinutTimer = new System.Timers.Timer(10000);
                enMinutTimer.Enabled = true;
                enMinutTimer.AutoReset = true;
                enMinutTimer.Elapsed += Timer_TickEnMinut;
                enMinutTimer.Start();

                tvåMinuterTimer = new System.Timers.Timer(30000);
                tvåMinuterTimer.Enabled = true;
                tvåMinuterTimer.AutoReset = true;
                tvåMinuterTimer.Elapsed += Timer_TickTvåMinuter;
                tvåMinuterTimer.Start();


                treMinuterTimer = new System.Timers.Timer(60000);
                treMinuterTimer.Enabled = true;
                treMinuterTimer.AutoReset = true;
                treMinuterTimer.Elapsed += Timer_TickTreMinuter;
                treMinuterTimer.Start();


                Console.WriteLine("Timermetod körs från konstruktor");
            }
        }

        private void Timer_TickEnMinut(object sender, EventArgs e)
        {
            foreach (var podd in podcastLista)
            {
                if (podd.UppdateringsFrekvens.Equals("1min"))
                {
                    Console.WriteLine("Podcast med 10 sekunders uppdateringsfrekvens har uppdaterats " + DateTime.Now + " " + podd.Namn);

                }
            }
        }

        private void Timer_TickTvåMinuter(object sender, EventArgs e)
        {
            foreach (var podd in podcastLista)
            {
                if (podd.UppdateringsFrekvens.Equals("2min"))
                {
                    Console.WriteLine("Podcast med 30 sekunders uppdateringsfrekvens har uppdaterats " + DateTime.Now + " " + podd.Namn);
                }
            }
        }

        private void Timer_TickTreMinuter(object sender, EventArgs e)
        {

            foreach (var podd in podcastLista)
            {
                if (podd.UppdateringsFrekvens.Equals("3min"))
                {

                    Console.WriteLine("Podcast med 60 sekunders uppdateringsfrekvens har uppdaterats " + DateTime.Now + " " + podd.Namn);

                }
            }
        }

        private async void btnNyPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                enMinutTimer.Stop();
                tvåMinuterTimer.Stop();
                treMinuterTimer.Stop();

                Validator.TommaCbs(" ", cbKategori.SelectedItem); Validator.TommaCbs(" ", cbFrekvens.SelectedItem);
                Validator.TommaTextFält(" ", tbUrl.Text); Validator.TommaTextFält(" ", tbNamn.Text);

                await podcastController.CreatePodcast(tbNamn.Text, tbUrl.Text, cbFrekvens.Text, cbKategori.Text);

                MessageBox.Show(tbNamn.Text + " är tillagd som podcast!");
                Console.WriteLine("Tillagd podcast " + tbNamn.Text);
                fyllFeed();
            }
            catch (Exception error)
            {
                Felmeddelande(error);
                Console.WriteLine(error.Message);
            }

        }


        private void Felmeddelande(Exception e)
        {
            MessageBox.Show("Något gick fel. " + e.Message);
        }



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

            cbFrekvens.Items.Add("10sek");
            cbFrekvens.Items.Add("30sek");
            cbFrekvens.Items.Add("60sek");
            cbFrekvens.SelectedIndex = 0;

            cbKategori.SelectedIndex = -1;
        }
        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {

            try
            {

                enMinutTimer.Stop();
                enMinutTimer.Stop();
                enMinutTimer.Stop();

                Validator.TommaCbs(" ", cbKategori.SelectedItem); Validator.TommaCbs(" ", cbFrekvens.SelectedItem);
                Validator.TommaTextFält(" ", tbUrl.Text); Validator.TommaTextFält(" ", tbNamn.Text);

                var selectedItem = lvPodcast.SelectedItems[0];
                int index = selectedItem.Index;


                string namn = tbNamn.Text;
                string url = tbUrl.Text;
                string uppdateringsFrekvens = cbFrekvens.Text;
                string kategori = cbKategori.Text;



                podcastController.UpdatePodcast(index, namn, url, uppdateringsFrekvens, kategori);
                MessageBox.Show("Podcast sparad!");

                fyllFeed();


                enMinutTimer.Start();
                tvåMinuterTimer.Start();
                treMinuterTimer.Start();

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

            enMinutTimer.Stop();
            tvåMinuterTimer.Stop();
            treMinuterTimer.Stop();

            lvPodcast.View = View.Details;
            lvPodcast.GridLines = true;
            lvPodcast.FullRowSelect = true;


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

                            enMinutTimer.Start();
                            tvåMinuterTimer.Start();
                            treMinuterTimer.Start();
                        }
                    }
                }
            }
        }

        private void lbAvsnittsLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvsnittsLista.SelectedItems.Count == 1)
            {
                enMinutTimer.Stop();
                tvåMinuterTimer.Stop();
                treMinuterTimer.Stop();
                var ettAvsnitt = lbAvsnittsLista.SelectedItems[0];

                foreach (var podd in podcastController.getAll())
                {

                    foreach (var avsnitt in podd.AvsnittLista)
                    {
                        if (avsnitt.Namn.Equals(ettAvsnitt))
                        {
                            tbBeskrivning.Text = avsnitt.AvsnittsBeskrivning;

                            enMinutTimer.Start();
                            tvåMinuterTimer.Start();
                            treMinuterTimer.Start();
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
                enMinutTimer.Stop();
                tvåMinuterTimer.Stop();
                treMinuterTimer.Stop();

                Validator.TommaTextFält(" ", tbNyKategori.Text);


                enMinutTimer.Start();
                tvåMinuterTimer.Start();
                treMinuterTimer.Start();

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
                enMinutTimer.Stop();
                tvåMinuterTimer.Stop();
                treMinuterTimer.Stop();

                Validator.TommaTextFält(" ", tbNyKategori.Text);
                string KategoriNamn = tbNyKategori.Text;

                Kategori kategori = new Kategori(KategoriNamn);
                kategoriController.CreateKategori(kategori);

                tbNyKategori.Text = string.Empty;
                MessageBox.Show(KategoriNamn + " tillagd som en kategori!");

                kategoriController.GetAll();
                fyllKategori();

                enMinutTimer.Start();
                tvåMinuterTimer.Start();
                treMinuterTimer.Start();
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
                enMinutTimer.Stop();
                tvåMinuterTimer.Stop();
                treMinuterTimer.Stop();

                var confirmation = MessageBox.Show("Are you sure you want to delete the podcast " + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation == DialogResult.OK)
                {

                    for (int i = lvPodcast.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        podcastController.DeletePodcast(valdPodd);
                        Console.WriteLine(i + "Podcasten är borttagen");
                        fyllFeed();

                        enMinutTimer.Start();
                        tvåMinuterTimer.Start();
                        treMinuterTimer.Start();
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
                enMinutTimer.Stop();
                tvåMinuterTimer.Stop();
                treMinuterTimer.Stop();

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
                                podcastController.DeleteAllPodcastsByCategory(valdKategori);
                                MessageBox.Show("Kategorin är borttagen");
                                fyllKategori();
                                fyllFeed();
                                lbAvsnittsLista.Items.Clear();
                                tbBeskrivning.Clear();
                                tbNyKategori.Clear();
                                tbNamn.Clear();
                                tbUrl.Clear();
                                cbKategori.ResetText();

                                enMinutTimer.Start();
                                tvåMinuterTimer.Start();
                                treMinuterTimer.Start();
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

        private void lbKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbKategori.SelectedItems.Count > 0)
            {

                enMinutTimer.Stop();
                tvåMinuterTimer.Stop();
                treMinuterTimer.Stop();

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

                        enMinutTimer.Start();
                        tvåMinuterTimer.Start();
                        treMinuterTimer.Start();

                    }
                }

            }
        }
    }

}