using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DataAccessLayer;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class PodcastRepository : IRepository<Podcast>
    {
        DataManager dataManager;
        List<Podcast> podcastLista;
        public PodcastRepository()
        {
            podcastLista = new List<Podcast>();
            dataManager = new DataManager();
            podcastLista = GetAll();

        }

        public void Create(Podcast podcast)
        {
            podcastLista.Add(podcast);
            SaveChanges();
        }

        public void Delete(string podcast)
        {
            var podquery = from pod in podcastLista
                           where pod.Namn != podcast
                           select pod;
            podcastLista = podquery.ToList();

            SaveChanges();

        }

        public List<Podcast> GetAll()
        {
            List<Podcast> podcastLista = new List<Podcast>();
            try
            {
                podcastLista = dataManager.DeserializePodcast();
            }
            catch (SerializerException error)
            {
                Console.WriteLine(error.Message + ". Ingen lista att returnera");
            }
            return podcastLista;
        }

        public void Update(int i, Podcast podcast)
        {
            if (i >= 0)
            {
                podcastLista[i] = podcast;

            }
            SaveChanges();

        }
        public void SaveChanges()
        {
            dataManager.SerializePodcast(podcastLista);
            Console.WriteLine("Ticker för 10 sekunder fungerar");

        }

        public List<Podcast> UppdateringsFrekvens60Sek()
        {

            var poddar60sek = new List<Podcast>();
            try
            {
                foreach (Podcast podd in podcastLista)
                {
                    if (podd.UppdateringsFrekvens.Equals("1min"))
                    {
                        poddar60sek.Add(podd);

                     }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Hittar inga podcast inom det angivna intervallet. " + error.Message);
            }

            return poddar60sek;
        }
            
        

       
    }
}
