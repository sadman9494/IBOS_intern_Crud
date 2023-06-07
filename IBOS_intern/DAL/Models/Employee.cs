using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string eName { get; set; }
        public string code { get; set; }
        public double salary { get; set; }

        public ICollection<EmployeeAttendance> attendence { get; set; }
        public Employee()
        {
            this.attendence = new HashSet<EmployeeAttendance>();
        }

    }
}
