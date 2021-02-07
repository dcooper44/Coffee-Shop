using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.DALModels;
using Coffee_Shop.DomainModels;
using Coffee_Shop.Models.UserItems;
using Coffee_Shop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

//namespace Coffee_Shop.Controllers
//{
//    [Authorize]
//    public class UserItemsController : Controller
//    {
//        private readonly UserManager<IdentityUser> _userManager;
//        private readonly ShopContext _shopContext;

//        public UserItemsController(ShopContext shopContext, UserManager<IdentityUser> userManager)
//        {
//            _userManager = userManager;
//            _shopContext = shopContext;
//        }

//        public void StoreUserItem(string itemId)
//        {
//            var userItem = new UserItemsDAL();

//            userItem.UserId = _userManager.GetUserId(User);
//            userItem.ItemId = itemId;

//            _shopContext.UserItems.Add(userItem);
//            _shopContext.SaveChanges();
            
//        }

//        public IActionResult ViewCart()
//        {
//            var view = new ViewCartViewModel();

//            var purchasedItemDAL = _shopContext.Items
//                .Where(item => item.itemID == (_shopContext.PurchasedItems
//                .Where(user => user.UserId == _userManager.GetUserId(User))             
                

            


//            return View(view);
            
//        }
//    }
//}