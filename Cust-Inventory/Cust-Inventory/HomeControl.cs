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
    public partial class HomeControl : UserControl
    {
       

        public HomeControl()
        {
            InitializeComponent();
        }

        private static HomeControl _instance;
        public static HomeControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new HomeControl();
                }
                return _instance;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            //Use SQL to make sure this person is a supplier user. 
            // If they are show their information
            //- Name
            //- Weight pricing
            //- New Quotes or email through system.

            //Use try catch statement for this. 
            //In catch statement make sure you show SQL connection issue.
            try
            {

                

                //CustomersControl.showButtons();
                //

                // - Customers
                // - Users
                // - Reports
                


            }
            catch
            {

            }
        }

       
    }
}
