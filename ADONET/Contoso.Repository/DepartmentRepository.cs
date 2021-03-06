﻿using System;
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
    public class DepartmentRepository:ICrudService<Departments>
    {
        string cs = ConfigurationManager.ConnectionStrings["ContosoDbContext"].ConnectionString;
  
        public Departments GetDepartmentByName(string name)
        {
            Departments dep = new Departments();
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
                    //dep.InstructorId = Convert.ToInt32(reader["InstructorId"]);
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

        public int Create(Departments department)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("CreateDepartment", connection);
            command.Parameters.AddWithValue("@name", department.Name);
            command.Parameters.AddWithValue("@Budget", department.Budget);
            command.Parameters.AddWithValue("@StartDate", department.StartDate);
            //command.Parameters.AddWithValue("@instructorid", department.InstructorId);
            command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            command.Parameters.AddWithValue("@CreatedBy", 1);
            var departmentId = command.Parameters.Add("@Id", SqlDbType.Int);
            departmentId.Direction = ParameterDirection.ReturnValue;

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

        public void Update(Departments department)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("UpdateDepartment", connection);
            command.Parameters.AddWithValue("@Id", department.Id);
            command.Parameters.AddWithValue("@name", department.Name);
            command.Parameters.AddWithValue("@Budget", department.Budget);
            command.Parameters.AddWithValue("@StartDate", department.StartDate);
           // command.Parameters.AddWithValue("@instructorid", department.InstructorId);
            command.Parameters.AddWithValue("@RowVersion", 1);
            command.Parameters.AddWithValue("@UpdatedBy", 1);
            command.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);

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

        public Departments Get(int id)
        {
            Departments department = new Departments();
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
                    //department.InstructorName = reader["InstructorName"].ToString();
                    //department.InstructorId = Convert.ToInt32(reader["InstructorId"]);
                    department.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    department.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
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

        public IEnumerable<Departments> GetAll()
        {
            List<Departments> depts = new List<Departments>();
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetAllDepartment", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Departments dep = new Departments();
                    dep.Id = Convert.ToInt32(reader["Id"]);
                    dep.Budget = Convert.ToInt32(reader["Budget"]);
                    dep.Name = reader["Name"].ToString();
                    //dep.InstructorName = reader["InstructorName"].ToString();
                    //dep.InstructorId = Convert.ToInt32(reader["InstructorId"]);
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
