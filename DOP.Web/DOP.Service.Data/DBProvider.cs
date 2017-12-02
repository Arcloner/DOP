using DOP.Service.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DOP.Service.Data
{
    public class DBProvider : IDBProvider
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DOPConnection"].ConnectionString;


        public List<DepartmentDto> GetAllDepartments()
        {
            string commandName = "GetAllDepartments";
            List<DepartmentDto> result = new List<DepartmentDto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = commandName;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow dataRow in table.Rows)
                        {
                            result.Add(new DepartmentDto { DepartmentId = (int)dataRow[0], Name = (string)dataRow[1], PhoneNumber = (string)dataRow[2], Adress = (string)dataRow[3], Details = (string)dataRow[4] });
                        }
                    }
                }
            }
            return result;
        }

        public List<PersonnelDto> GetAllPersonnel()
        {
            string commandName = "GetAllPersonnel";
            List<PersonnelDto> result = new List<PersonnelDto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = commandName;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow dataRow in table.Rows)
                        {
                            result.Add(new PersonnelDto { PersonnelId = (int)dataRow[0], Name = (string)dataRow[1], LastName = (string)dataRow[2], MiddleName = (string)dataRow[3], DepartmentId = (int)dataRow[4], ContactId = (int)dataRow[5], Adress = (string)dataRow[6], FamilyState = (bool)dataRow[7], Photo = (string)dataRow[8] });
                        }
                    }
                }
            }
            return result;
        }
        public DepartmentDto GetDepartmentById(int id)
        {
            string commandName = "GetDepartmentById";
            string paramString = "@departmentId";
            DepartmentDto result = new DepartmentDto();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = commandName;
                    var param = new SqlParameter();
                    param.DbType = DbType.Int32;
                    param.ParameterName = paramString;
                    param.Value = id;
                    command.Parameters.Add(param);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        result = new DepartmentDto { DepartmentId = (int)dataRow[0], Name = (string)dataRow[1], PhoneNumber = (string)dataRow[2], Adress = (string)dataRow[3], Details = (string)dataRow[4] };
                    }
                }
            }
            return result;
        }

        public DepartmentDto GetDepartmentByPersonnelId(int id)
        {
            string commandName = "GetDepartmentByPersonnelId";
            string paramString = "@personnelId";
            DepartmentDto result = new DepartmentDto();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = commandName;
                    var param = new SqlParameter();
                    param.DbType = DbType.Int32;
                    param.ParameterName = paramString;
                    param.Value = id;
                    command.Parameters.Add(param);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        result = new DepartmentDto { DepartmentId = (int)dataRow[0], Name = (string)dataRow[1], PhoneNumber = (string)dataRow[2], Adress = (string)dataRow[3], Details = (string)dataRow[4] };
                    }
                }
            }
            return result;
        }

        public List<PersonnelDto> GetPersonnelByDepartmentId(int id)
        {
            string commandName = "GetPersonnelByDepartmentId";
            string paramString = "@departmentId";
            List<PersonnelDto> result = new List<PersonnelDto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = commandName;
                    var param = new SqlParameter();
                    param.DbType = DbType.Int32;
                    param.ParameterName = paramString;
                    param.Value = id;
                    command.Parameters.Add(param);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow dataRow in table.Rows)
                        {
                            result.Add(new PersonnelDto { PersonnelId = (int)dataRow[0], Name = (string)dataRow[1], LastName = (string)dataRow[2], MiddleName = (string)dataRow[3], DepartmentId = (int)dataRow[4], ContactId = (int)dataRow[5], Adress = (string)dataRow[6], FamilyState = (bool)dataRow[7], Photo = (string)dataRow[8] });
                        }
                    }
                }
            }
            return result;
        }

        public PersonnelDto GetPersonnelById(int id)
        {
            string commandName = "GetPersonnelById";
            string paramString = "@personnelId";
            PersonnelDto result = new PersonnelDto();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = commandName;
                    var param = new SqlParameter();
                    param.DbType = DbType.Int32;
                    param.ParameterName = paramString;
                    param.Value = id;
                    command.Parameters.Add(param);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow dataRow in table.Rows)
                        {
                            result = new PersonnelDto { PersonnelId = (int)dataRow[0], Name = (string)dataRow[1], LastName = (string)dataRow[2], MiddleName = (string)dataRow[3], DepartmentId = (int)dataRow[4], ContactId = (int)dataRow[5], Adress = (string)dataRow[6], FamilyState = (bool)dataRow[7], Photo = (string)dataRow[8] };
                        }
                    }
                }
            }
            return result;
        }
    }
}
