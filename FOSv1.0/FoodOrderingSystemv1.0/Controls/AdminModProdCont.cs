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
    public partial class AdminModProdCont : UserControl
    {
        public AdminModProdCont()
        {
            InitializeComponent();
        }

        public string ProductID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }

        public string ProductName
        {
            get { return lblProdName.Text; }
            set { lblProdName.Text = value; }
        }

        public string ProductDesc
        {
            get { return lblProdDesc.Text; }
            set { lblProdDesc.Text = value; }
        }

        public string ProductPrice
        {
            get { return lblProdPrice.Text; }
            set { lblProdPrice.Text = value; }
        }



        private void AdminModProdCont_Load(object sender, EventArgs e)
        {

        }
        
        private void btnProdRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are U Sure?", "Confirmation Deletation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DAL.DBQ1.DeleteProductRecord(lblID.Text);
                MessageBox.Show("Deletion Successful");
            }
            else
            {
                MessageBox.Show("Delection Cancled!");
            }
        }
    }
}
