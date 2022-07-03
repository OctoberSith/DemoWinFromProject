using System;
using System.Configuration;
using DemoWinFromProject.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinFromProject
{
    
    public partial class Main : Form
    {
        //Set Variables
        AddCustomer addCust = new AddCustomer();
        DeleteCustomer delCust = new DeleteCustomer();
        private int count = 0;
        private int added = 0;

        //Add Method
        private void DisplayAdd()
        {
          if (btnAdd.Text == "Add Customer" && btnAdd.BackColor == Color.Gold)
          {
              this.Controls.Remove(addCust);
              btnAdd.BackColor = SystemColors.Control;
              count -= 1;
              added -= 1;
            }
          else if (btnAdd.Text == "Add Customer")
           {
              addCust.Location = new Point(10, 60);
              this.Controls.Add(addCust);
              btnAdd.BackColor = Color.Gold;
              count += 1;
              added += 1;
            }
        }

        //Delete Method
        private void DisplayDel()
        {
            if (btnDelete.Text == "Delete Customer" && btnDelete.BackColor == Color.Gold)
            {
                this.Controls.Remove(delCust);
                btnDelete.BackColor = SystemColors.Control;
                count -= 1;
                added -= 1;
            }
            else if (btnDelete.Text == "Delete Customer")
            {
                delCust.Location = new Point(210, 60);
                this.Controls.Add(delCust);
                btnDelete.BackColor = Color.Gold;
                count += 1;
                added += 1;
            }
        }

        //Change Heading
        private void ChangeHead()
        {
            if(added >= 1)
            {
                gbxUser.Text.Concat(" : " + count + " of " + added);
            }
            else if (added == 0)
            {
                gbxUser.Text = "Menu";
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this.Controls.Add(addCust);
            //btnAdd.BackColor = Color.Gold;
            DisplayAdd();
            ChangeHead();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //this.Controls.Add(delCust);
            //btnDelete.BackColor = Color.Gold;
            DisplayDel();
            ChangeHead();
        }
    }
}
