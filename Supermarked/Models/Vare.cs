using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supermarked.Models
{
    [Table("Vare")]
    public class Vare
    {
        public int VareId { get; set; }

        public string Betegnelse { get; set; }

        public string Beskrivelse { get; set; }

        public decimal Pris { get; set; }

        [Display(Name = "På Lager")]
        public int AntalPaaLager { get; set; }

        public int VaregruppeId { get; set; }
        public Varegruppe Varegruppe { get; set; }
    }
}