using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Supermarked.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<SupermarkedDB>
    {
        protected override void Seed(SupermarkedDB context)
        {
            base.Seed(context);

            var varegrupper = new List<Varegruppe>
            {
                new Varegruppe
                {
                    VaregruppeId = 1,
                    Betegnelse = "Tekstil"
                },
                new Varegruppe
                {
                    VaregruppeId = 2,
                    Betegnelse = "Fødevarer"
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
            };
            varegrupper.ForEach(grp => context.Varegrupper.Add(grp));
            context.SaveChanges();

            var varer = new List<Vare>
            {
                new Vare
                {
                    VareId = 1,
                    Betegnelse = "Homewear-sæt",
                    Beskrivelse = "Polyester",
                    Pris = 299.00M,
                    AntalPaaLager = 3,
                    VaregruppeId = 1
                },
                new Vare
                {
                    VareId = 2,
                    Betegnelse = "Hue og handsker",
                    Beskrivelse = "Stort udvalg",
                    Pris = 49.00M,
                    AntalPaaLager = 5,
                    VaregruppeId = 1
                },
                new Vare
                {
                    VareId = 3,
                    Betegnelse = "Strømper",
                    Beskrivelse = "Flere varianter, strømper til hele familien",
                    Pris = 9M,
                    AntalPaaLager = 25,
                    VaregruppeId = 1
                },
                new Vare
                {
                    VareId = 4,
                    Betegnelse = "Hakket oksekød",
                    Beskrivelse = "2000g. Med 8-12% fedt",
                    Pris = 99M,
                    AntalPaaLager = 10,
                    VaregruppeId = 2
                },
                new Vare
                {
                    VareId = 5,
                    Betegnelse = "Ovnklar and",
                    Beskrivelse = "1500g i alubakke",
                    Pris = 95M,
                    AntalPaaLager = 4,
                    VaregruppeId = 2
                },
                new Vare
                {
                    VareId = 6,
                    Betegnelse = "Grønlandske rejer",
                    Beskrivelse = "350g. Flere varianter",
                    Pris = 34M,
                    AntalPaaLager = 10,
                    VaregruppeId = 2
                },
                new Vare
                {
                    VareId = 7,
                    Betegnelse = "Blu-Ray afspiller",
                    Beskrivelse = "Full HD Blu-ray afspiller med Doby TrueHD",
                    Pris = 650M,
                    AntalPaaLager = 2,
                    VaregruppeId = 3
                },
                new Vare
                {
                    VareId = 8,
                    Betegnelse = "Ghettoblaster",
                    Beskrivelse = "Med FM/AM radio",
                    Pris = 274M,
                    AntalPaaLager = 3,
                    VaregruppeId = 3
                },
                new Vare
                {
                    VareId = 9,
                    Betegnelse = "Router",
                    Beskrivelse = "Dual Band router",
                    Pris = 249M,
                    AntalPaaLager = 2,
                    VaregruppeId = 3
                },
                new Vare
                {
                    VareId = 10,
                    Betegnelse = "Mikroovn",
                    Beskrivelse = "20 liter. Hvid",
                    Pris = 450M,
                    AntalPaaLager = 4,
                    VaregruppeId = 4
                },
                new Vare
                {
                    VareId = 11,
                    Betegnelse = "Støvsuger",
                    Beskrivelse = "Teleskoprør. Energiklasse: A. Tilbehør: Støvsugerposer.",
                    Pris = 725M,
                    AntalPaaLager = 6,
                    VaregruppeId = 4
                },
                new Vare
                {
                    VareId = 12,
                    Betegnelse = "Æbleskivepande",
                    Beskrivelse = "Støbejern med 7 huller og bakelit-håndtag",
                    Pris = 109M,
                    AntalPaaLager = 10,
                    VaregruppeId = 4
                },
                new Vare
                {
                    VareId = 13,
                    Betegnelse = "Grydesæt",
                    Beskrivelse = "7 dele. Fremstillet i rustfrit stål",
                    Pris = 568M,
                    AntalPaaLager = 5,
                    VaregruppeId = 4
                }
            };
            varer.ForEach(vare => context.Varer.Add(vare));
            context.SaveChanges();
        }
    }
}