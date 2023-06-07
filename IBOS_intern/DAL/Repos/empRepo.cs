using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repos
{
    internal class empRepo : IRepo, IEmployee<Employee, int, List<Employee>>
    {
        public void Create(Employee obj)
        {
            db.employee.Add(obj);
        }

        public bool Delete(int id)
        {
            db.employee.Remove(GetbyId(id));
            return db.SaveChanges() > 0;
        }

        public List<Employee> GetAll()
        {
            return db.employee.ToList();
        }

        public Employee GetbyId(int obj)
        {
            return db.employee.Find();
        }

        public bool Update(Employee id)
        {
            var x = GetbyId(id.Id);
            db.Entry(x).CurrentValues.SetValues(id);
            return db.SaveChanges() > 0;
        }
    }
}
