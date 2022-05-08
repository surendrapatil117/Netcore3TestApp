using Microsoft.EntityFrameworkCore;
using Netcore3TestApp.IServices;
using Netcore3TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore3TestApp.Services
{
    public class DepartmentService : IDepartmentService
    {
       private CorecruidContext dbContext;
        public DepartmentService(CorecruidContext _db)
        {
            dbContext = _db;
        }
       public Department AddDepartment(Department department)
        {
            if (department !=null)
            {
                dbContext.Departments.Add(department);
                dbContext.SaveChanges();
                return department;
            }
            else
            {
                return null;
            }
           
        }

       public Department DeleteDepartment(int id)
        {
            var department = dbContext.Departments.Where(x => x.Id == id).FirstOrDefault();
            if (department!=null)
            {
                //dbContext.Departments.Remove(department);
                dbContext.Entry(department).State = EntityState.Deleted;
                dbContext.SaveChanges();
                return department;

            }
            else
            {
                return null;
            }
        }

       public IEnumerable<Department> GetDepartment()
        {
            var departments = dbContext.Departments.ToList();
            return departments;
        }

       public Department GetDepartmentById(int id)
        {
            var departments = dbContext.Departments.FirstOrDefault(x => x.Id == id);
            return departments;
        }

       public Department UpdateDepartment(Department department)
        {
            dbContext.Entry(department).State = EntityState.Modified;
            dbContext.SaveChanges();
            return department;
        }
    }
}
