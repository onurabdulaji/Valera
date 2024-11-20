using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        Task<bool> AddUser(ApplicationUser item, string Password);
    }
}
