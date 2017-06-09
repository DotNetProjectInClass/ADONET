using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Repository;

namespace ContosoService
{
    public class PeopleService
    {
        private PeopleRepositary _peopleRepositary = new PeopleRepositary();

        public string GetPeopleNameById(int id)
        {
            return _peopleRepositary.QueryPeopleNameById(id);
        }
    }
}
