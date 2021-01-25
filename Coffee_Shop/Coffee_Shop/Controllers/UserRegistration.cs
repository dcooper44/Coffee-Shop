using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.Models.UserRegistration;
using Coffee_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{
    public class UserRegistrationController : Controller
    {

        private IUserInfo _listOfUsers;

        public UserRegistrationController(IUserInfo listOfUsers)
        {
            _listOfUsers = listOfUsers;
        }

        public IActionResult RegisterUserForm()
        {
            return View();
        }

        public IActionResult RegisterUserFormResult(RegisterUserFormViewModel model)
        {
            var user = new userInfo();
            user.userName = model.userName;
            user.password = model.password;
            user.email = model.email;
            user.dateOfBirth = model.dateOfBirth;
            user.homeState = model.homeState;

            _listOfUsers.Users.Add(user);

            var view = new RegisterUserFormResultViewModel();
            view.user = user;

            return View(view);
            
        }

        public IActionResult DisplayUserInfo(string userName)
        {
            var model = new RegisterUserFormResultViewModel();

            foreach (var member in _listOfUsers.Users)
            {
                if (member.userName == userName)
                {
                    model.user = member;
                }
            }

            return View(model);
        }
      
    }
}