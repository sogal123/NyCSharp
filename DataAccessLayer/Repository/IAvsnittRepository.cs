using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    
    public interface IAvsnittRepository<T> where T : Avsnitt
    {
        List<T> HämtaAllaAvsnitt(string url);
        
    }
}
