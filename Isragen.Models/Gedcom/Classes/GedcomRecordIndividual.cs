using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Individual Record according to Gedcom 5.5 standard
    */
    public class GedcomRecordIndividual : GedcomRecord, IGedcomCitable, IGedcomChangable, IGedcomNotable
    {
        // PERSONAL_NAME_STRUCTURE
        public List<GedcomPersonalName> Names { get; set; }

        // SEX_VALUE
        public Nullable<GedcomGender> Gender { get; set; }

        // INDIVIDUAL_EVENT_STRUCTURE {0:M}
        public List<GedcomEventIndividual> Events { get; set; }

        // INDIVIDUAL_ATTRIBUTE_STRUCTURE {0:M} p.30
        public List<GedcomAttributeIndividual> Attributes { get; set; }

        // CHILD_TO_FAMILY_LINK
        public List<GedcomFamilyLinkChild> ChildToFamilyLinks { get; set; }

        // SPOUSE_TO_FAMILY_LINK
        public List<GedcomFamilyLinkSpouse> SpouseToFamilyLinks { get; set; }

        // XREF:SUBM
        //public XREF SubmitterID { get; set; }

        // ASSOCIATION_STRUCTURE
        public List<GedcomAssociation> Associations { get; set; }

        // ALIA XREF:INDI
        // link to different record descriptions of a person who may be the same person.
        //public List<XREF> SamePersons { get; set; }

        // ANCI XREF:SUBM
        // Indicates an interest in additional research for ancestors of this individual.
        //public List<XREF> AnscestorsIntrestedResearchersID { get; set; }

        // DESI XREF:SUBM
        // Indicates an interest in research to identify additional descendants of this individual.
        //public List<XREF> DescendantsIntrestedResearchersID { get; set; }

        //SOURCE_CITATION
        public List<GedcomCitation> Citations { get; set; }

        // MULTIMEDIA_LINK
        public List<GedcomMultimediaLink> MultimediaLinks { get; set; }

        // NOTE_STRUCTURE
        public List<GedcomNote> Notes { get; set; }

        // USER_REFERENCE_NUMBER
        // A user-defined number or text that the submitter uses to identify this record.
        public string UserReferenceId { get; set; }

        //CHANGE_DATE
        public GedcomRecordModification LastModified { get; set; }

        public GedcomRecordIndividual()
        {
            Id = null;
            Type = GedcomRecordType.Individual;
            Gender = null;
        }
    }
}
