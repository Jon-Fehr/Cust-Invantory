using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cust_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            homeControl1.Show();
            homeControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeControl1.Show();
            homeControl1.BringToFront();
            usersControl1.Hide();
            customersControl1.Hide();
            reportsControl1.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            homeControl1.Hide();
            usersControl1.Show();
            usersControl1.BringToFront();
            customersControl1.Hide();
            reportsControl1.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            homeControl1.Hide();
            usersControl1.Hide();
            customersControl1.Show();
            customersControl1.BringToFront();
            reportsControl1.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            homeControl1.Hide();
            usersControl1.Hide();
            customersControl1.Hide();
            reportsControl1.Show();
            reportsControl1.BringToFront();
        }
    }
}
