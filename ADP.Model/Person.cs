using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class Person
    {
        public Governmentid[] governmentIDs { get; set; } //done
        public Legalname legalName { get; set; } //done
        public string birthDate { get; set; }
        public Legaladdress legalAddress { get; set; } // Done
        public Communication communication { get; set; } // done
        public ShortCode genderCode { get; set; } // shortcode
        public Maritalstatuscode maritalStatusCode { get; set; } //done
        public Otherpersonaladdress[] otherPersonalAddresses { get; set; } // done
        public Racecode raceCode { get; set; } // done
        public Socialinsuranceprogram[] socialInsurancePrograms { get; set; }
        public bool tobaccoUserIndicator { get; set; } // done
        public PersonFieldgroup customFieldGroup { get; set; } //done person filedGroup
        public ShortCode highestEducationLevelCode { get; set; } //shortcode
        public ShortCode religionCode { get; set; } //shortcode
    }
}
