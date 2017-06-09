using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using Contoso.Repository;

namespace ContosoService
{
    public class InstructorService
    {
        private InstructorRepository _instructorRepository = new InstructorRepository();
        public int CreateInstructor(Instructor instructor)
        {
           return _instructorRepository.Create(instructor);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructorRepository.GetAll().ToList();
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructorRepository.Get(id);
        }
    }
}
