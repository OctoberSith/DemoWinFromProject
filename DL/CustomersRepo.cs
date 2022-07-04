using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DL
{
    public class CustomersRepo : IRepo<Customers>
    {
        string constring = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        
        public List<Customers> GetAll()
        {
            List<Customers> customers = new List<Customers>();
            string sqlQuery =@"SELECT * FROM CUSTOMERS";

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers();
                    customer.CustomerID = reader.GetInt32(0);
                    customer.LastName = reader.GetString(1);
                    customer.FirstName = reader.GetString(2);
                    customer.Address = reader.GetString(3);
                    customer.City = reader.GetString(4);
                    customers.Add(customer);
                }
            }
            return customers;
        }
    }
}
