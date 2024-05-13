using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KYS
{
    public class CustomerDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=KYS;integrated security=true");
        
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Customers> GetAll()
        {
            
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Customers ", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Customers> customers = new List<Customers>();
           
            while (reader.Read())
            {
                Customers customer = new Customers
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Surname = Convert.ToString(reader["Surname"]),
                    Transaction = Convert.ToString(reader["Transaction"]),
                    TransactionPrice = Convert.ToInt32(reader["TransactionPrice"]),
                    Date = Convert.ToString(reader["Date"]),
                    
                };
                customers.Add(customer);
            }
            reader.Close();
            _connection.Close();
            return customers;

        }
        public void Add(Customers customer)
        {
            ConnectionControl();
            SqlCommand command1 = new SqlCommand("DBCC CHECKIDENT (‘Customers’,RESEED,0)",_connection);
            SqlCommand command = new SqlCommand("Insert into Customers values(@Name,@Surname,@Transaction,@TransactionPrice,@Date)", _connection);
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Surname", customer.Surname);
            command.Parameters.AddWithValue("@Transaction", customer.Transaction);
            command.Parameters.AddWithValue("@TransactionPrice", customer.TransactionPrice);
            command.Parameters.AddWithValue("@Date", customer.Date);
            command.ExecuteNonQuery();

            _connection.Close ();

        }
        public void Update(Customers customer)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Customers set Name=@Name,Surname=@Surname,Date=@Date where Id=@Id", _connection);
            
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Surname", customer.Surname);
            command.Parameters.AddWithValue("@Transaction", customer.Transaction);
            command.Parameters.AddWithValue("@TransactionPrice", customer.TransactionPrice);
            command.Parameters.AddWithValue("@Date", customer.Date);
            command.Parameters.AddWithValue("@Id", customer.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Customers where Id=@Id", _connection);
            SqlCommand command1 =new SqlCommand("SELECT COUNT(Id) FROM Customers", _connection);
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
            SqlCommand command = new SqlCommand("Truncate Table Customers", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

    }

}
