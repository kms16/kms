using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Records Types according to Gedcom 5.5 standard
    */
    public enum GedcomRecordType
    {
        Individual = 1,
        Family,
        Submitter,
        Submission,
        Note,
        Source,
        //Multimedia,
        Repository
    }
}
