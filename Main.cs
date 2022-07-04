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

namespace DemoWinFromProject
{
    
    public partial class Main : Form
    {

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
              //this.Controls.Remove(addCust);
              flowLayoutCust.Controls.Remove(addCust);
              btnAdd.BackColor = SystemColors.Control;
              count -= 1;
              ChangeHead();
            }
          else if (btnAdd.Text == "Add Customer")
           {
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
                //this.Controls.Remove(delCust);
                flowLayoutCust.Controls.Remove(delCust);
                btnDelete.BackColor = SystemColors.Control;
                count -= 1;
                ChangeHead();
            }
            else if (btnDelete.Text == "Delete Customer")
            {
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

        private void RefreshGrid()
        {
            List<Customers> CData = new List<Customers>();
            CustomersRepo repoPass = new CustomersRepo();
            CData = repoPass.GetAll();
            dataGridViewCust.DataSource = CData;
            dataGridViewCust.Refresh();
        }


        //Main Form Controls
        public Main()
        {
            CustomersData = repo.GetAll();
            InitializeComponent();
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
            dataGridViewCust.DataSource = CustomersData;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<Customers> refreshcusts = repo.GetAll();
            BindingSource source = new BindingSource();
            source.DataSource = refreshcusts;
            dataGridViewCust.DataSource = source;
        }
    }
}
