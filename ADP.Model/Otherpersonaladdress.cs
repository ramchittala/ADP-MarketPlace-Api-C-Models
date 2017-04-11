using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class Otherpersonaladdress
    {
        public string itemID { get; set; }
        public ShortCode nameCode { get; set; }
        public string lineOne { get; set; }
        public string cityName { get; set; }
        public Countrysubdivisionlevel countrySubdivisionLevel1 { get; set; }
        public Countrysubdivisionlevel countrySubdivisionLevel2 { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
        public string lineTwo { get; set; }
    }
}
