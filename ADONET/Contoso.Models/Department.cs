using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Department:Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public int? InstructorId { get; set; }
        public int? RowVersion { get; set; }
    }
}
