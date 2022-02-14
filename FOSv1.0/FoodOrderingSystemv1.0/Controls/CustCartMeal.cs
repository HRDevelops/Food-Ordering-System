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
    public partial class CustCartMeal : UserControl
    {
        public CustCartMeal()
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

        public string ProductQuantity
        {
            get { return lblQuantity.Text; }
            set { lblQuantity.Text = value; }
        }

        private void CustCartMeal_Load(object sender, EventArgs e)
        {

        }

        private void lblProdPrice_Click(object sender, EventArgs e)
        {

        }

        public static int c;

        private void circleButtons4_Click(object sender, EventArgs e)
        {
            c--;
            if (c > 0)
                lblQuantity.Text = c.ToString();
            else
                MessageBox.Show("Plz! Place atleast one order");
        }

        private void circleButtons3_Click(object sender, EventArgs e)
        {
            c++;
            if (c < 10)
                lblQuantity.Text = c.ToString();
            else
                MessageBox.Show("You have reached the max orders");
        }
    }
}
