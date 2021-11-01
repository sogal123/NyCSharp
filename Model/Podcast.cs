using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Model
{
    [Serializable, XmlRoot("Podcasts")]
    public class Podcast
    {


        public string Namn { get; set; }
        public string Url { get; set; }
        public string UppdateringsFrekvens { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> AvsnittLista { get; set; }
        public DateTime NästaUppdatering { get; set;  }

        public Podcast(string namn,  string url, string uppdateringsFrekvens, string kategori, List<Avsnitt> avsnitt, DateTime nästauppdatering) 
        {
            Namn = namn;
            UppdateringsFrekvens = uppdateringsFrekvens;
            Url = url;
            Kategori = kategori;
            AvsnittLista = avsnitt;
            NästaUppdatering = nästauppdatering;
        }

        public Podcast()
        {
        }

        public void Uppdatera()
        {
            //double frekvens = Convert.ToDouble(UppdateringsFrekvens);
            //NästaUppdatering = DateTime.Now.AddMilliseconds(frekvens);

        }
        public bool BehöverUppdateras()
        {
            return NästaUppdatering <= DateTime.Now;
        }

        
    }
}

