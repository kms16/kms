using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Place according to Gedcom 5.5 standard
    */
    public class GedcomPlace : IGedcomCitable, IGedcomNotable
    {
        // <PLACE_VALUE> - the jurisdictional name of the place where
        // the event took place.
        public string Name { get; set; }

        // <PLACE_HIERARCHY> - shows the jurisdictional entities that are
        // named in a sequence from the lowest to the highest jurisdiction.
        public string JurisdictionHierarchy { get; set; }

        // <<SOURCE_CITATION>> - source-related information specific to the
        // data being cited.
        public List<GedcomCitation> Citations { get; set; }

        // <<NOTE_STRUCTURE>> - additional information provided by the submitter
        // for understanding the enclosing data.
        public List<GedcomNote> Notes { get; set; }

        public GedcomPlace()
        {
            Name = null;
            JurisdictionHierarchy = null;
            Citations = null;
            Notes = null;
        }
    }
}
