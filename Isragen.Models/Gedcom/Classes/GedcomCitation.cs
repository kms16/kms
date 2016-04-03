using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Citation according to Gedcom 5.5 standard.*/
    public class GedcomCitation : IGedcomNotable
    {

        // Source description
        public string SourceDescription { get; set; }

        // Pointer to source record.
        public string SourceId { get; set; }

        // Number or description to identify where
        // information can be found in a referenced work.
        public string WhereInSource { get; set; }

        // A verbatim copy of any description contained
        // within the source.
        public string Text { get; set; }

        // <CERTAINTY_ASSESSMENT> - conveys the submitter's evaluation of the
        // credibility of a piece of information, based upon its supporting
        // evidence.
        // public CertaintyAssessment Certainty { get; set; }

        // The link to related multimedia.
        public GedcomMultimediaLink SourceMediaLink { get; set; }

        // Additional information provided by the submitter
        // for understanding the enclosing data.
        public List<GedcomNote> Notes { get; set; }

        public GedcomCitation()
        {
            SourceDescription = null;
            Text = null;
            Notes = null;
        }
    }
}
