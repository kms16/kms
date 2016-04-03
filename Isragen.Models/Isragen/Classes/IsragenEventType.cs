using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isragen.Models
{
    public enum IsragenEventType
    {
        // Pertaining to creation of a child-parent relationship that does not exist biologically.
        Adoption = 1,

        // BIRT {BIRTH}:=
        // The event of entering into life.
        Birth,

        // BAPM {BAPTISM}:=
        // The event of baptism, performed in infancy or later.
        Baptism,

        // BARM {BAR_MITZVAH}:=
        // The ceremonial event held when a Jewish boy reaches age 13.
        BarMitzvah,

        // BASM {BAS_MITZVAH}:=
        // The ceremonial event held when a Jewish girl reaches age 13.
        BatMitzvah,

        // BLES {BLESSING}:=
        // A religious event of bestowing divine care or intercession.
        Blessing,

        // BURI {BURIAL}:=
        // The event of the proper disposing of the mortal remains of a deceased person.
        Burial,

        // CENS {CENSUS}:=
        // The event of the periodic count of the population for a designated locality,
        Census,

        // CHR {CHRISTENING}:=
        // The religious event (not LDS) of baptizing and/or naming a child.
        ChristeningChild,

        // CHRA {ADULT_CHRISTENING}:=
        // The religious event (not LDS) of baptizing and/or naming an adult person.
        ChristeningAdult,

        // CONF {CONFIRMATION}:=
        // The religious event (not LDS) of conferring the gift of the Holy Ghost and,
        // among protestants, full church membership.
        Confirmation,

        // CREM {CREMATION}:=
        // Disposal of the remains of a person's body by fire.
        Cremation,

        // DEAT {DEATH}:=
        // The event when mortal life terminates.
        Death,

        // EMIG {EMIGRATION}:=
        // An event of leaving one's homeland with the intent of residing elsewhere.
        Emigration,

        // FCOM {FIRST_COMMUNION}:=
        // A religious rite, the first act of sharing in the Lord's supper as part of
        // church worship.
        FirstCommunion,

        // GRAD {GRADUATION}:=
        // An event of awarding educational diplomas or degrees to individuals.
        Graduation,

        // IMMI {IMMIGRATION}:=
        // An event of entering into a new locality with the intent of residing there.
        Immigration,

        // NATU {NATURALIZATION}:=
        // The event of obtaining citizenship.
        Naturalization,

        // ORDN {ORDINATION}:=
        // A religious event of receiving authority to act in religious matters.
        Ordination,

        // RETI {RETIREMENT}:=
        // An event of exiting an occupational relationship with an employer after
        // a qualifying time period.
        Retirement,

        // PROB {PROBATE}:=
        // An event of judicial determination of the validity of a will.
        Probate,

        // WILL {WILL}:=
        // A legal document treated as an event, by which a person disposes
        // of his or her estate, to take effect after death.
        Will,

        // Declaring a marriage void from the beginning (never existed).
        Annulment,

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
        MarriageSettlement
    }
}
