using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.DALModels
{
    public class UserDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity(1, 1)
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public double userFunds { get; set; }
        // valuetype? <--- the "?" makes your value type nullable, example = 
        // int? num = null;
        // int? numTwo = 3;

    }
}
