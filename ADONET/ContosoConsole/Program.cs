using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using Contoso.Repository;
namespace ContosoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository departmentRepository = new DepartmentRepository();
            var Department = departmentRepository.GetAllDepartment();
            Department.ForEach(m=>Console.WriteLine("The department Id = {0}, Name = {1}, Budget = {2}, StartDate = {3}, InstructorId = {4}", m.Id,m.Name,m.Budget,m.StartDate,m.InstructorId));

            Console.WriteLine("---- Get Department By Name ----");
            var department = departmentRepository.GetDepartmentByName("IT");
            Console.WriteLine("The department Id = {0}, Name = {1}, Budget = {2}, StartDate = {3}, InstructorId = {4}", department.Id, department.Name, department.Budget, department.StartDate, department.InstructorId);

            Console.WriteLine("---- Get Department By Id ----");
            department = departmentRepository.GetDepartmentById(4);
            Console.WriteLine("The department Id = {0}, Name = {1}, Budget = {2}, StartDate = {3}, InstructorId = {4}", department.Id, department.Name, department.Budget, department.StartDate, department.InstructorId);

            Console.WriteLine("---- Insert Department ----");
            Department departmentNew = new Department()
            {
                Name = "Logical",
                Budget = 1500,
                StartDate = DateTime.Now,
                InstructorId = 2,
                RowVersion = 3,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
                UpdatedDate = DateTime.Now,
                UpdatedBy = 1
            };
            departmentRepository.AddDepartment(departmentNew);
            Department = departmentRepository.GetAllDepartment();
            Department.ForEach(m => Console.WriteLine("The department Id = {0}, Name = {1}, Budget = {2}, StartDate = {3}, InstructorId = {4}", m.Id, m.Name, m.Budget, m.StartDate, m.InstructorId));

            Console.WriteLine("---- Delete Department ----");
            departmentRepository.DeleteDepartment(4);
            Department = departmentRepository.GetAllDepartment();
            Department.ForEach(m => Console.WriteLine("The department Id = {0}, Name = {1}, Budget = {2}, StartDate = {3}, InstructorId = {4}", m.Id, m.Name, m.Budget, m.StartDate, m.InstructorId));

            Console.WriteLine("---- Update Department ----");
            departmentNew = new Department()
            {
                Id = 5,
                Name = "Logical",
                Budget = 1500,
                StartDate = DateTime.Now,
                InstructorId = 2,
                RowVersion = 3,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
                UpdatedDate = DateTime.Now,
                UpdatedBy = 1
            };
            departmentRepository.UpdateDepartment(departmentNew);
            Department = departmentRepository.GetAllDepartment();
            Department.ForEach(m => Console.WriteLine("The department Id = {0}, Name = {1}, Budget = {2}, StartDate = {3}, InstructorId = {4}", m.Id, m.Name, m.Budget, m.StartDate, m.InstructorId));

            Console.Read();
        }
    }
}
