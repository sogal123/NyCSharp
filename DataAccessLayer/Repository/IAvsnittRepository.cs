using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    
    public interface IAvsnittRepository<T> where T : Avsnitt
    {
        Task<List<T>> HämtaAllaAvsnitt(string url);
        
    }
}
