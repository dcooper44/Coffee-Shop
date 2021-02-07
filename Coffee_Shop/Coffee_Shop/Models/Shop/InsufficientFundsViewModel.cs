using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models.Shop
{
    public class InsufficientFundsViewModel
    {
        public string userID { get; set; }
        public double itemPrice { get; set; }
        public double userFunds { get; set; }
    }
}
