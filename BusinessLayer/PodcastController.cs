using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class PodcastController 
    {
       
            IRepository<Podcast> podcastRepository;
            List<Podcast> podcastList;

            public PodcastController()
            {
                podcastRepository = new PodcastRepository();
                podcastList = podcastRepository.GetAll();


            }

        public List <Podcast> getAll()
        {
            return podcastRepository.GetAll();
        }
        public void CreatePodcast(string namn, string url, string uppdateringsFrekvens, string kategori)
        {/*, string kategori, List<Avsnitt> avsnitt*/
            Podcast podcast = new Podcast(namn, url, uppdateringsFrekvens, kategori); /*,  , avsnitt*/
            podcastRepository.Create(podcast);
        }
        
        public void DeletePodcast(int i)
        {
            podcastRepository.Delete(i);
        }

        public string GetPodcastAtIndex(int i)
        {
            var podcastLista = podcastRepository.GetAll();
            Podcast podd = podcastLista[i];
            string poddnamn = podd.Namn;
            return poddnamn;
        }

        public string GetPodcastUrlAtIndex(int i)
        {
            var podcastLista = podcastRepository.GetAll();
            Podcast valdPodcast = podcastLista[i];
            string valdPodcastUrl = valdPodcast.Url;
            return valdPodcastUrl;

        }

        public  void UpdatePodcast(int valdPodcast, string namn, string url, string uppdateringsFrekvens, string kategori)
        {
            var podcastLista = podcastRepository.GetAll();

            Podcast podd = podcastLista[valdPodcast];
            namn = podd.Namn;
            url = podd.Url;
            uppdateringsFrekvens = podd.UppdateringsFrekvens;
            kategori = podd.Kategori;

           
            podcastRepository.Update(valdPodcast, podd);
        }
        }

    }

