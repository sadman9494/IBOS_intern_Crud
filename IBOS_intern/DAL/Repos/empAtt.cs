using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;


namespace DAL.Repos
{
     internal class empAtt : IRepo, IEmployee<EmployeeAttendance, int, List<EmployeeAttendance>>
    {
       

        public void Create(EmployeeAttendance obj)
        {
            db.attendances.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            db.attendances.Remove(GetbyId(id));
            return db.SaveChanges() > 0;
        }

        public List<EmployeeAttendance> GetAll()
        {
            return db.attendances.ToList();
        }

      

        public EmployeeAttendance GetbyId(int obj)
        {
            return db.attendances.Find(obj);
        }

       

        public bool Update(EmployeeAttendance id)
        {
            var x = GetbyId(id.Id);
            db.Entry(x).CurrentValues.SetValues(id);
            return db.SaveChanges() > 0;
        }
    }
}
