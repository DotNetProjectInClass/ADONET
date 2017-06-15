using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Departments:Entity
    {
        public int Id { get; set; }
        [Column("DepartmentName")]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Budget { get; set; }
        public DateTime? StartDate { get; set; }
        //public int? InstructorId { get; set; }
        //public string InstructorName { get; set; }
        public int? RowVersion { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
