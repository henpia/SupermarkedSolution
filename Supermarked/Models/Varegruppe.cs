﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supermarked.Models
{
    [Table("Varegruppe")]
    public class Varegruppe
    {
        public int VaregruppeId { get; set; }

        public string Betegnelse { get; set; }

        public ICollection<Vare> Vares { get; set; }
    }
}