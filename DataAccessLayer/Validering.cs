using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Syndication;

 


namespace DataAccessLayer
{
    class Validering
    {
        public static bool checkDuplicate(string url)
        {
            bool korrekt = true;
            try
            {
                DataManager dataManager = new DataManager();
                var podcastLista = dataManager.DeserializePodcast();
                foreach (var podcast in podcastLista)
                {
                    if (podcast.Namn.Equals(url))
                    {
                        korrekt = false;
                        //throw new DuplicateException();
                    }
                    korrekt = true;
                }
            }
            catch //(DuplicateException)
            {
                korrekt = false;
            }
            return korrekt;
        }


    }
}
