using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Happy_Hut_MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustommerPhone { get; set; }
        public string FavDrink { get; set; }
        public string FavMeal { get; set; }
        public decimal LargestBill { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

    }
}