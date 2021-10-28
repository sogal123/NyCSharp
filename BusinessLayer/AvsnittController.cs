using System;
using System.Collections.Generic;
using DataAccessLayer.Repository;
using Model; 

namespace BusinessLayer
{
    public class AvsnittController  
    {
        
        IAvsnittRepository<Avsnitt> avsnittRepository;
        

        public AvsnittController()
        {
            avsnittRepository = new AvsnittRepository();
            
        }

        public List<Avsnitt> HämtaAllaAvsnitt(string url)
        {
           return avsnittRepository.HämtaAllaAvsnitt(url);
        }


    }
}
