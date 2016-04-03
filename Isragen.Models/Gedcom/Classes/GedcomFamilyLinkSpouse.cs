using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Spouse to Family link according to Gedcom 5.5 standard.
    */
    public class GedcomFamilyLinkSpouse
    {
        //FAMS @<XREF:FAM>@
        public string FamilyId { get; set; }

        // NOTE_STRUCTURE
        public List<GedcomNote> Notes { get; set; }

        public GedcomFamilyLinkSpouse()
        {
            FamilyId = null;
            Notes = null;
        }
    }
}
