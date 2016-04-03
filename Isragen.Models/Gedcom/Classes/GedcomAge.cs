using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Age of person according to Gedcom 5.5 standard.
    */
    public class GedcomAge
    {

        //
        public string Years { get; set; }

        //
        public string Months { get; set; }

        //
        public string Days { get; set; }

        //
        public Nullable<GedcomAgeDescriptor> Descriptor { get; set; }

        public GedcomAge()
        {
            Descriptor = null;
            Years = null;
            Months = null;
            Days = null;
        }
    }
}
