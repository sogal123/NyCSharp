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
        public int UppdateringsFrekvens { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> AvsnittLista { get; set; }

        public Podcast(string namn,  string url, int uppdateringsFrekvens) /* string kategori, List<Avsnitt> avsnitt*/
        {
            Namn = namn;
            UppdateringsFrekvens = uppdateringsFrekvens;
            Url = url;
            //Kategori = kategori;
            //AvsnittLista = avsnitt;

        }

        public Podcast()
        {
        }

    }
}

