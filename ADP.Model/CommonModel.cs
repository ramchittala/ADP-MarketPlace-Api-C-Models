using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class ShortCode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class LongCode
    {
        public string codeValue { get; set; }
        public string longName { get; set; }
    }


    public class Preferredsalutation
    {
        public ShortCode salutationCode { get; set; }
    }

   
    public class Countrysubdivisionlevel
    {
        public string subdivisionType { get; set; }
        public string codeValue { get; set; }
        public string shortName { get; set; }
    }

    public class Maritalstatuscode
    {
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public string effectiveDate { get; set; }
    }

    public class Racecode
    {
        public string codeValue { get; set; }
        public string longName { get; set; }
        public string shortName { get; set; }
        public ShortCode identificationMethodCode { get; set; }
    }

    public class Mobile
    {
        public ShortCode nameCode { get; set; }
        public string countryDialing { get; set; }
        public string areaDialing { get; set; }
        public string dialNumber { get; set; }
        public string access { get; set; }
        public string formattedNumber { get; set; }
        public string itemID { get; set; }
    }

    public class Email
    {
        public ShortCode nameCode { get; set; }
        public string emailUri { get; set; }
    }
    public class Landline
    {
        public ShortCode nameCode { get; set; }
        public string countryDialing { get; set; }
        public string areaDialing { get; set; }
        public string dialNumber { get; set; }
        public string access { get; set; }
        public string formattedNumber { get; set; }
        public string itemID { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string mediaType { get; set; }
        public string method { get; set; }
    }

    public class Photo
    {
        public Link[] links { get; set; }
    }
}
