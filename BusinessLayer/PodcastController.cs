using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class PodcastController 
    {
       
            PodcastRepository podcastRepository;
            List<Podcast> podcastList;
            AvsnittRepository avsnittRepository;

            public PodcastController()
            {
                podcastRepository = new PodcastRepository();
                podcastList = podcastRepository.GetAll();
                avsnittRepository = new AvsnittRepository();
                  
            }

        public List <Podcast> getAll()
        {
            return podcastRepository.GetAll();
        }
        public async Task<Podcast> CreatePodcast(string namn, string url, string uppdateringsFrekvens, string kategori)
        {
            
            Podcast podd = new Podcast();
            await Task.Run(async () =>
            {
                List<Avsnitt> avsnittLista = await avsnittRepository.HämtaAllaAvsnitt(url);

                Podcast podcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnittLista);
                podcastRepository.Create(podcast);
            });

            return podd;
        }        
       
        public void DeletePodcast(string podcast)
        {
            podcastRepository.Delete(podcast);
        }

        
        public void UpdatePodcast(int valdPodd, string namn, string url, string uppdateringsFrekvens, string kategori)
        {
            try
            {
                var podcastLista = podcastRepository.GetAll();
                Podcast podd = podcastLista[valdPodd];

                podd.Namn = namn;
                podd.Url = url;
                podd.UppdateringsFrekvens = uppdateringsFrekvens;
                podd.Kategori = kategori;
                Console.WriteLine(podd.Namn + " är sparad!");
                
                podcastRepository.Update(valdPodd, podd);

                
            }
            catch (Exception error)
            {
                Console.WriteLine("Hittar inte podd" + error.Message);
            }
        }

      
          public void DeleteAllPodcastsByCategory(string podcast)
        {
            podcastRepository.DeleteAllPodcastsByCategory(podcast);
        }

    }
    }

