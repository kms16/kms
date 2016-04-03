using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isragen.Models
{
    public interface IIsragenArchiveRecord
    {
        // Record Id.
        string Id { get; set; }

        /*
            Record description:
        */

        // The person, agency, or entity who created the record.
        string Creator { get; set; }

        // Title.
        string Title { get; set; }

        // Abbriviation.
        string Abbriviation { get; set; }

        // When the record was created.
        IsragenDate CreatedOn { get; set; }

        // Where the record was created.
        IsragenPlace CreatedAt { get; set; }

        // Publication facts.
        string PublicationFacts { get; set; }

        // MultimediaFormat.
        IsragenMultimediaFormat MultimediaFormat { get; set; }

        // File reference.
        string URL { get; set; }


        /*
            Data described in this record:
        */

        // People.
        List<IsragenPerson> People { get; set; }

        // Family events defined by Gedcom 5.5.
        List<Nullable<IsragenEventType>> Events { get; set; }

        // Individual events defined by the system user.
        List<string> UserEvents { get; set; }

        // Places
        List<IsragenPlace> Places { get; set; }

        // The organizations, institutions
        List<IsragenAgency> Agencies { get; set; }

        // Time period
        IsragenDatePeiod DatePeriod { get; set; }

        // Keywords.
        string Keywords { get; set; }
    }
}
