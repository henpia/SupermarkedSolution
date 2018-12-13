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
            context.Varegrupper.AddOrUpdate(g => g.Betegnelse,
                new Varegruppe
                {
                    VaregruppeId = 1,
                    Betegnelse = "Tekstil"
                },
                new Varegruppe
                {
                    VaregruppeId = 2,
                    Betegnelse = "F�devarer"
                },
                new Varegruppe
                {
                    VaregruppeId = 3,
                    Betegnelse = "Elektronik"
                },
                new Varegruppe
                {
                    VaregruppeId = 4,
                    Betegnelse = "Bolig"
                }
            );

            context.Varer.AddOrUpdate(v => v.Betegnelse,
                new Vare
                {
                    Betegnelse = "Homewear-s�t",
                    Beskrivelse = "Polyester",
                    Pris = 299.00M,
                    AntalPaaLager = 3,
                    VaregruppeId = 1
                },
                new Vare
                {
                    Betegnelse = "Hue og handsker",
                    Beskrivelse = "Stort udvalg",
                    Pris = 49.00M,
                    AntalPaaLager = 5,
                    VaregruppeId = 1
                },
                new Vare
                {
                    Betegnelse = "Str�mper",
                    Beskrivelse = "Flere varianter, str�mper til hele familien",
                    Pris = 9M,
                    AntalPaaLager = 25,
                    VaregruppeId = 1
                },
                new Vare
                {
                    Betegnelse = "Hakket oksek�d",
                    Beskrivelse = "2000g. Med 8-12% fedt",
                    Pris = 99M,
                    AntalPaaLager = 10,
                    VaregruppeId = 2
                },
                new Vare
                {
                    Betegnelse = "Ovnklar and",
                    Beskrivelse = "1500g i alubakke",
                    Pris = 95M,
                    AntalPaaLager = 4,
                    VaregruppeId = 2
                },
                new Vare
                {
                    Betegnelse = "Gr�nlandske rejer",
                    Beskrivelse = "350g. Flere varianter",
                    Pris = 34M,
                    AntalPaaLager = 10,
                    VaregruppeId = 2
                },
                new Vare
                {
                    Betegnelse = "Blu-Ray afspiller",
                    Beskrivelse = "Full HD Blu-ray afspiller med Dolby TrueHD",
                    Pris = 650M,
                    AntalPaaLager = 2,
                    VaregruppeId = 3
                },
                new Vare
                {
                    Betegnelse = "Ghettoblaster",
                    Beskrivelse = "Med FM/AM radio",
                    Pris = 274M,
                    AntalPaaLager = 3,
                    VaregruppeId = 3
                },
                new Vare
                {
                    Betegnelse = "Router",
                    Beskrivelse = "Dual Band router",
                    Pris = 249M,
                    AntalPaaLager = 2,
                    VaregruppeId = 3
                },
                new Vare
                {
                    Betegnelse = "Mikroovn",
                    Beskrivelse = "20 liter. Hvid",
                    Pris = 450M,
                    AntalPaaLager = 4,
                    VaregruppeId = 4
                },
                new Vare
                {
                    Betegnelse = "St�vsuger",
                    Beskrivelse = "Teleskopr�r. Energiklasse: A. Tilbeh�r: St�vsugerposer.",
                    Pris = 725M,
                    AntalPaaLager = 6,
                    VaregruppeId = 4
                },
                new Vare
                {
                    Betegnelse = "�bleskivepande",
                    Beskrivelse = "St�bejern med 7 huller og bakelit-h�ndtag",
                    Pris = 109M,
                    AntalPaaLager = 10,
                    VaregruppeId = 4
                },
                new Vare
                {
                    Betegnelse = "Grydes�t",
                    Beskrivelse = "7 dele. Fremstillet i rustfrit st�l",
                    Pris = 568M,
                    AntalPaaLager = 5,
                    VaregruppeId = 4
                }
            );
        }
    }
}
