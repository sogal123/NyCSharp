﻿using System;
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
        public async void CreatePodcast(string namn, string url, string uppdateringsFrekvens, string kategori)
        {
            //Podcast podd = new Podcast();
            
            List<Avsnitt> avsnittLista =  await avsnittRepository.HämtaAllaAvsnitt(url);

            Podcast podcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnittLista);
            podcastRepository.Create(podcast);
        }
        
        public void DeletePodcast(string podcast)
        {
            podcastRepository.Delete(podcast);
        }

        //Används inte?
        public string GetPodcastAtIndex(int i)
        {
            var podcastLista = podcastRepository.GetAll();
            Podcast podd = podcastLista[i];
            string poddnamn = podd.Namn;
            return poddnamn;
        }

        //Används inte?
        public string GetPodcastUrlAtIndex(int i)
        {
            var podcastLista = podcastRepository.GetAll();
            Podcast valdPodcast = podcastLista[i];
            string valdPodcastUrl = valdPodcast.Url;
            return valdPodcastUrl;

        }

        public  void UpdatePodcast(int valdPodcast, string namn, string url, string uppdateringsFrekvens, string kategori)
        {
            try
            {
                Podcast podd = podcastList[valdPodcast];
                podd.Namn = namn;
                podd.Url = url;
                podd.UppdateringsFrekvens = uppdateringsFrekvens;
                podd.Kategori = kategori;


                podcastRepository.Update(valdPodcast, podd);

                
            }
            catch (Exception error)
            {
                Console.WriteLine("Hittar inte podd" + error.Message);
            }
        }

        //public List<Podcast> poddarMed1minFrekvens()
        //{
        //    return podcastRepository.UppdateringsFrekvens60Sek();
        //}

        }
    }

