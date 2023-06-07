using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EmployeeAttendance
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public bool present { get; set; }
        public bool absent { get; set; }
        public bool offday { get; set; }

        public int eId { get; set; }
        public virtual Employee employees { get; set; }

    }
}
