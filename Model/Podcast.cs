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
        public List<Avsnitt> Avsnitt { get; set; }

        public Podcast(string namn, string url, string uppdateringsFrekvens, string kategori, List<Avsnitt> avsnitt) /*  List<Avsnitt> avsnitt*/
        {
            Namn = namn;
            UppdateringsFrekvens = uppdateringsFrekvens;
            Url = url;
            Kategori = kategori;
            Avsnitt = avsnitt;
        }

        public Podcast()
        {
        }
    }
}