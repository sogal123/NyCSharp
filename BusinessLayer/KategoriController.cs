﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class KategoriController
    {
        readonly IRepository<Kategori> kategoriRepository;
        List<Kategori> kategoriLista;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }
    
    public void CreateKategori(Kategori kategori)
        {
            kategoriRepository.Create(kategori);
        }

    public void DeleteKategori(int index)
        {
            kategoriRepository.Delete(index);
        }

    public void UpdateKategori(int index)
        {
            kategoriRepository.Update(index);
        }
    
        
    }
}
