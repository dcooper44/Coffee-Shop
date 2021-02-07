using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.DomainModels
{
    public class ItemDetails
    {
        public int UserItemID { get; set; }    
        public string ItemId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }


    }
}
