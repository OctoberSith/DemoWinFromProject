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
    public partial class DeleteCustomer : UserControl
    {
        Customers p_custSearch = new Customers();
        Customers p_custFind = new Customers();

        private void DisplayDelMessage()
        {
            string message = "Are you sure you want to delete? This is Permanent!!!";
            string title = "WARNING:DELETE";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Customer Was Deleted !!");
                //TODO:IMPLEMENT DELETE
            }
            else
            {
                MessageBox.Show("Customer Was Not Deleted");
            }

        }


        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            p_custSearch.LastName = txtFindLast.Text;
            p_custSearch.FirstName = txtFindFirst.Text;

            string sqlQuery = @"SELECT CustomerID, FirstName, Lastname FROM Customers WHERE FirstName = @FirstName AND LastName = @LastName";
            string conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@FirstName", p_custSearch.FirstName);
                command.Parameters.AddWithValue("@LastName", p_custSearch.LastName);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    p_custFind.CustomerID = reader.GetInt32(0);
                    p_custFind.FirstName = reader.GetString(1);
                    p_custFind.LastName = reader.GetString(2);
                }
            }
            rtbFind.Clear();
            rtbFind.AppendText("ID#: " + p_custFind.CustomerID + "\n");
            rtbFind.AppendText(p_custFind.FirstName + "\n" + p_custFind.LastName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisplayDelMessage();
        }
    }
}
