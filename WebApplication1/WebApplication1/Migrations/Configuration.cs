using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Customers.AddOrUpdate(p => p.CustomerId,
                            new Customer { Name = "Product 1", Category = "Category 1", Price = 200 },
                            new Customer { Name = "Product 2", Category = "Category 2", Price = 500 },
                            new Customer { Name = "Product 3", Category = "Category 3", Price = 700 }
                            );

            context.Orders.AddOrUpdate(r => r.OrderId,
                            new Order { Title = "Review 1", Description = "Test review 1", CustomerId = 1 },
                            new Order { Title = "Review 2", Description = "Test review 2", CustomerId = 1 }
                            );
        }
    }
}
