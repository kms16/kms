using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Pedigree Linkage Typesaccording Gedcom 5.5 standard
    */
    public enum GedcomPedigreeLinkageType
    {
        // adopted = indicates adoptive parents.
        Adopted = 1,

        // birth = indicates birth parents.
        Birth,

        // foster = indicates child was included in a foster or guardian family.
        Foster,

        // sealing = indicates child was sealed to parents other than birth parents.
        Sealing,

        NotSet
    }
}
