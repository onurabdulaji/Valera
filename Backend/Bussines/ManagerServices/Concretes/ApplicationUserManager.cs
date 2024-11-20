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
    public class ApplicationUserManager : BaseManager<ApplicationUser>, IApplicationUserManager
    {
        IApplicationUserRepository _applicationUserRepository;
        public ApplicationUserManager(IApplicationUserRepository applicationUserRepository)
            : base(applicationUserRepository) // Passing the repository to the base constructor
        {
            _applicationUserRepository = applicationUserRepository;
        }

        public async Task<bool> TCreateUser(ApplicationUser item, string Password)
        {
            if (string.IsNullOrEmpty(item.Email) || string.IsNullOrEmpty(item.UserName) || string.IsNullOrEmpty(Password))
            {
                return false; 
            }

            if (!IsValidEmail(item.Email))
            {
                return false; 
            }

            if (!IsValidPassword(Password))
            {
                return false; 
            }
            return await _applicationUserRepository.AddUser(item, Password);
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email; 
            }
            catch
            {
                return false; 
            }
        }
        private bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }
    }
}