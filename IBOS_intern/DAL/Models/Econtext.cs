using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL.Models
{
   internal class Econtext : DbContext
    {
        public DbSet<Employee> employee { get; set; }
        public DbSet<EmployeeAttendance> attendances { get; set; }

    }
}
