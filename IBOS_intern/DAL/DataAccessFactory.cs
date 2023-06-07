using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IEmployee<EmployeeAttendance, int, List<EmployeeAttendance>> AttDataAccess()
        {
            return new empAtt(); 
        }

        public static IEmployee<Employee, int, List<Employee>> EmpDataAccess()
        {
            return new empRepo();
        }

    }
}
