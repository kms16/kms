using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Person Full Name according to Gedcom 5.5 standard
    */
    public class GedcomPersonalName : IGedcomCitable, IGedcomNotable
    {
        // NAME <NAME_PERSONAL>
        public string Name { get; set; }

        // NPFX<NAME_PIECE_PREFIX>
        public string NamePrefix { get; set; }

        //NSFX<NAME_PIECE_SUFFIX>
        // Non-indexing name piece that appears after the given name and surname parts.
        // Different name suffix parts are separated by a comma.
        public string NameSuffix { get; set; }

        // GIVN<NAME_PIECE_GIVEN>
        // Given name or earned name. Different given names are separated by a comma.
        public string GivenName { get; set; }

        // NICK<NAME_PIECE_NICKNAME>
        // A descriptive or familiar name used in connection with one's proper name.
        public string Nickname { get; set; }

        // SPFX<NAME_PIECE_SURNAME_PREFIX>
        public string SurnamePrefix { get; set; }

        // SURN<NAME_PIECE_SURNAME>
        // Surname or family name. Different surnames are separated by a comma.
        public string Surname { get; set; }

        //<<SOURCE_CITATION>>
        public List<GedcomCitation> Citations { get; set; }

        //<<NOTE_STRUCTURE>>
        public List<GedcomNote> Notes { get; set; }

        public GedcomPersonalName()
        {
            Name = null;
            Surname = null;
        }
    }
}
