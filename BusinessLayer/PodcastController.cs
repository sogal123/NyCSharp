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
        AvsnittRepository avsnittRepository;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            podcastList = podcastRepository.GetAll();
            avsnittRepository = new AvsnittRepository();

        }

        public List<Podcast> getAll()
        {
            return podcastRepository.GetAll();
        }
        public void CreatePodcast(string namn, string url, string uppdateringsFrekvens, string kategori)
        {
            List<Avsnitt> avsnittLista = avsnittRepository.HämtaAllaAvsnitt(url);

            Podcast podcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnittLista);
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

        public void UpdatePodcast(int valdPodcast, string namn, string url, string uppdateringsFrekvens, string kategori)
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