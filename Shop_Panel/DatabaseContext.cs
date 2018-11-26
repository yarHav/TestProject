using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Panel
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DatabaseContext() : base("myConnection") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
    
}
