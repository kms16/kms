using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Event Details according to Gedcom 5.5 standard.
    */
    public class GedcomEventDetail : IGedcomCitable, IGedcomNotable
    {
        // <DATE_VALUE> - the date of event.
        public GedcomDate Date { get; set; }

        // <<PLACE_STRUCTURE>> - the place of event.
        public GedcomPlace Place { get; set; }

        // <<ADDRESS_STRUCTURE>> - address related to event.
        public GedcomAddress Address { get; set; }

        // <RESPONSIBLE_AGENCY> - the organization, institution, corporation,
        // person, or other entity that has authority or control interests
        // in the associated event.
        public string Agency { get; set; }

        // <CAUSE_OF_EVENT> - a description of the cause of the associated
        // event, such as the cause of death.
        public string Cause { get; set; }

        // <<SOURCE_CITATION>> - source-related information specific to the
        // data being cited.
        public List<GedcomCitation> Citations { get; set; }

        // <<MULTIMEDIA_LINK>> - the link to related multimedia.
        public List<GedcomMultimediaLink> MultimediaLinks { get; set; }

        // <<NOTE_STRUCTURE>> - additional information provided by the submitter
        // for understanding the enclosing data.
        public List<GedcomNote> Notes { get; set; }

        public GedcomEventDetail()
        {
            Date = null;
            Place = null;
            Address = null;
            Agency = null;
            Cause = null;
            Citations = null;
            MultimediaLinks = null;
            Notes = null;
        }
    }
}
