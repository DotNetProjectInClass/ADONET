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
    public class PeopleRepositary
    {
        string cs = ConfigurationManager.ConnectionStrings["ContosoDbContext"].ConnectionString;
        public string QueryPeopleNameById(int id)
        {
            StringBuilder name = new StringBuilder();
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("QueryPeopleNameById", connection);
            command.Parameters.AddWithValue("@id", id);
            SqlParameter outputFirstName = new SqlParameter("@firstname", SqlDbType.VarChar,100)
            {
                Direction = ParameterDirection.Output
            };
            SqlParameter outputLastName = new SqlParameter("@lastname", SqlDbType.VarChar,100)
            {
                Direction = ParameterDirection.Output
            };
            SqlParameter outputMiddleName = new SqlParameter("@middlename", SqlDbType.VarChar,50)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(outputMiddleName);
            command.Parameters.Add(outputFirstName);
            command.Parameters.Add(outputLastName);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                string firstname = outputFirstName.Value==null?"": outputFirstName.Value.ToString();
                string lastname = outputLastName.Value==null?"": outputLastName.Value.ToString();
                string middlename = outputMiddleName.Value == null? "":outputMiddleName.Value.ToString();
                name.Append(firstname+ " ");
                if (middlename != String.Empty)
                {
                    name.Append(middlename + " ");
                }
                name.Append(lastname);
                
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
            return name.ToString();
        }
    }
}
