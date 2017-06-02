using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Roles:Entity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

    }
}
