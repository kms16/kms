using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Abstracrt class used as Gedcom Records base
    */
    public class GedcomRecord : IGedcomRecord
    {

        public string Id { get; set; }

        // RIN <PERMANENT_RECORD_FILE_NUMBER>
        public string XREF { get; set; }

        public string ResearchId { get; set; }

        public GedcomRecordType Type { get; set; }
    }
}
