using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Date Types according to Gedcom 5.5 standard.
    */
    public enum GedcomDateType
    {
        // Exactly date - <DAY> <MONTH> <YEAR>.
        Exactly = 1,

        // Date period - FROM <DATE> | TO <DATE> | FROM <DATE> TO <DATE>
        Period,

        // Date range - BEF <DATE> | AFT <DATE> | BET <DATE> AND <DATE>
        Range,

        // Any statement offered as a date, but which gives information about when an event occurred.
        Phrase
    }
}
