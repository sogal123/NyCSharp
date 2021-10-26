using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DataAccessLayer;


namespace DataAccessLayer.Repository
{
    public class PodcastRepository : IRepository<Podcast>
    {
        DataManager dataManager;
        List<Podcast> podcastLista;
        public PodcastRepository()
        {
            dataManager = new DataManager();
            podcastLista = GetAll();
            podcastLista = new List<Podcast>();
        }

        public void Create(Podcast podcast)
        {
            podcastLista.Add(podcast);
            SaveChanges();
        }

        public void Delete(int index)
        {
            if (index >= 0)
            {
                podcastLista.RemoveAt(index);
                SaveChanges();
            }
        }

        public List<Podcast> GetAll()
        {
            return dataManager.DeserializePodcast();
        }

        public void Update(int index, Podcast podcast)
        {
            if (index >= 0)
            {
                podcastLista[index] = podcast;
            }
            SaveChanges();
        }
        public void SaveChanges()
        {
            dataManager.SerializePodcast(podcastLista);
        }
    }
}
