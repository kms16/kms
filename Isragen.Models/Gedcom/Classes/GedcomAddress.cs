using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Represents Address according to Gedcom 5.5 standard.
    */
    public class GedcomAddress
    {

        // House Number
        public string HouseNumber { get; set; }

        // Street
        public string Street { get; set; }

        // City
        public string City { get; set; }

        // State of province
        public string State { get; set; }

        // Postal code
        public string PostalCode { get; set; }

        // Country
        public string Country { get; set; }

        // Phone numbers, maximum 3 numbers

        // Primary phone number
        public string PhoneNumber1 { get; set; }

        // Second phone number
        public string PhoneNumber2 { get; set; }

        // Third phone number
        public string PhoneNumber3 { get; set; }

        public GedcomAddress()
        {
            HouseNumber = null;
            Street = null;
            City = null;
            State = null;
            PostalCode = null;
            Country = null;
            PhoneNumber1 = null;
            PhoneNumber2 = null;
            PhoneNumber3 = null;
        }
    }
}
