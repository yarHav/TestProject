using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Panel
{
    public class DbInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext ctx)
        {
            Category category = new Category
            {
                Name  = "Category 1",
                Goods = new List<Good>
                {
                    new Good { Title = "Good 1", Price = 56.3m },
                    new Good { Title = "Good 2", Price = 36.3m },
                }
            };
            ctx.Entry(category).State = EntityState.Added;
            ctx.SaveChanges();

        }
    }
}
