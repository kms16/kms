using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Isragen.Models
{
    /*
    Family Events Types according to Gedcom 5.5 standard.
    */
    public enum GedcomEventTypeFamily
    {

        // ANUL {ANNULMENT}:=
        // Declaring a marriage void from the beginning (never existed).
        Annulment = 1,

        // CENS {CENSUS}:=
        // The event of the periodic count of the population for a designated locality.
        Census,

        // DIV {DIVORCE}:=
        // An event of dissolving a marriage through civil action.
        Divorce,

        // DIVF {DIVORCE_FILED}:=
        // An event of filing for a divorce by a spouse.
        DivorceFiled,

        // ENGA {ENGAGEMENT}:=
        // An event of recording or announcing an agreement between two people to become married.
        Engagement,

        // MARR {MARRIAGE}:=
        // A legal, common-law, or customary event of creating a family unit of a man and a woman
        // as husband and wife.
        Marriage,

        // MARB {MARRIAGE_BANN}:=
        // An event of an official public notice given that two people intend to marry.
        MarriageBann,

        // MARC {MARR_CONTRACT}:=
        // An event of recording a formal agreement of marriage.
        MarriageContract,

        // MARL {MARR_LICENSE}:=
        // An event of obtaining a legal license to marry.
        MarriageLicense,

        // MARS {MARR_SETTLEMENT}:=
        // An event of creating an agreement between two people contemplating marriage.
        MarriageSettlement,

        // Other then listed up events.
        Other
    }
}
