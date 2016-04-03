using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Records Change Date according to Gedcom 5.5 standard.
    */
    public class GedcomRecordModification : IGedcomNotable
    {
        // <CHANGE_DATE> = <DATE_EXACT>:= <DAY> <MONTH> <YEAR> - The date that this data was changed.
        // <TIME_VALUE> - The time that this data was changed.
        public DateTime DateTime { get; set; }

        // <NOTE_STRUCTURE> - additional information provided by the submitter
        // for understanding the enclosing data.
        public List<GedcomNote> Notes { get; set; }

        public GedcomRecordModification()
        {
            Notes = null;
        }
    }
}
