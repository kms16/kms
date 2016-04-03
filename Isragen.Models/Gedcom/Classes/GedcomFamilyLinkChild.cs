using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Child to Family link according to Gedcom 5.5 standard.
    */
    public class GedcomFamilyLinkChild : IGedcomNotable
    {
        // <XREF:FAM> - a pointer to a fam_record.
        public string FamilyId { get; set; }

        // <PEDIGREE_LINKAGE_TYPE> - indicates the child to family
        // relationship for pedigree navigation purposes.
        public GedcomPedigreeLinkageType PedigreeLink { get; set; }

        // <NOTE_STRUCTURE> - additional information provided by the submitter
        // for understanding the enclosing data.
        public List<GedcomNote> Notes { get; set; }

        public GedcomFamilyLinkChild()
        {
            FamilyId = null;
            PedigreeLink = GedcomPedigreeLinkageType.NotSet;
            Notes = null;
        }
    }
}
