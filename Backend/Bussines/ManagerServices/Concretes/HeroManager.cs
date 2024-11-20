using Bussines.ManagerServices.Abstracts;
using DataAccess.Repositories.Abstracts;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.ManagerServices.Concretes
{
    public class HeroManager : BaseManager<Hero>, IHeroManager
    {
        IHeroRepository _heroRepository;

        public HeroManager(IHeroRepository heroRepository) : base(heroRepository)
        {
            {
                _heroRepository = heroRepository;
            }
        }
    }
}
