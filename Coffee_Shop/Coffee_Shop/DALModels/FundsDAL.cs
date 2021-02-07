using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.DALModels
{
    public class FundsDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity(1, 1)
        public int fundID { get; set; }

        public double userFunds { get; set; }

        [ForeignKey("User")]
        public string Id { get; set; }
        public IdentityUser User { get; set; }
    }
}
