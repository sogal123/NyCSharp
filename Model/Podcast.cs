using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Model
{
    [Serializable, XmlRoot("Podcasts")]
    public class Podcast : Feed
    {


        public string Namn { get; set; }
        public string Url { get; set; }
        public string UppdateringsFrekvens { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> AvsnittLista { get; set; }


        public Podcast(string namn, string url, string uppdateringsFrekvens, string kategori, List<Avsnitt> avsnitt)
        {
            Namn = namn;
            UppdateringsFrekvens = uppdateringsFrekvens;
            Url = url;
            Kategori = kategori;
            AvsnittLista = avsnitt;

        }

        public Podcast()
        {
        }

        public override string FeedTyp()
        {
            return "Detta objekt är en Podcast";
        }

        


    }
}

