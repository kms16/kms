using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Individual Event according to Gedcom 5.5 standard.
    */
    public class GedcomEventIndividual
    {
        // Individual Event Type
        public Nullable<GedcomEventTypeIndividual> Type { get; set; }

        // Indvidual Event Type by user
        public string UserEventType { get; set; }

        // AGE <AGE_AT_EVENT>
        public GedcomAge AgeAtEvent { get; set; }

        // Evet details
        public GedcomEventDetail Details { get; set; }

        // FAMC @<XREF:FAM>@ when EventType ADOP
        public string AdoptedFamilyId { get; set; }

        // ADOP <ADOPTED_BY_WHICH_PARENT>
        public Nullable<GedcomAdoptedByParent> AdoptedByParent { get; set; }

        public GedcomEventIndividual()
        {
            Type = null;
            UserEventType = null;
            AgeAtEvent = null;
            Details = null;
            AdoptedFamilyId = null;
            AdoptedByParent = null;
        }
    }
}
