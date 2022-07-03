using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace DemoWinFromProject
{
    public partial class AddCustomer : UserControl
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Load Customer Object
            Customers customers = new Customers();
            customers.LastName = txtLast.Text;
            customers.FirstName = txtFirst.Text;
            customers.Address = txtAddress.Text;
            customers.City = txtCity.Text;

            //Grab Configuration String
            string constring = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            //Create SQL Query
            string sqlQuery = @"INSERT INTO Customers (LastName, FirstName, Address, City)
                            values (@LastName, @FirstName, @Address, @City)";

            //Open a disconnected connection type
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("LastName", customers.LastName.ToUpper());
                command.Parameters.AddWithValue("FirstName", customers.FirstName.ToUpper());
                command.Parameters.AddWithValue("Address", customers.Address.ToUpper()); ;
                command.Parameters.AddWithValue("City", customers.City.ToUpper());
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Customer is Added to Database");

        }
    }
}
