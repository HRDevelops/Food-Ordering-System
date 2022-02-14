using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using FoodOrderingSystemv1._0.Controls;

namespace FoodOrderingSystemv1._0.PAL
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OrderMeal obj = new OrderMeal();
            obj.Show();
            //this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        CustCartMeal obj = new CustCartMeal();

        public static int ordercount = 0;
        public  string priceCount;
        public string quantityCount;
        public string tpCount;

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = obj.ProductID;
            string Name = obj.ProductName;
            string Desc = obj.ProductDesc;
            string Price = obj.ProductPrice;
            string Quantity = obj.ProductQuantity;
            string Transfers = cbTT.Text;
            string Addres = cbAddress.Text;

            /*priceCount = int.Parse(Price);
            quantityCount = int.Parse(Quantity);
            tpCount = priceCount * quantityCount;
            ++ordercount;
            Order order = new Order(tpCount);*/
            try
            {
                DAL.DBQ1.CCart(ID, Name, Desc, Price, Quantity, Transfers,Addres);
                //DAL.DBQ1.AddOrderRecord(order);
                MessageBox.Show("Ordered");
                DAL.DBQ1.DeleteCartRecord(ID);
            }
            catch (Exception)
            {
                MessageBox.Show("Error In Ordering !");
            }
        }

        private void lblTPrice_Click(object sender, EventArgs e)
        {

        }
        DAL.DBQ1 db = new DAL.DBQ1();
        private void Cart_Load(object sender, EventArgs e)
        {
            db.GetCart1("select*from Cart1 limit 2",flowLayoutPanel1);
            SqlDataReader reader = DAL.DBQ1.GetDefaultData();
            while (reader.Read())
            {
                cbAddress.Items.Add(reader["CustAddress"].ToString());
            }
            string s;

            //db.GetProductPrice("select Sum(Price*Quantity) from product", lblTPrice.Text);
            int n = 0;
            int q = 1;
            int t = 0;
           lblTPrice.Text = "";
            CustCartMeal obj1 = new CustCartMeal();
            n = int.Parse(obj1.ProductPrice);
            q = int.Parse(obj1.ProductQuantity);
            t = n * q;
            //lblTPrice.Text = obj1.ProductPrice;
            lblTPrice.Text = t.ToString();
        }
    }
}
