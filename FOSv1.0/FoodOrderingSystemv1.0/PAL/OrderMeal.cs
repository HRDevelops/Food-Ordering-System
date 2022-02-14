using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrderingSystemv1._0.DAL;

namespace FoodOrderingSystemv1._0.PAL
{
    public partial class OrderMeal : Form
    {
        DBQ1 db;
        public OrderMeal()
        {
            InitializeComponent();
            db = new DBQ1();
        }

        private void OrderMeal_Load(object sender, EventArgs e)
        {
            //GP1.Controls.Clear();
            //panelItems.Controls.Clear();
            db.GetProducts("select * from PRoduct", FLP1);
            //db.getButtons("select * from items", GP1);
        }

        /*private void label1_Click(object sender, EventArgs e)
        {            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart obj = new Cart();
            obj.Show();
            //this.Hide();
        }

        /*private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }*/

       /* private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void button15_Click(object sender, EventArgs e)
        {
            CusLogin obj = new CusLogin();
            obj.Show();
            this.Hide();
        }

        private void GP1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
