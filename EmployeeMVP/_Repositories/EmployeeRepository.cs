using EmployeeMVP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMVP._Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        //constructor
        public EmployeeRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }


        //methods
        public void Add(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Employee values (@name, @gender, @department, @post)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeModel.Name;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = employeeModel.Gender;
                command.Parameters.Add("@department", SqlDbType.NVarChar).Value = employeeModel.Department;
                command.Parameters.Add("@post", SqlDbType.NVarChar).Value = employeeModel.Post;
                command.ExecuteNonQuery();
            }           
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete from employee where employee_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
        public void Update(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Update employee set employee_name=@name, employee_gender=@gender,
                                        employee_department=@department, employee_post=@post
                                        where employee_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = employeeModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeModel.Name;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = employeeModel.Gender;
                command.Parameters.Add("@department", SqlDbType.NVarChar).Value = employeeModel.Department;
                command.Parameters.Add("@post", SqlDbType.NVarChar).Value = employeeModel.Post;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<EmployeeModel> GetAll()
        {
            var employeeList = new List<EmployeeModel>();
            using(var connection=new SqlConnection(connectionString))
            using(var command=new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from employee order by employee_id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employeeModel = new EmployeeModel();
                        employeeModel.Id = (int)reader[0];
                        employeeModel.Name = reader[1].ToString();
                        employeeModel.Gender = reader[2].ToString();
                        employeeModel.Department = reader[3].ToString();
                        employeeModel.Post = reader[4].ToString();
                        employeeList.Add(employeeModel);
                    }
                }
            }
            return employeeList;
        }

        public IEnumerable<EmployeeModel> GetByValue(string value)
        {
            var employeeList = new List<EmployeeModel>();
            int employeeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string employeeName = value;
            string employeeGender = value;
            string employeeDepartment = value;
            string employeePost = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from employee 
                                        where employee_id=@id or
                                        employee_name like @name+'%' or
                                        employee_gender=@gender or
                                        employee_department like '%'+@department+'%' or
                                        employee_post like '%'+@post+'%'
                                        order by employee_id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = employeeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeName;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = employeeGender;
                command.Parameters.Add("@department", SqlDbType.NVarChar).Value = employeeDepartment;
                command.Parameters.Add("@post", SqlDbType.NVarChar).Value = employeePost;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employeeModel = new EmployeeModel();
                        employeeModel.Id = (int)reader[0];
                        employeeModel.Name = reader[1].ToString();
                        employeeModel.Gender = reader[2].ToString();
                        employeeModel.Department = reader[3].ToString();
                        employeeModel.Post = reader[4].ToString();
                        employeeList.Add(employeeModel);
                    }
                }
            }
            return employeeList;
        }

    }
}
