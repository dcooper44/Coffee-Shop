using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.DALModels;
using Coffee_Shop.Models.Shop;
using Coffee_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{
    public class ShopController : Controller
    {

       
        private readonly ShopContext _shopContext;

        public ShopController(ShopContext shopContext)
        {
            
            _shopContext = shopContext;
        }


        public IActionResult ViewCatalog(int userID)
        {
            var view = new ViewCatalogViewModel();

            if(userID > 0)
            {
                view.isUserLoggedIn = true;
                view.userID = userID;
            }
            else
            {
                view.isUserLoggedIn = false;
            }
            var listOfItems = _shopContext.Items.ToList();

            view.ListOfitems = listOfItems;


            return View(view);
        }

        public IActionResult PurchaseItems(int userID, int productID, double productPrice)
        {
            

            UserDAL userDAL = _shopContext.Users
                .Where(user => user.userID == userID)
                .FirstOrDefault();

            ItemsDAL itemDAL = _shopContext.Items
                .Where(item => item.itemID == productID)
                .FirstOrDefault();

            if (userDAL.userFunds > productPrice)
            {                
                userDAL.userFunds =- productPrice;
                _shopContext.Users.Update(userDAL);

                itemDAL.quantity = -1;
                _shopContext.Items.Update(itemDAL);

                var model = new PurchaseSuccessfulViewModel();
                model.userID = userID;
                model.itemPrice = productPrice;
                model.userFunds = userDAL.userFunds;
                RedirectToAction("PurchaseSuccessful", "Shop", model);
            }
            else
            {
                var model = new InsufficientFundsViewModel();
                model.userID = userID;
                model.itemPrice = productPrice;
                model.userFunds = userDAL.userFunds;

                RedirectToAction("InsufficientFunds", "Shop", model);
            }
            return View();

        }

        public IActionResult InsufficientFunds(InsufficientFundsViewModel model)
        {

            var view = new InsufficientFundsViewModel();
            view.userID = model.userID;
            view.userFunds = model.userFunds;
            view.itemPrice = model.itemPrice;


            return View(view);
        }

        public IActionResult PurchaseSuccessful(PurchaseSuccessfulViewModel view)
        {
            var model = new PurchaseSuccessfulViewModel();

            UserDAL userDAL = _shopContext.Users
                .Where(user => user.userID == view.userID)
                .FirstOrDefault();

            ItemsDAL itemDAL = _shopContext.Items
                .Where(item => item.itemID == view.itemID)
                .FirstOrDefault();

            model.userFunds = userDAL.userFunds;
            model.userID = view.userID;
            model.itemName = itemDAL.name;
            model.itemPrice = itemDAL.price;

            return View(model);
        }
    }
}