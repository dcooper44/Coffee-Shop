using Coffee_Shop.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models.UserItems
{
    public class ViewCartViewModel
    {
        public List<UserItemsDAL> ListOfItems { get; set; }
    }
}
