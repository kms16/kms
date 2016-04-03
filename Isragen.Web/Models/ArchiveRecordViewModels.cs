using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Isragen.Models;
using System.ComponentModel.DataAnnotations;

namespace Isragen.Web.Models
{
    public class ArchiveRecordDataViewModel
    {
        // People.
        public List<IsragenPerson> People { get; set; }

        // Events.
        public List<Nullable<IsragenEventType>> Events { get; set; }

        // Events defined by the system user.
        public List<string> UserEvents { get; set; }

        // Time period
        public IsragenDatePeiod DatePeriod { get; set; }

        // Places
        public List<IsragenPlace> Places { get; set; }

        // The organizations, institutions
        public List<IsragenAgency> Agencies { get; set; }

        public string Keywords { get; set; }
    }

    public class ArchiveRecordDescriptionViewModel
    {

        // Creator.
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
    }

    public class ArchiveRecordContentViewModel
    {
        public HttpPostedFileBase Content { get; set; }
    }

    public class ArchiveRecordSearchViewModel : IsragenArchiveRecord
    {
        public bool IsSimpleSearch { get; set; }
    }

    public class ArchiveRecordCreateViewModel : IsragenArchiveRecord
    {
        public HttpPostedFileBase Content { get; set; }
    }
}