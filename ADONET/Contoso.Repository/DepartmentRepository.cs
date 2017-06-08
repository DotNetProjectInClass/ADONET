using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using System.Configuration;
using System.Data;
using System.Net.Configuration;

namespace Contoso.Repository
{
    public class DepartmentRepository:ICrudService<Department>
    {
        string cs = ConfigurationManager.ConnectionStrings["ContosoDbContext"].ConnectionString;
  
        public Department GetDepartmentByName(string name)
        {
            Department dep = new Department();
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetDepartmentByName", connection);
            command.Parameters.AddWithValue("@Name", name);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {                   
                    dep.Id = Convert.ToInt32(reader["Id"]);
                    dep.Budget = Convert.ToInt32(reader["Budget"]);
                    dep.Name = reader["Name"].ToString();
                    dep.InstructorId = Convert.ToInt32(reader["InstructorId"]);
                    dep.StartDate = Convert.ToDateTime(reader["StartDate"]);   
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
            return dep;
        }

        public int Create(Department department)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("insertDepartment", connection);
            command.Parameters.AddWithValue("@name", department.Name);
            command.Parameters.AddWithValue("@Budget", department.Budget);
            command.Parameters.AddWithValue("@StartDate", department.StartDate);
            command.Parameters.AddWithValue("@instructorid", department.InstructorId);
            command.Parameters.AddWithValue("@RowVersion", department.RowVersion);
            command.Parameters.AddWithValue("@CreatedDate", department.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", department.CreatedBy);
            command.Parameters.AddWithValue("@UpdatedBy", department.UpdatedBy);
            command.Parameters.AddWithValue("@UpdatedDate", department.UpdatedDate);
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
            return department.Id;
        }

        public void Update(Department department)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("UpdateDepartment", connection);
            command.Parameters.AddWithValue("@Id", department.Id);
            command.Parameters.AddWithValue("@name", department.Name);
            command.Parameters.AddWithValue("@Budget", department.Budget);
            command.Parameters.AddWithValue("@StartDate", department.StartDate);
            command.Parameters.AddWithValue("@instructorid", department.InstructorId);
            command.Parameters.AddWithValue("@RowVersion", department.RowVersion);
            command.Parameters.AddWithValue("@CreatedDate", department.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", department.CreatedBy);
            command.Parameters.AddWithValue("@UpdatedBy", department.UpdatedBy);
            command.Parameters.AddWithValue("@UpdatedDate", department.UpdatedDate);

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
        }

        public void Delete(int id)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("DeleteDepartmentById", connection);
            command.Parameters.AddWithValue("@Id", id);


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
        }

        public Department Get(int id)
        {
            Department department = new Department();
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetDepartmentById", connection);
            command.Parameters.AddWithValue("@Id", id);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    department.Id = Convert.ToInt32(reader["Id"]);
                    department.Budget = Convert.ToInt32(reader["Budget"]);
                    department.Name = reader["Name"].ToString();
                    department.InstructorName = reader["InstructorName"].ToString();
                    department.StartDate = Convert.ToDateTime(reader["StartDate"]);

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
            return department;
        }

        public IEnumerable<Department> GetAll()
        {
            List<Department> depts = new List<Department>();
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetAllDepartment", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Department dep = new Department();
                    dep.Id = Convert.ToInt32(reader["Id"]);
                    dep.Budget = Convert.ToInt32(reader["Budget"]);
                    dep.Name = reader["Name"].ToString();
                    dep.InstructorName = reader["InstructorName"].ToString();
                    dep.InstructorId = Convert.ToInt32(reader["InstructorId"]);
                    dep.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    depts.Add(dep);
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
            return depts;
        }
    }
}
