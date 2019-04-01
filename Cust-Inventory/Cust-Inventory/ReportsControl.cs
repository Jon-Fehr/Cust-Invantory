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
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
        }
        private static ReportsControl _instance;
        public static ReportsControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReportsControl();
                }
                return _instance;
            }
        }

        
    }
}
