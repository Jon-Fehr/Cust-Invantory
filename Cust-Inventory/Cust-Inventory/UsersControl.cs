﻿using System;
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
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
        }

        private static UsersControl _instance;
        public static UsersControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsersControl();
                }
                return _instance;
            }
        }
    }
}
