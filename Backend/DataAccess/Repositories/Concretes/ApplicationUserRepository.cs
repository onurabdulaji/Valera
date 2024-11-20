using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concretes;
using Entity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concretes
{
    public class ApplicationUserRepository : BaseRepository<ApplicationUser>, IApplicationUserRepository
    {

        UserManager<ApplicationUser> _userManager;
        public ApplicationUserRepository(MyContext db , UserManager<ApplicationUser> userManager) : base(db)
        {
            _userManager = userManager;
        }

        public async Task<bool> AddUser(ApplicationUser item, string Password)
        {
            IdentityResult result = await _userManager.CreateAsync(item, Password);
            if (result.Succeeded) 
            {
                return true;
            }
            return false;
        }
    }
}
