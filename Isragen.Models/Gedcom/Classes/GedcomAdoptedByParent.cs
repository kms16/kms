using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Adoption options according to Gedcom 5.5 standard.
    */
    public enum GedcomAdoptedByParent
    {
        // HUSB = The HUSBand in the associated family adopted this person.
        Husbent = 1,

        // WIFE = The WIFE in the associated family adopted this person.
        Wife,

        // BOTH = Both HUSBand and WIFE adopted this person.
        Both
    }
}
