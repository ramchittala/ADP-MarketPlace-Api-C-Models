using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class PersonFieldgroup
    {
        public Numberfield[] numberFields { get; set; }
        public Codefield[] codeFields { get; set; }
    }

    public class WorkerFieldgroup
    {
        public Stringfield[] stringFields { get; set; }
        public Amountfield[] amountFields { get; set; }
        public Indicatorfield[] indicatorFields { get; set; }
    }
    public class Numberfield
    {
        public string itemID { get; set; }
        public int numberValue { get; set; }
        public ShortCode nameCode { get; set; }
    }

    public class Codefield
    {
        public string itemID { get; set; }
        public string codeValue { get; set; }
        public string shortName { get; set; }
        public ShortCode nameCode { get; set; }
    }

    public class Stringfield
    {
        public string itemID { get; set; }
        public string stringValue { get; set; }
        public ShortCode nameCode { get; set; }
    }

    public class Amountfield
    {
        public string itemID { get; set; }
        public int amountValue { get; set; }
        public string currencyCode { get; set; }
        public ShortCode nameCode { get; set; }
    }

    public class Indicatorfield
    {
        public string itemID { get; set; }
        public bool indicatorValue { get; set; }
        public ShortCode nameCode { get; set; }
    }
}
