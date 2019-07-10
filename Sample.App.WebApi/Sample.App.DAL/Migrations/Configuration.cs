namespace Sample.App.DAL.Migrations
{
    using BO;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sample.App.DAL.Infrastructure.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Sample.App.DAL.Infrastructure.AppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var Batches = new List<Batch>()
                  {
                       new Batch { Name = "Name1" },
                       new Batch { Name = "Name2" },
                       new Batch { Name = "Name3" },
                  };
            if (!(context.Batches.Count() > 0))
            {
                Batches.ForEach(batch => context.Batches.Add(batch));
                context.SaveChanges();
            }
        }
    }
}
