using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP.Model
{
    public class Worker
    {
        public string associateOID { get; set; } // done
        public string workerID { get; set; } // need to fix
        public Person Person { get; set; } //Done
        public Workerdates workerDates { get; set; } //done
        public Workerstatus workerStatus { get; set; } // string need to fix
        public Businesscommunication businessCommunication { get; set; } //done
      //  public Workassignment[] workAssignments { get; set; } //
        public Photo[] photos { get; set; } // done
        public WorkerFieldgroup customFieldGroup { get; set; } // workerfieldGruop
    }
}
