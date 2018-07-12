using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Happy_Hut_MVC.Models
{
    public class Happy_Hut_MVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Happy_Hut_MVCContext() : base("name=Happy_Hut_MVCContext")
        {
        }

        public System.Data.Entity.DbSet<Happy_Hut_MVC.Models.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<Happy_Hut_MVC.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<Happy_Hut_MVC.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Happy_Hut_MVC.Models.Address> Addresses { get; set; }
    }
}
