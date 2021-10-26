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
        public void CreatePodcast(string namn, string url)
        {/*, int uppdateringsFrekvens,, string kategori, List<Avsnitt> avsnitt*/
            Podcast podcast = new Podcast(namn, url); /*, uppdateringsFrekvens kategori, avsnitt*/
            podcastRepository.Create(podcast);
        }
        
        }

    }

