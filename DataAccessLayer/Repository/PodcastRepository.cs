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

        public void Update(string url, Podcast podcast)
        {
            if (podcast.Url.Equals(url))
            {
                //podcastLista[i] = podcast;
                SaveChanges();
               
            }
            
            Console.WriteLine(podcast.Namn + " Är sparad" + podcast.Url + " " + podcast.UppdateringsFrekvens);

        }
        public void SaveChanges()
        {
            dataManager.SerializePodcast(podcastLista);
            Console.WriteLine(" sparades i repository!");
        }

        public void DeleteAllPodcastsByCategory(string podcast)
        {
            var podquery = from kat in podcastLista
                           where kat.Kategori != podcast
                           select kat;
            podcastLista = podquery.ToList();

            SaveChanges();
            
        }
    }
}
