using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Kategori
    {
        //public override string TypAvEntitet()
        //{
        //    return "Objektet är en kategori";
        //}

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
