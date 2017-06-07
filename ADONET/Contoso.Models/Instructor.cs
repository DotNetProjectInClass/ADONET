using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Instructor:People
    {
        public int PeopleId { get; set; }
        public DateTime? HireDate { get; set; }
        public double Salary { get; set; }
    }
}
