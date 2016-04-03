using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Family Event according to Gedcom 5.5 standard.
    */
    public class GedcomEventFamily
    {
        public Nullable<GedcomEventTypeFamily> Type { get; set; }
        public string UserEventType { get; set; }
        public GedcomAge AgeHusbent { get; set; }
        public GedcomAge AgeWife { get; set; }
        public GedcomEventDetail Details { get; set; }

        public GedcomEventFamily()
        {
            Type = null;
            AgeHusbent = null;
            AgeWife = null;
            UserEventType = null;
            Details = null;
        }
    }
}
