using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Multimedia Link according to Gedcom 5.5 standard
    */
    public class GedcomMultimediaLink : IGedcomNotable
    {
        // <MULTIMEDIA_FORMAT> - indicates the format of the multimedia
        // data associated with the specific GEDCOM context.
        public Nullable<GedcomMediaType> MultimediaFormat { get; set; }

        // <DESCRIPTIVE_TITLE> - the title of multimedia item.
        public string Title { get; set; }

        // <MULTIMEDIA_FILE_REFERENCE> - a complete local or remote file
        // reference to the auxiliary data to be linked to the GEDCOM context.
        public string FileReference { get; set; }

        // <NOTE_STRUCTURE> - additional information provided by the submitter
        // for understanding the enclosing data.
        public List<GedcomNote> Notes { get; set; }

        public GedcomMultimediaLink()
        {
            MultimediaFormat = null;
            Title = null;
            FileReference = null;
            Notes = null;
        }
    }
}
