using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Certainty Assessment according to Gedcom 5.5 standard.
    */
    public enum GedcomCertaintyAssessment
    {
        Unreliable = 0,
        Questionable = 1,
        SecondaryEvidence = 2,
        DirectEvidence = 3
    }
}
