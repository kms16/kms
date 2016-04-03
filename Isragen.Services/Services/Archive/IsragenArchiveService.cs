using Isragen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isragen.Services
{
    public class IsragenArchiveService
    {
        public IsragenArchiveRecord Find(string id)
        {
            return new IsragenArchiveRecord();
        }

        public List<IsragenArchiveRecord> FindAll()
        {
            return new List<IsragenArchiveRecord>();
        }

        public bool Add(IsragenArchiveRecord record)
        {
            return true;
        }

        public bool Delete(string id)
        {
            return false;
        }
    }
}
