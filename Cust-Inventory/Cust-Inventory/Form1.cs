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
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Creates an instance of this Class
            if (!pnlMainControls.Controls.Contains(HomeControl.Instance))
            {
                pnlMainControls.Controls.Add(HomeControl.Instance);
                HomeControl.Instance.Dock = DockStyle.Fill;
                HomeControl.Instance.BringToFront();
            }
            else
            {
                HomeControl.Instance.BringToFront();
            }
             
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //Creates an instance of this Class
            if (!pnlMainControls.Controls.Contains(UsersControl.Instance))
            {
                pnlMainControls.Controls.Add(UsersControl.Instance);
                UsersControl.Instance.Dock = DockStyle.Fill;
                UsersControl.Instance.BringToFront();
            }
            else
            {
                UsersControl.Instance.BringToFront();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //Creates an instance of this Class
            if (!pnlMainControls.Controls.Contains(CustomersControl.Instance))
            {
                pnlMainControls.Controls.Add(CustomersControl.Instance);
                CustomersControl.Instance.Dock = DockStyle.Fill;
                CustomersControl.Instance.BringToFront();
            }
            else
            {
                CustomersControl.Instance.BringToFront();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //Creates an instance of this Class
            if (!pnlMainControls.Controls.Contains(ReportsControl.Instance))
            {
                pnlMainControls.Controls.Add(ReportsControl.Instance);
                ReportsControl.Instance.Dock = DockStyle.Fill;
                ReportsControl.Instance.BringToFront();
            }
            else
            {
                ReportsControl.Instance.BringToFront();
            }

        }

        
    }
    
}
