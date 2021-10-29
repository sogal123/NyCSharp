using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class KategoriController
    {
        KategoriRepository kategoriRepository;
        List<Kategori> kategoriLista;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
            kategoriLista = kategoriRepository.GetAll();
        }
       
        public List<Kategori> GetAll()
        {
            return kategoriRepository.GetAll();
        }
        
    
    public void CreateKategori(Kategori kategori)
        {
            kategoriRepository.Create(kategori);
        }

    public void DeleteKategori(string kategori)
        {
            kategoriRepository.Delete(kategori);
        }


    public void UpdateKategori(int index, Kategori kategori)
        {
            kategoriRepository.Update(index, kategori);
        }
    
        
    }
}
