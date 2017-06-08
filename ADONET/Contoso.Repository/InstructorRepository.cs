using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
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
            var instructorId = 0;
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
            var returnParameter = command.Parameters.Add("@InstructorId", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();              
                SqlDataReader reader = command.ExecuteReader();
                instructorId = Convert.ToInt32(returnParameter.Value);

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
            return instructorId;
        }

        public int CreateSeparately(Instructor instructor)
        {
            int instructorInt32 = 0;
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("CreatePeople", connection);
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
            var peopleId = command.Parameters.Add("@Id", SqlDbType.Int);
            peopleId.Direction = ParameterDirection.ReturnValue;

            SqlCommand command2 = new SqlCommand("CreateInstructorSingleTable", connection);
            command2.Parameters.AddWithValue("@hiredate", instructor.HireDate);
            command2.Parameters.AddWithValue("@salary", instructor.Salary);
            var instructorId = command2.Parameters.Add("@Id", SqlDbType.Int);
            instructorId.Direction = ParameterDirection.ReturnValue;

            SqlCommand command3 = new SqlCommand("CreatePersonRole", connection);
            command3.Parameters.AddWithValue("@RoleName", "Instructor");
            
            command.CommandType = CommandType.StoredProcedure;
            command2.CommandType = CommandType.StoredProcedure;
            command3.CommandType = CommandType.StoredProcedure;

            try
            {
                connection.Open();
                command.ExecuteReader();
                var peopleIdInt32 = Convert.ToInt32(peopleId.Value);

                command2.Parameters.AddWithValue("@PeopleId", peopleIdInt32);
                command2.ExecuteReader();
                instructorInt32 = Convert.ToInt32(instructorId.Value);

                command3.Parameters.AddWithValue("@PersonId", peopleIdInt32);
                command3.ExecuteReader();
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
            return instructorInt32;
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
            List<Instructor> instructors = new List<Instructor>();
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetAllInstructor", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    instructors.Add(new Instructor()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        HireDate =reader["HireDate"] == null ? DateTime.MinValue:Convert.ToDateTime(reader["HireDate"]),
                        PeopleId = reader["PeopleId"] == null? 0: Convert.ToInt32(reader["PeopleId"]),
                        Salary =  Convert.ToDouble(reader["Salary"]),
                        Email = reader["Email"] == null ? "-": reader["Email"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName =  reader["LastName"].ToString(),
                        SSN = reader["ssn"] == null ? "-": reader["ssn"].ToString(),
                        DateOfBirth = reader["DateOfBirth"] == null ? DateTime.MinValue : Convert.ToDateTime(reader["DateOfBirth"]),
                        Phone = reader["Phone"] == null ?"-" :reader["Phone"].ToString(),
                        State = reader["State"] == null ? "-": reader["State"].ToString()
                    });
                }
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
            return instructors;
        }
    }
}
