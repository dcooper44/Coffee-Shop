using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.DALModels;
using Coffee_Shop.Models.Shop;
using Coffee_Shop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Coffee_Shop.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ShopContext _shopContext;

        public ShopController(ShopContext shopContext, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _shopContext = shopContext;
        }


        public IActionResult ViewCatalog()
        {
            var view = new ViewCatalogViewModel();            
            
            view.isUserLoggedIn = true;
            view.userID = _userManager.GetUserId(User);
            
            
            var listOfItems = _shopContext.Items.ToList();

            view.ListOfitems = listOfItems;


            return View(view);
        }

        public IActionResult PurchaseItems(string productID)
        {
            

            FundsDAL fundsDAL = _shopContext.Funds
                .Where(user => user.Id == _userManager.GetUserId(User))
                .FirstOrDefault();

            ItemsDAL itemDAL = _shopContext.Items
                .Where(item => item.itemID == productID)
                .FirstOrDefault();

            if (fundsDAL.userFunds > itemDAL.price)
            {                
                fundsDAL.userFunds =- itemDAL.price;
                _shopContext.Funds.Update(fundsDAL);
                _shopContext.SaveChanges();

                itemDAL.quantity = -1;
                _shopContext.Items.Update(itemDAL);
                _shopContext.SaveChanges();

                var model = new PurchaseSuccessfulViewModel();
                model.userID = fundsDAL.Id;
                model.itemPrice = itemDAL.price;
                model.userFunds = fundsDAL.userFunds;
                //var userItemsController = new UserItemsController(_shopContext, _userManager); 
                //userItemsController.StoreUserItem(itemDAL.itemID);

                //var purchasedItem = new PurchasedItemsDAL()
                //{
                //    ItemId = itemDAL.itemID,
                //    UserId = fundsDAL.Id
                //};

                //_shopContext.PurchasedItems.Add(purchasedItem);
                //_shopContext.SaveChanges();


                return View("PurchaseSuccessful", model);

            }
            else
            {
                var model = new InsufficientFundsViewModel();
                model.userID = _userManager.GetUserId(User);
                model.itemPrice = itemDAL.price;
                model.userFunds = fundsDAL.userFunds;

                return View("InsufficientFunds", model);
            }
            

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

            FundsDAL fundsDAL = _shopContext.Funds
                .Where(user => user.Id == _userManager.GetUserId(User))
                .FirstOrDefault();

            ItemsDAL itemDAL = _shopContext.Items
                .Where(item => item.itemID == view.itemID)
                .FirstOrDefault();

            model.userFunds = fundsDAL.userFunds;
            model.userID = view.userID;
            model.itemName = itemDAL.name;
            model.itemPrice = itemDAL.price;

            return View(model);
        }
    }
}