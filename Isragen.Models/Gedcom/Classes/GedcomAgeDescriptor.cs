using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Age descriptor according to Gedcom 5.5 standard.
    */
    public enum GedcomAgeDescriptor
    {
        // EXACTLY indicated age
        Exactly,

        // > = greater than indicated age
        Greater,

        // < = less than indicated age
        Less
    }
}
