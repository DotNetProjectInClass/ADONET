using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.Repository
{
    public class InstructorRepository:ICrudService<Instructor>
    {
        string cs = ConfigurationManager.ConnectionStrings["ContosoDbContext"].ConnectionString;

        public int Create(Instructor instructor)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("CreateInstructor", connection);
            command.Parameters.AddWithValue("@firstname", instructor.FirstName);
            command.Parameters.AddWithValue("@lastname", instructor.LastName);
            command.Parameters.AddWithValue("@middlename", instructor.MiddleName);
            command.Parameters.AddWithValue("@DateOfBirth", instructor.DateOfBirth);
            command.Parameters.AddWithValue("@email", instructor.Email);
            command.Parameters.AddWithValue("@CreatedDate", instructor.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", instructor.CreatedBy);
            command.Parameters.AddWithValue("@phone", instructor.Phone);
            command.Parameters.AddWithValue("@state", instructor.State);
            command.Parameters.AddWithValue("@ssn", instructor.SSN);
            command.Parameters.AddWithValue("@hiredate", instructor.HireDate);
            command.Parameters.AddWithValue("@salary", instructor.Salary);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }
            return instructor.Id;
        }

        public void Update(Instructor item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Instructor Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
