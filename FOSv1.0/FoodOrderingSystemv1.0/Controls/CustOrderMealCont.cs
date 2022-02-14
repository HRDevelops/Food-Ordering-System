using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FoodOrderingSystemv1._0.DAL;

namespace FoodOrderingSystemv1._0.Controls
{
    public partial class CustOrderMealCont : UserControl
    {
        public CustOrderMealCont()
        {
            InitializeComponent();

        }

        public string ProductID
        {
            get { return lblProductID.Text; }
            set { lblProductID.Text = value; }
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
        /*Image im;
        public Image ProductImage
        {
            get { return pbProdImage.Image; }
            set=>pbProdImage=;
        }*/

        private void CustOrderMealCont_Load(object sender, EventArgs e)
        {

        }
        
        
        private void btnAC_Click(object sender, EventArgs e)
        {
            
            string ID = lblProductID.Text;
            string Name = lblProdName.Text;
            string Desc = lblProdDesc.Text;
            string Price = lblProdPrice.Text;
            string Quantity = lblQuantity.Text;

           // long up = long.Parse(ProductPrice);
            //int qt = int.Parse(ProductQuantity);

            Cart ANF = new Cart(ID, Name, Price, Desc, Quantity);
            //Order order = new Order(up,qt);
            try
            {
                DAL.DBQ1.ACart(ANF);
                //DAL.DBQ1.AddOrderRecord(order);
                MessageBox.Show("Ordered");
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Ordering !");
                throw;
            }
        }
        public static int c=1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            c++;
            if (c <= 10)
                lblQuantity.Text = c.ToString();
            else
                MessageBox.Show("Max Place Order is 10");
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            c--;
            if (c > 0)
                lblQuantity.Text = c.ToString();
            else
                MessageBox.Show("Plz! Place atleast one order");
        }

        // private void lblProdName_Click(object sender, EventArgs e)
        //{
        //  OnClick(e);
        //}

        //private void custordermealcont_click(object sender, EventArgs e)
        //{
        //    this.OnClick(e);
        //}
    }
}
