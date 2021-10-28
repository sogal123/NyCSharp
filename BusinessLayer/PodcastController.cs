using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DataAccessLayer;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class PodcastController
    {
        private IRepository<Podcast> podcastRepository;
        private List<Podcast> podcastList;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            podcastList = podcastRepository.GetAll();
        }

        public List<Podcast> getAll()
        {
            return podcastRepository.GetAll();
        }

        public async Task CreatePodcastAsync(string namn, string url, string uppdateringsFrekvens, string kategori)
        {/*, string kategori, List<Avsnitt> avsnitt*/
            //Podcast podcast = new Podcast(namn, url, uppdateringsFrekvens, kategori); /*,  , avsnitt*/
            //podcastRepository.Create(podcast);

            await Task.Run(() =>
            {
                var avsnitt = hamtaAvsnittForPodcast(url);
                Podcast podcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnitt);

                podcastRepository.Create(podcast);
            });
        }

        public void DeletePodcast(int i)
        {
            podcastRepository.Delete(i);
        }

        public string GetPodcastAtIndex(int i)
        {
            var podcastLista = podcastRepository.GetAll();
            Podcast podd = podcastLista[i];
            string poddnamn = podd.Namn;
            return poddnamn;
        }

        public List<Avsnitt> hamtaAvsnittForPodcast(string url)
        {
            List<Avsnitt> episodes = new List<Avsnitt>();
            XDocument urlDocument = new XDocument();
            try
            {
                {
                    urlDocument = XDocument.Load(url);
                    episodes = (from x in urlDocument.Descendants("item")
                                select new Avsnitt
                                {
                                    Namn = x.Element("title").Value,
                                    AvsnittsBeskrivning = x.Element("description").Value
                                }).ToList();
                };
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Network unavailable.");
            }
            return episodes;
        }

        //public string GetPodcastUrlAtIndex(int i)
        //{
        //    var podcastLista = podcastRepository.GetAll();
        //    Podcast podd = podcastLista[i];
        //    string URL = Convert.ToString(i);
        //    string url =

        //}
    }
}