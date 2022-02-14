using System;
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
    public partial class OrdersEmpCont : UserControl
    {
        public OrdersEmpCont()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public string ProductID
        {
            get { return lblProdD.Text; }
            set { lblProdD.Text = value; }
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

        public string ProductQuantity
        {
            get { return lblProdQuantity.Text; }
            set { lblProdQuantity.Text = value; }
        }

        public string TT
        {
            get { return lblTT.Text; }
            set { lblTT.Text = value; }
        }

        public string Address
        {
            get { return lblAddress.Text; }
            set { lblAddress.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are U Sure?", "Confirmation Deletation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DAL.DBQ1.DeleteCart2Record(lblProdD.Text,lblProdQuantity.Text,lblTT.Text,lblAddress.Text);
                MessageBox.Show("Deletion Successful");
            }
            else
            {
                MessageBox.Show("Delection Cancled!");
            }
        }
    }
    
}
