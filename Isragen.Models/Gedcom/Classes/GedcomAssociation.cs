using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Association according to Gedcom 5.5 standard.
    */
    public class GedcomAssociation : IGedcomNotable, IGedcomCitable
    {
        // <XREF> - a pointer to a record.
        public string TargetId { get; set; }

        // TYPE <RECORD_TYPE>
        // An indicator of the record type being pointed.
        public Nullable<GedcomRecordType> TargetType { get; set; }

        // RELA <RELATION_IS_DESCRIPTOR> - A word or phrase that states object
        // 1's relation is object 2.
        public string RelationDescriptor { get; set; }

        // <NOTE_STRUCTURE> - additional information provided by the submitter
        // for understanding the enclosing data.
        public List<GedcomNote> Notes { get; set; }

        // <SOURCE_CITATION> - source-related information specific to the
        // data being cited.
        public List<GedcomCitation> Citations { get; set; }

        public GedcomAssociation()
        {
            TargetId = null;
            TargetType = null;
            RelationDescriptor = null;
            Notes = null;
            Citations = null;
        }
    }
}
