using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Model
{
    [Serializable, XmlRoot("Kategori")]
    public class Kategori
    {

        public string KategoriNamn { get; set; }

        public Kategori(string kategoriNamn)
        {
            KategoriNamn = kategoriNamn;
        }

        public Kategori()
        {
        }
    }
}
