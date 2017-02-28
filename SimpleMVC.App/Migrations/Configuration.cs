using SharpStore.Models;

namespace SharpStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SharpStore.Data.SharpStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SharpStore.Data.SharpStoreContext context)
        {
            context.Knives.AddOrUpdate(knife =>knife.Name, new Knife[]
            {
                new Knife()
                {
                    Name = "Sharp 3000",
                    Price = 140.00m,
                    ImageURL = "http://www.chicagoprotective.com/images/400X200.gif"
                },
                new Knife()
                {
                    Name = "Sharp 4",
                    Price = 99.00m,
                    ImageURL = "http://www.chicagoprotective.com/images/400X200.gif"
                },
                new Knife()
                {
                    Name = "Sharp Ultimate",
                    Price = 450.00m,
                    ImageURL = "http://www.chicagoprotective.com/images/400X200.gif"
                }
            });
        }
    }
}
