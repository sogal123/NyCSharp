using System;
using System.Collections.Generic;
using DataAccessLayer.Repository;
using Model;

namespace BusinessLayer
{
    public class AvsnittController
    {
        private AvsnittRepository avsnittRepository;

        public AvsnittController()
        {
            avsnittRepository = new AvsnittRepository();
        }
    }
}