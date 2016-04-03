using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isragen.Models;

namespace Isragen.Models
{
    public class IsragenArchiveRecord : IIsragenArchiveRecord
    {
        // Record Id.
        public string Id { get; set; }

        /*
            Record description:
        */

        // The person, agency, or entity who created the record.
        public string Creator { get; set; }

        // Title.
        public string Title { get; set; }

        // Abbriviation.
        public string Abbriviation { get; set; }

        // When the record was created.
        public IsragenDate CreatedOn { get; set; }

        // Where the record was created.
        public IsragenPlace CreatedAt { get; set; }

        // Publication facts.
        public string PublicationFacts { get; set; }

        // MultimediaFormat.
        public IsragenMultimediaFormat MultimediaFormat { get; set; }

        // File reference.
        public string URL { get; set; }


        /*
            Data described in this record:
        */

        // People.
        public List<IsragenPerson> People { get; set; }

        // Family events defined by Gedcom 5.5.
        public List<Nullable<IsragenEventType>> Events { get; set; }

        // Individual events defined by the system user.
        public List<string> UserEvents { get; set; }

        // Places
        public List<IsragenPlace> Places { get; set; }

        // The organizations, institutions
        public List<IsragenAgency> Agencies { get; set; }

        // Time period
        public IsragenDatePeiod DatePeriod { get; set; }

        // Keywords.
        public string Keywords { get; set; }


        public IsragenArchiveRecord()
        {
        }
    }
}
