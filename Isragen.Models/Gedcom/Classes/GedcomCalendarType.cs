using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Calendar Types according to Gedcom 5.5 standard.
    */
    public enum GedcomCalendarType
    {
        Gregorian = 1,

        Djulian,

        Hebrew,

        French,
        
        Unknown = -1,

        Other = 0
    }
}
