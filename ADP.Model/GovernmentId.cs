using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class Governmentid
    {
        public string itemID { get; set; }
        public string idValue { get; set; }
        public LongCode nameCode { get; set; }
        public string countryCode { get; set; }
        public ShortCode statusCode { get; set; }
    }
}
