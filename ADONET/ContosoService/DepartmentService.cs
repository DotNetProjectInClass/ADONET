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

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            departments = _departmentRepository.GetAll().ToList();
            return departments;
        }

        public Department GetDepartmentById(int id)
        {
            Department department = _departmentRepository.Get(id);
            return department;
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepository.Update(department);
        }

        public int CreateDepartment(Department department)
        {
            return _departmentRepository.Create(department);
        }
    }
}
