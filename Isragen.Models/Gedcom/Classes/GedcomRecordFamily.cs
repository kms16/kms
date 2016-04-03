using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Isragen.Models
{
    /*
    Represents Family Record according to Gedcom 5.5 standard
    */
    public class GedcomRecordFamily : GedcomRecord, IGedcomCitable, IGedcomNotable
    {
        // FAMILY_EVENT_STRUCTURE
        public List<GedcomEventFamily> Events { get; set; }

        // HUSB XREF:INDI
        public string HusbentID { get; set; }

        // WIFE XREF:INDI
        public string WifeID { get; set; }

        // XREF:INDI
        public List<string> ChildrensID { get; set; }

        // COUNT_OF_CHILDREN:=
        // the reported number of children known to belong to this family,
        // regardless of whether the associated children are represented in
        // the corresponding structure.
        public string ChildrensCount { get; set; }

        // XREF:SUBM
        //public XREF SubmitterID { get; set; }

        // SOURCE_CITATION:=
        public List<GedcomCitation> Citations { get; set; }

        //MULTIMEDIA_LINK
        public List<GedcomMultimediaLink> MultimediaLinks { get; set; }

        // NOTE_STRUCTURE
        public List<GedcomNote> Notes { get; set; }

        // USER_REFERENCE_NUMBER
        // A user-defined number or text that the submitter uses to identify this record.
        public string UserReferenceId { get; set; }

        //CHANGE_DATE
        public GedcomRecordModification LastModified { get; set; }

        public GedcomRecordFamily()
        {
            Id = null;
            XREF = null;
            Type = GedcomRecordType.Family;
            Events = null;
            HusbentID = null;
            WifeID = null;
            ChildrensID = null;
            ChildrensCount = null;
            //SubmitterID = null;
            Citations = null;
            MultimediaLinks = null;
            Notes = null;
            UserReferenceId = null;
            LastModified = null;
        }
    }
}
