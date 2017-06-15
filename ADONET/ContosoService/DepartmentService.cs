using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Repository;
using EFRepository;
using Department = Contoso.Models.Departments;

namespace ContosoService
{
    public class Departmentervice
    {
        private DepartmentRepository _departmentRepository = new DepartmentRepository();
        public void SaveDepartment(Department department)
        {
            int id = _departmentRepository.Create(department);
        }

        public List<GetAllDepartment_Result> GetAllDepartments()
        {
            var departments = new List<GetAllDepartment_Result>();
            using (var db = new EFRepository.StudentEntities())
            {
                var department = new EFRepository.Department()
                {
                    InstructorID = 1,
                    Budget = 1900,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    Name = "Testing From EF",
                    RowVersion = 1
                };
                db.Departments.Add(department);
                db.SaveChanges();                
            }

            using (var db = new EFRepository.StudentEntities())
            {
                departments = db.GetAllDepartment().ToList();
                var testing = db.Departments.ToList();
            }

          
            
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
