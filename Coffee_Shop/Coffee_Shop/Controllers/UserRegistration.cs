using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.DALModels;
using Coffee_Shop.Models.UserRegistration;
using Coffee_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{
    public class UserRegistrationController : Controller
    {

        
        private readonly ShopContext _shopContext;

        public UserRegistrationController(ShopContext shopContext)
        {
            
            _shopContext = shopContext;
        }

        public IActionResult RegisterUserForm()
        {
            return View();
        }

        public IActionResult RegisterUserFormResult(RegisterUserFormViewModel model)
        {
            var user = new UserDAL();
            user.userName = model.userName;
            user.password = model.password;


            MakeNewUser(user);
            var view = new RegisterUserFormResultViewModel();
            view.user = user;

            return View(view);
            
        }

        public IActionResult DisplayUserInfo(string userName)
        {
            var model = new RegisterUserFormResultViewModel();
            var listOfUsers = _shopContext.Users.ToList();
            foreach (var user in listOfUsers)
            {
                if (user.userName == userName)
                {
                    model.user = user;
                }
            }

            return View(model);
        }

        public IActionResult Login()
        {
            return View();            
        }

        public IActionResult LoginResult(LoginViewModel model)
        {
            var listOfUsers = _shopContext.Users.ToList();

            UserDAL userDAL = _shopContext.Users
                .Where(user => user.userName == model.userName && user.password == model.password)
                .FirstOrDefault();
            if (userDAL.userID > 0)
            {
                RedirectToAction("ViewCatalog", "Shop", userDAL.userID);
            }
            else
            {
                RedirectToAction("LoginError", "UserRegistration");
            }
            return View();
        }

        public IActionResult LoginError()
        {
            return View();
        }

        public void MakeNewUser(UserDAL user)
        {
            _shopContext.Users.Add(user);
            _shopContext.SaveChanges();
            return;
        }
      
    }
}