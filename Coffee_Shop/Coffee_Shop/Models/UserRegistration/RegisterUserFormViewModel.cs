using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models.UserRegistration
{
    public class RegisterUserFormViewModel
    {
        public string userName { get; set; }


        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        public string password { get; set; }

        public DateTime dateOfBirth { get; set; }

        public string homeState { get; set; }

    }
}
