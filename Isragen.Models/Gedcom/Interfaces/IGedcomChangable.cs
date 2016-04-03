using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    interface IGedcomChangable
    {
        GedcomRecordModification LastModified { get; set; }
    }
}
