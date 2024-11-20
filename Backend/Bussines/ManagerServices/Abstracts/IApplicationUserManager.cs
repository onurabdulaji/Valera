using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.ManagerServices.Abstracts
{
    public interface IApplicationUserManager : IManager<ApplicationUser>
    {
        Task<bool> TCreateUser(ApplicationUser item, string Password);
    }
}
