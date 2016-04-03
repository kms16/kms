using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    interface IGedcomRecord : IGedcomLinkable
    {
        // RIN <PERMANENT_RECORD_FILE_NUMBER>
        string Id { get; set; }
    }
}
