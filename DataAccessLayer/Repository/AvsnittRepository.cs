using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DataAccessLayer;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class AvsnittRepository : IAvsnittRepository<Avsnitt>
    {
        public List<Avsnitt> avsnittLista;
        public List<Podcast> podcastLista;
        public DataManager dataManager;

        
        public AvsnittRepository()
        {
            podcastLista = new List<Podcast>();
            avsnittLista = new List<Avsnitt>();
        }
        public async Task <List<Avsnitt>> HämtaAllaAvsnitt(string url)
        {
            {

                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed data = await Task.Run(() => SyndicationFeed.Load(reader));
                
                List<Avsnitt> listaAvsnitt = new List<Avsnitt>();
                foreach (var item in data.Items)
                {
                    Avsnitt avsnitt = new Avsnitt();
                    avsnitt.Namn = item.Title.Text;
                    avsnitt.AvsnittsBeskrivning = item.Summary.Text;
                    listaAvsnitt.Add(avsnitt);
                }
                return listaAvsnitt;
            }
           
        }
    }
}
   