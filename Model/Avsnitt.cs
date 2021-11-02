using System;
using System.Xml.Serialization;

namespace Model
{
    [Serializable, XmlRoot("Avsnitt")]
    public class Avsnitt
    {

        public string Namn { get; set; }
        public string AvsnittsBeskrivning { get; set; }


        public Avsnitt()
        {

        }
    }
}
