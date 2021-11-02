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

        //hej
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
            //try
            //{
            //        podcastLista = dataManager.DeserializePodcast();
            //        Podcast podd = podcastLista(url);
            //        avsnittLista = podd.AvsnittLista;
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message + " Kan inte hitta vald podcasts avsnittslista");
            //}
            //return avsnittLista;
        }
    }
}
        //}

        //public List<Avsnitt> HämtaAllaAvsnitt(string url)
        //{
            
        //    try {
        //        //Podcast podd = new Podcast();

        //        podcastLista = dataManager.DeserializePodcast();
        //        Podcast podd = podcastLista[url]:
        //            if ( url == podd.Url) {
        //        }
        //        podd.Add(avsnitt);

        //            }
        //    catch ()
        //    {

        //    }
        //    return 
           
        //}
    


//public List<Podcast> GetAll()
//{
//    List<Podcast> podcastLista = new List<Podcast>();
//    try
//    {
//        podcastLista = dataManager.DeserializePodcast();
//    }
//    catch (SerializerException error)
//    {
//        Console.WriteLine(error.Message + ". Ingen lista att returnera");
//    }
//    return podcastLista; 
