using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Student:People
    {
        public int PeopleId { get; set; }
        public DateTime? EnrollmentDate { get; set; }
    }
}
