namespace Supermarked.Migrations
{
    using Supermarked.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Supermarked.Models.SupermarkedDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Supermarked.Models.SupermarkedDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Varer.AddOrUpdate(v => v.Betegnelse,
                new Vare
                {
                    Betegnelse = "Test Vare",
                    Beskrivelse = "Beskrivelse af Test Vare",
                    Pris = 45.99M,
                    AntalPaaLager = 2,
                    VaregruppeId = 1
                }
            );
        }
    }
}
