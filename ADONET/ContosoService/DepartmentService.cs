using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using Contoso.Repository;

namespace ContosoService
{
    public class Departmentervice
    {
        private DepartmentRepository _departmentRepository = new DepartmentRepository();
        public void SaveDepartment(Department department)
        {
            int id = _departmentRepository.Create(department);
        }
    }
}
