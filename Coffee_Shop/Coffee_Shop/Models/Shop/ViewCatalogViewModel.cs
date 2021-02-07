using Coffee_Shop.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models.Shop
{
    public class ViewCatalogViewModel
    {
        public List<ItemsDAL> ListOfitems { get; set; }

        public bool isUserLoggedIn { get; set; }
        public string userID { get; set; }
    }
}
