using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Gedcom File according to Gedcom 5.5 standard.
    */
    public class IsragenResearch
    {
        private static int id = 0;
        public int ID { get; private set; }
        //public RecordSubmission SubmissionRecord { get; set; }
        public List<GedcomRecord> Records { get; set; }

        public IsragenResearch()
        {
            ID = id++;
            //SubmissionRecord = null;
            Records = new List<GedcomRecord>();
        }
    }
}
