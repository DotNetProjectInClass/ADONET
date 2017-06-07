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
        public void SaveInstructor(Instructor instructor)
        {
            int id = _instructorRepository.Create(instructor);
        }
    }
}
