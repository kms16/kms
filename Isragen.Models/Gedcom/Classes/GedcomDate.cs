using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Date according to Gedcom 5.5 standard.
    */
    public class GedcomDate
    {
        // Date type : simple, period, range, phrase.
        public Nullable<GedcomDateType> Type { get; set; }

        // Simple date.
        public Nullable<DateTime> SimpleDate { get; set; }

        // First date in period or range.
        public Nullable<DateTime> Date1 { get; set; }

        // Second date in period or range.
        public Nullable<DateTime> Date2 { get; set; }

        // Phrase representing Date
        public string Phrase { get; set; }

        public GedcomDate()
        {
            SimpleDate = null;
            Date1 = null;
            Date2 = null;
            Phrase = null;
        }
    }
}
