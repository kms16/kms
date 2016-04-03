using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Individual Attribute according to Gedcom 5.5 standard.
    */
    public class GedcomAttributeIndividual
    {
        // Attribute type
        public Nullable<GedcomAttributeType> Type { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public GedcomEventDetail Details { get; set; }

        public GedcomAttributeIndividual()
        {
            Type = null;
            Value = null;
            Description = null;
            Details = null;
        }
    }
}
