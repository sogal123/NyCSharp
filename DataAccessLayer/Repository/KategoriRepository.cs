using System;
using Model;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.ExceptionClass;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class KategoriRepository : IRepository<Kategori>
    {
        DataManager dataManager;
        List<Kategori> kategoriLista;
        public KategoriRepository()
        {
            kategoriLista = new List<Kategori>(); 
            dataManager = new DataManager();
            kategoriLista = GetAll();
            
        }

        public void Create(Kategori kategori)
        {
            kategoriLista.Add(kategori);
            SaveChanges();
        }

        public void Delete(string kategori)
        {
            var katfråga = from kat in kategoriLista
                           where kat.KategoriNamn != kategori
                           select kat;
                           kategoriLista = katfråga.ToList();
            SaveChanges();
        }
       
        public List<Kategori> GetAll()
        {
            List<Kategori> podcastLista = new List<Kategori>();
            try
            {
                podcastLista = dataManager.DeserializeKategori();
            }
            catch (SerializerException error)
            {
                Console.WriteLine(error.Message + ". Ingen lista att returnera");
            }
            return podcastLista;
        }

        public void Update(int index, Kategori kategori)
        {
            if (index >= 0)
            {
                kategoriLista[index] = kategori;
            }
            SaveChanges();
        }
        public void SaveChanges()
        {
            dataManager.SerializeKategori(kategoriLista);
        }

        
    }
}