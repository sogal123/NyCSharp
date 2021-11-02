using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<List<Avsnitt>> HämtaAllaAvsnitt(string url)
        {
            return await avsnittRepository.HämtaAllaAvsnitt(url);
        }


    }
}
