﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystemv1._0.Controls
{
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        DAL.DBQ1 db = new DAL.DBQ1();

        private void UC_Customers_Load(object sender, EventArgs e)
        {
            db.GetCustomer("select * from Customer", FLP2);
        }
    }
}
