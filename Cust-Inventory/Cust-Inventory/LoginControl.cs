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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private static LoginControl _instance;
        public static LoginControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginControl();
                }
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
