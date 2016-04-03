using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Source Record according to Gedcom 5.5 standard
    */

    public class RecordSource : GedcomRecord, IGedcomChangable, IGedcomNotable
    {

        // EVEN<EVENTS_RECORDED> {0:M}
        public List<Nullable<GedcomEventTypeFamily>> FamilyEvents { get; set; }

        // EVEN<EVENTS_RECORDED> {0:M}
        public List<Nullable<GedcomEventTypeIndividual>> IndividualEvents { get; set; }

        public string UserIndividualEvents { get; set; }

        public string UserFamilyEvents { get; set; }

        // DATE<DATE_PERIOD> {0:1}
        public GedcomDate DatePeriod { get; set; }
        
        // <<NOTE_STRUCTURE>> {0:M}
        public List<GedcomNote> Notes { get; set; }

        // AUTH<SOURCE_ORIGINATOR> {0:1}
        // The person, agency, or entity who created the record.
        public string Creator { get; set; }

        // TITL<SOURCE_DESCRIPTIVE_TITLE> {0:1}
        public string Title { get; set; }

        // ABBR<SOURCE_FILED_BY_ENTRY> {0:1}
        // This entry is to provide a short title used for sorting, filing, and retrieving source records.
        public string Abbriviation { get; set; }

        // PUBL<SOURCE_PUBLICATION_FACTS> {0:1}
        // When and where the record was created.
        public string PublicationFacts { get; set; }

        // TEXT<TEXT_FROM_SOURCE> {0:1}
        // A verbatim copy of any description contained within the source.
        public string Text { get; set; }

        // PLAC<SOURCE_JURISDICTION_PLACE> {0:1}
        // Place of the source
        public string Places { get; set; }

        // AGNC<RESPONSIBLE_AGENCY> {0:1}
        // The organization, institution, corporation, person, or other entity
        // that has authority or control interests in the associated context.
        public string Agencys { get; set; }

        // <<SOURCE_REPOSITORY_CITATION>> {0:1}
        // This structure is used to point to a name and address record of the holder of the
        // source document.
        // public SourceRepository SourceRepository { get; set; }

        // <<MULTIMEDIA_LINK>> {0:M}
        public List<GedcomMultimediaLink> MultimediaLinks { get; set; }

        // USER_REFERENCE_NUMBER
        // A user-defined number or text that the submitter uses to identify this record.
        public string UserReferenceId { get; set; }

        //CHANGE_DATE
        public GedcomRecordModification LastModified { get; set; }

        public RecordSource()
        {
            Id = null;
            XREF = null;
            Type = GedcomRecordType.Source;
        }
    }
}
