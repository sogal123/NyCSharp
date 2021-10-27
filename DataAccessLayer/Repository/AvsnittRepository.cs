using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DataAccessLayer;

namespace DataAccessLayer.Repository
{
    public class AvsnittRepository
    {
        public List<Avsnitt> avsnittLista;
        public List<Podcast> podcastLista;
        public DataManager dataManager;

        public List<Avsnitt> GetAll(int i)
        {
            try
            {
                podcastLista = dataManager.DeserializePodcast();
                Podcast podd = podcastLista[i];
                avsnittLista = podd.Avsnitt; 
            }
        }
    }
}
