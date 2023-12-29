using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppAssignment15.Data
{
    public class WebAppAssignment15Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebAppAssignment15Context() : base("name=WebAppAssignment15Context")
        {
        }

        public System.Data.Entity.DbSet<WebAppAssignment15.Models.User> Users { get; set; }
    }
}
