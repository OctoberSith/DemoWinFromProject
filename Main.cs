using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DL;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoWinFromProject
{
    
    public partial class Main : Form
    {
        int seconds = 0;

        //Set Variables
        AddCustomer addCust = new AddCustomer();
        DeleteCustomer delCust = new DeleteCustomer();
        int count = 0;
        public List<Customers> CustomersData { get; set; }
        CustomersRepo repo = new CustomersRepo();

        //Add Method
        private void DisplayAdd()
        {
          addCust.BackColor = SystemColors.Control;

          if (btnAdd.Text == "Add Customer" && btnAdd.BackColor == Color.Gold)
          {
              //#Method Alpha
              //this.Controls.Remove(addCust);
              flowLayoutCust.Controls.Remove(addCust);
              btnAdd.BackColor = SystemColors.Control;
              count -= 1;
              ChangeHead();
            }
          else if (btnAdd.Text == "Add Customer")
           {
              //#Method Alpha
              //addCust.Location = new Point(10, 60);
              //this.Controls.Add(addCust);
              flowLayoutCust.Controls.Add(addCust);
              btnAdd.BackColor = Color.Gold;
              count += 1;
              ChangeHead();
            }
        }


        //Delete Method
        private void DisplayDel()
        {
            delCust.BackColor = SystemColors.Control;

            if (btnDelete.Text == "Delete Customer" && btnDelete.BackColor == Color.Gold)
            {
                //#Method Alpha
                //this.Controls.Remove(delCust);
                flowLayoutCust.Controls.Remove(delCust);
                btnDelete.BackColor = SystemColors.Control;
                count -= 1;
                ChangeHead();
            }
            else if (btnDelete.Text == "Delete Customer")
            {
                //#Method Alpha
                //delCust.Location = new Point(210, 60);
                //this.Controls.Add(delCust);
                flowLayoutCust.Controls.Add(delCust);
                btnDelete.BackColor = Color.Gold;
                count += 1;
                ChangeHead();
            }
        }


        //Change Heading
        private void ChangeHead()
        {
            if (count >= 1)
            {
                gbxUser.Text = "Menu:[" + count + "]";
            }
            else
            {
                gbxUser.Text = "Menu";
            }
        }

        //Main Form Controls
        public Main()
        {
            //#Method1
            CustomersData = repo.GetAll();

            //#Method3
            //FillDataGridView();
            InitializeComponent();

            dataGridViewRich.ColumnCount = 4;

            //dataGridViewRich.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewRich.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewRich.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewRich.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewRich.Columns[0].Name = "Name";
            dataGridViewRich.Columns[1].Name = "Age";
            dataGridViewRich.Columns[2].Name = "Sex";
            dataGridViewRich.Columns[3].Name = "City";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DisplayAdd();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisplayDel();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //#Method1
            dataGridViewCust.DataSource = CustomersData;
            //Update();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //#Method1
            List<Customers> refreshcusts = repo.GetAll();
            BindingSource source = new BindingSource();
            source.DataSource = refreshcusts;
            dataGridViewCust.DataSource = source;

            //#Method2
            //dataGridViewCust.Rows.Clear();
            //Update();
        }

        //#Method2
        //Manual Load of dataGridViewCust
        //private void Update()
        //{
        //    dataGridViewCust.ColumnCount = 5;
        //    dataGridViewCust.Columns[0].Name = "CustomerID";
        //    dataGridViewCust.Columns[1].Name = "LastName";
        //    dataGridViewCust.Columns[2].Name = "FirstName";
        //    dataGridViewCust.Columns[3].Name = "Address";
        //    dataGridViewCust.Columns[4].Name = "City";


        //    foreach (Customers x in CustomersData)

        //    {
        //        ArrayList row = new ArrayList();
        //        row.Add(x.CustomerID.ToString());
        //        row.Add(x.LastName);
        //        row.Add(x.FirstName);
        //        row.Add(x.Address);
        //        row.Add(x.City);
        //        dataGridViewCust.Rows.Add(row.ToArray());
        //    }

        //}

        //#Method3
        //DataBind
        //TODO:WHY NO WORK?????
        //private void FillDataGridView()
        //{
        //    string select ="SELECT * FROM CUSTOMERS";
        //    string constring = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //    using (SqlConnection myConnection = new SqlConnection(constring))
        //    {
        //        myConnection.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(select,myConnection);
        //        DataTable source = new DataTable();
        //        adapter.Fill(source);
        //        dataGridViewCust.DataSource = source;
        //    }
        //}


        private void timerSpace_Tick(object sender, EventArgs e)
        {
            seconds++;
            picBox.Hide();
            if(seconds == 3)
            {
                picBox.Location = new Point(426, 63);
                picBox.Show();
                timerSpace.Stop();
                MessageBox.Show("Time's Up");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                timerSpace.Interval = 1000;
                timerSpace.Start();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                timerSpace.Stop();
                picBox.Show();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFitGrid2_Click(object sender, EventArgs e)
        {
            dataGridViewRich.Rows.Add(richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text);
        }
    }
}
