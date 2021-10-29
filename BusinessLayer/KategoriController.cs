using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class KategoriController
    {
        IRepository<Kategori> kategoriRepository;
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

    public void DeleteKategori(int index)
        {
            kategoriRepository.Delete(index);
        }

    public void UpdateKategori(int index, Kategori kategori)
        {
            kategoriRepository.Update(index, kategori);
        }
    
        
    }
}
