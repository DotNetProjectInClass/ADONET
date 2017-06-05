using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using Contoso.Repository;

namespace ContosoService
{
    public class DepartmentService
    {
        private DepartmentRepository _departmentRepository = new DepartmentRepository();
        public void SaveDepartment(Departments department)
        {
            _departmentRepository.AddDepartment(department);
        }
    }
}
