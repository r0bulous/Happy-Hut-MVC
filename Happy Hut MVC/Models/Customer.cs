using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("Email Address")]
        public string CustomerEmail { get; set; }
        [DisplayName("Phone Number")]
        public string CustommerPhone { get; set; }
        [DisplayName("Preferred Beverage")]
        public string FavDrink { get; set; }
        [DisplayName("Preferred Meal")]
        public string FavMeal { get; set; }
        [DisplayName("Max. Check Amount")]
        public decimal LargestBill { get; set; }
        [DisplayName("Address")]
        public virtual ICollection<Address> Addresses { get; set; }

    }
}