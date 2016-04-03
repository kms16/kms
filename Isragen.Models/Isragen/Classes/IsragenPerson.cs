using Isragen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isragen.Models
{
    public class IsragenPerson
    {
        // Name
        public string Name { get; set; }

        // Surname
        public string Surname { get; set; }

        // Gender
        public GedcomGender Gender { get; set; }
    }
}
