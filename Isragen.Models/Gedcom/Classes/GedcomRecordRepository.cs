using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents repositoryRecord according to Gedcom 5.5 standard
    */
    public class GedcomRecordRepository : GedcomRecord, IGedcomChangable, IGedcomNotable
    {
        // NAME_OF_REPOSITORY:=
        // The official name of the archive in which the stated source material is stored.
        public string RepositoryName { get; set; }

        // ADDRESS_STRUCTURE
        public GedcomAddress RepositoryAddress { get; set; }

        // NOTE_STRUCTURE
        public List<GedcomNote> Notes { get; set; }

        // USER_REFERENCE_NUMBER
        // A user-defined number or text that the submitter uses to identify this record.
        public string UserReferenceId { get; set; }

        //CHANGE_DATE
        public GedcomRecordModification LastModified { get; set; }
    }
}
