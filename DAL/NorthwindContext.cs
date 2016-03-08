using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace DAL
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("northwind")
        {
            
        }

        public DbSet<Order> Orders { get; set; }
    }
}
