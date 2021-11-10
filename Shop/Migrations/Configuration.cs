namespace Shop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Shop.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Shop.Models.ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(c => c.Name, new Category { Name = "Kategoria g³ówna" }, new Category { Name = "Elektronika" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
