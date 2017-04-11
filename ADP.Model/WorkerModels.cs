using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class Workerdates
    {
        public string originalHireDate { get; set; }
        public string terminationDate { get; set; }
        public string rehireDate { get; set; }
    }

    public class Workerstatus
    {
        public Statuscode statusCode { get; set; }
    }

    public class Statuscode
    {
        public string codeValue { get; set; }
    }
}
