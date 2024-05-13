using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS
{
    public class EmployeersDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=KYS;integrated security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Employeers> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Employeers ", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Employeers> employeers= new List<Employeers>();

            while (reader.Read())
            {
                Employeers employeer = new Employeers
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Surname = Convert.ToString(reader["Surname"]),
                    Job = Convert.ToString(reader["Job"]),
                    Salary = Convert.ToInt32(reader["Salary"])

                };
                employeers.Add(employeer);
            }
            reader.Close();
            _connection.Close();
            return employeers;

        }
        public void Add(Employeers employeer)
        {
            ConnectionControl();
            SqlCommand command1 = new SqlCommand("DBCC CHECKIDENT (‘Employeers’,RESEED,0)", _connection);
            SqlCommand command = new SqlCommand("Insert into Employeers values(@Name,@Surname,@Job,@Salary)", _connection);
            command.Parameters.AddWithValue("@Name", employeer.Name);
            command.Parameters.AddWithValue("@Surname", employeer.Surname);
            command.Parameters.AddWithValue("@Job", employeer.Job);
            command.Parameters.AddWithValue("@Salary", employeer.Salary);
            
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(Employeers employeer)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Employeers set Name=@Name,Surname=@Surname,Job=@Job, Salary=@Salary where Id=@Id", _connection);

            command.Parameters.AddWithValue("@Name", employeer.Name);
            command.Parameters.AddWithValue("@Surname", employeer.Surname);
            command.Parameters.AddWithValue("@Job", employeer.Job);
            command.Parameters.AddWithValue("@Salary", employeer.Salary);
            command.Parameters.AddWithValue("@Id", employeer.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Employeers where Id=@Id", _connection);
            SqlCommand command1 = new SqlCommand("SELECT COUNT(Id) FROM Employeers", _connection);
            command.Parameters.AddWithValue("@Id", id);
            int rowCount = (int)command1.ExecuteScalar();
            command.ExecuteNonQuery();
            if (rowCount == 1)
            {
                Truncate();
            }
            _connection.Close();
        }

        public void Truncate()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Truncate Table Employeers", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
