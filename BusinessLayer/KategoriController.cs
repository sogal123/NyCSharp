using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class KategoriController
    {
        readonly IRepository<Kategori> kategoriRepository;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }
    
    
    public void CreateKategori(Kategori kategori)
        {
      
            kategoriRepository.Create(kategori);
            
        }
    
        
    }
}
