using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class Legalname
    {
        public string givenName { get; set; }
        public string middleName { get; set; }
        public string familyName1 { get; set; }
        public string formattedName { get; set; }
        public Preferredsalutation[] preferredSalutations { get; set; }
        public string nickName { get; set; }
        public ShortCode generationAffixCode { get; set; }
        public LongCode qualificationAffixCode { get; set; }
    }
}
