using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cust_Inventory
{
    public partial class CustomersControl : UserControl
    {
        public CustomersControl()
        {
            InitializeComponent();
        }

        private void rBNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            lblContactName.Show();
            lblFName.Show();
            lblLName.Show();
            tBFName.Show();
            tBLName.Show();

            lblBusinessName.Hide();
            tBBusinessName.Hide();

            lblPhoneNumber.Hide();
            tBPhoneNumber.Hide();
        }

        private void rBBusinessSearch_CheckedChanged(object sender, EventArgs e)
        {
            lblBusinessName.Show();
            tBBusinessName.Show();

            lblContactName.Hide();
            lblFName.Hide();
            lblLName.Hide();
            tBFName.Hide();
            tBLName.Hide();

            lblPhoneNumber.Hide();
            tBPhoneNumber.Hide();
        }

        private void rBNumberSearch_CheckedChanged(object sender, EventArgs e)
        {
            lblPhoneNumber.Show();
            tBPhoneNumber.Show();

            lblContactName.Hide();
            lblFName.Hide();
            lblLName.Hide();
            tBFName.Hide();
            tBLName.Hide();

            lblBusinessName.Hide();
            tBBusinessName.Hide();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            //todo
            //SQL search that looks up cust info based on what option they choose. 
        }

        private void rBShowAll_CheckedChanged(object sender, EventArgs e)
        {
            lblContactName.Hide();
            lblFName.Hide();
            lblLName.Hide();
            tBFName.Hide();
            tBLName.Hide();

            lblBusinessName.Hide();
            tBBusinessName.Hide();

            lblPhoneNumber.Hide();
            tBPhoneNumber.Hide();
        }
    }
}
