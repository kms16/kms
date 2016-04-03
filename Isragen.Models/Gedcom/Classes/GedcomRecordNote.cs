using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Note Record according to Gedcom 5.5 standard
    */
    public class GedcomRecordNote : GedcomRecord, IGedcomCitable, IGedcomChangable
    {
        // SUBMITTER_TEXT:=
        // Comments or opinions from the submitter.
        public string SubmitterText { get; set; }

        // SOURCE_CITATION
        public List<GedcomCitation> Citations { get; set; }

        // USER_REFERENCE_NUMBER
        // A user-defined number or text that the submitter uses to identify this record.
        public string UserReferenceId { get; set; }

        //CHANGE_DATE
        public GedcomRecordModification LastModified { get; set; }

        public GedcomRecordNote()
        {
            Type = GedcomRecordType.Note;
            SubmitterText = null;
        }
    }
}
