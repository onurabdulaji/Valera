using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concretes
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository(MyContext db) : base(db)
        {
        }
    }
}
