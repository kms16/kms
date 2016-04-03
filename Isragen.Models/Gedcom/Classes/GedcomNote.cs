using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Note according to Gedcom 5.5 standard
    */
    public class GedcomNote : IGedcomCitable
    {
        // <SUBMITTER_TEXT> - comments or opinions from the submitter.
        public string SubmitterText { get; set; }

        // <SOURCE_CITATION> - source-related information specific to the data being cited.
        public List<GedcomCitation> Citations { get; set; }

        public GedcomNote()
        {
            SubmitterText = null;
            Citations = null;
        }
    }
}
