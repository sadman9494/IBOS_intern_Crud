using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL;
namespace BLL.Services
{
    public class empServices
    {
        public static List<empDTO> All()
        {
            var emps = new List<empDTO>();
            var empdb = DataAccessFactory.EmpDataAccess().GetAll();
            foreach (var e in empdb)
            {
                emps.Add(new empDTO()
                {
                    Id = e.Id,
                    eName = e.eName,
                    code = e.code,
                    salary = e.salary
                     
                });
            }
            return emps;
        }

        public static List<empDTO> salary()
        {
            var emps = new List<empDTO>();
            var empdb = DataAccessFactory.EmpDataAccess().GetAll();

            // Find maximum and minimum salaries
            var maxSalary = empdb.Max(e => e.salary);


            // Retrieve employees with maximum salary
            var sortedEmployees = empdb.OrderByDescending(e => e.salary);

            foreach (var e in sortedEmployees)
            {
                emps.Add(new empDTO()

                {
                    Id = e.Id,
                    eName = e.eName,
                    code = e.code,
                    salary = e.salary
                });
            }

            return emps;
        
        }

        public static empDTO getbyid(int id)
        {
           
            var empdb = DataAccessFactory.EmpDataAccess().GetbyId(id);
            var emp = new empDTO()
            {
                Id = empdb.Id,
                eName = empdb.eName,
                code = empdb.code,
                salary = empdb.salary
            };
            return emp;
        }

        public static bool update(empDTO e)
        {
            var empdb = DataAccessFactory.EmpDataAccess().GetbyId(e.Id);
            var allEmployees = DataAccessFactory.EmpDataAccess().GetAll();

            // Check if the updated code already exists
            var existingEmployeeWithCode = allEmployees.FirstOrDefault(emp => emp.code == e.code && emp.Id != e.Id);
            if (existingEmployeeWithCode != null)
            {
                // Duplicate code found, cannot update
                return false;
            }


            empdb.Id = e.Id;
            empdb.eName = e.eName;
            empdb.code = e.code;
            empdb.salary = e.salary;


            return DataAccessFactory.EmpDataAccess().Update(empdb);
        }
    }


}
