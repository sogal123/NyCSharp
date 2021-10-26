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
       
            PodcastRepository podcastRepository;
            List<Podcast> podcastList;
            public PodcastController()
            {
                podcastRepository = new PodcastRepository();
                podcastList = podcastRepository.GetAll();


            }

        }

    }

