using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Submitter Record according to Gedcom 5.5 standard
    */
    public class GedcomRecordSubmitter : GedcomRecord, IGedcomChangable
    {

        // ADDRESS_STRUCTURE
        public GedcomAddress Address { get; set; }

        // <<MULTIMEDIA_LINK>>
        public List<GedcomMultimediaLink> MultimediaLinks { get; set; }

        // LANG<LANGUAGE_PREFERENCE> {0:3}
        //public List<LanguageType> PreferdLanguages { get; set; }

        // RFN<SUBMITTER_REGISTERED_RFN> {0:1}
        // A user-defined number or text that the submitter uses to identify this record.
        public string UserReferenceId { get; set; }

        // <<CHANGE_DATE>>
        public GedcomRecordModification LastModified { get; set; }
    }
}
