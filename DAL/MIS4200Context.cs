using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using jd713116_MIS4200.Models;

namespace jd713116_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}