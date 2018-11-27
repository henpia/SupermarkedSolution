using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Supermarked.Models
{
    public class SupermarkedDB : DbContext
    {
        public DbSet<Varegruppe> Varegrupper { get; set; }

        public DbSet<Vare> Varer { get; set; }

    }
}