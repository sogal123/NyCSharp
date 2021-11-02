using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Kategori : Feed
    {

        public string KategoriNamn { get; set; }

        public Kategori(string kategoriNamn)
        {
            KategoriNamn = kategoriNamn;
        }

        public Kategori()
        {
        }

        public override string FeedTyp()
        {
            return "Detta objekt är en Kategori";

        }
    }
}
