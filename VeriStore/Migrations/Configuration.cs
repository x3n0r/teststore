namespace VeriStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VeriStore.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "VeriStore.Model1";
        }

        protected override void Seed(VeriStore.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //add data after migrating
            /*
            var comuni = new List<Town>
            {
                new Town {Comune="Acquaviva delle Fonti",Provincia="BA",Cap="70021", Belfiore="A048"},
            };
            comuni.ForEach(c => ctx.Comuni.Add(c));
            ctx.SaveChanges();
            */
        }
    }
}
