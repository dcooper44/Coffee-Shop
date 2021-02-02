using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.DALModels
{
    public class ItemsDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity(1, 1)
        public int itemID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }


    }
}
