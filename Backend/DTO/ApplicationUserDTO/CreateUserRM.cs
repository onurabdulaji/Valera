using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ApplicationUserDTO
{
    public class CreateUserRM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password not confirmed !")]
        public string ConfirmPassword { get; set; }

    }
}
