using System;
using Model;
using System.Collections.Generic;
using System.Text;



namespace DataAccessLayer.Repository
{
    public class KategoriRepository : IRepository<Kategori>
    {
        DataManager dataManager;
        List<Kategori> kategoriLista;
        public KategoriRepository()
        {
            dataManager = new DataManager();
            kategoriLista = GetAll();
            kategoriLista = new List<Kategori>();
        }

        public void Create(Kategori kategori)
        {
            kategoriLista.Add(kategori);
            SaveChanges();
        }

        public void Delete(int index)
        {
            if (index >= 0)
            {
                kategoriLista.RemoveAt(index);
                SaveChanges();
            }
        }

        public List<Kategori> GetAll()
        {
            return dataManager.DeserializeKategori();
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