using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Attribute Type according to Gedcom 5.5 standard.
    */
    public enum GedcomAttributeType
    {
        // CASTE_NAME
        CasteName = 1,

        // PHYSICAL_DESCRIPTION
        PhisicalDescription,

        // SCHOLASTIC_ACHIEVEMENT
        ScholasticAchivement,

        // NATIONAL_ID_NUMBER
        IdNumber,

        // NATIONAL_OR_TRIBAL_ORIGIN
        Origin,

        // COUNT_OF_CHILDREN
        ChildrenCount,

        // COUNT_OF_MARRIAGES
        MariagesCount,

        // OCCUPATION
        Occupation,

        // POSSESSIONS
        Possessions,

        // RELIGIOUS_AFFILIATION
        ReligiousAffilation,

        // RESIDANCE
        // The act of dwelling at an address for a period of time.
        Residance,

        // SOCIAL_SECURITY_NUMBER
        SocialSecurityNumber,

        // NOBILITY_TYPE_TITLE
        // The title given to or used by a person, especially of royalty or
        // other noble class within a locality.
        NobilityTitle
    }
}
