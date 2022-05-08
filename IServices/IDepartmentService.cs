using Netcore3TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore3TestApp.IServices
{
    interface IDepartmentService
    {
        IEnumerable<Department> GetDepartment();
        Department GetDepartmentById(int id);
        Department AddDepartment(Department department);
        Department UpdateDepartment(Department department);
        Department DeleteDepartment(int id);
    }
}
