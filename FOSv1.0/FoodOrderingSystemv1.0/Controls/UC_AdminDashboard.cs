using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodOrderingSystemv1._0.DAL;
//using FoodOrderingSystemv1._0.DAL;
namespace FoodOrderingSystemv1._0.Controls
{
    public partial class UC_AdminDashboard : UserControl
    {
        public UC_AdminDashboard()
        {
            InitializeComponent();
        }
        DBQ1 d=new DBQ1();
        private void UC_AdminDashboard_Load(object sender, EventArgs e)
        {
            //int n=0, m=0;
            //SqlDataReader reader = DBQ1.DashBoard1();

            //  DAL.DBQ1.DashBoard1();
            //lblUsers.Text = m.ToString();
            //lblEmployees.Text = n.ToString();
            SqlDataReader reader = DBQ1.DashBoard1();

            while (reader.Read())
            {
                //cmbID.Items.Add(reader["ID"].ToString());
                LblCustomers = reader[""].ToString();
            }

            SqlDataReader reader1 = DBQ1.DashBoard2();

            while (reader1.Read())
            {
                //cmbID.Items.Add(reader["ID"].ToString());
                lblEmployees.Text = reader1[""].ToString();
            }

            SqlDataReader reader2 = DBQ1.DashBoard3();

            while (reader2.Read())
            {
                //cmbID.Items.Add(reader["ID"].ToString());
                lblOrder.Text = reader2[""].ToString();
            }

            SqlDataReader reader3 = DBQ1.DashBoard4();

            while (reader3.Read())
            {
                //cmbID.Items.Add(reader["ID"].ToString());
                lblRevenue.Text = reader3[""].ToString();
            }

        }


        public string LblOrders
        {
            get { return lblOrder.Text; }
            set { lblOrder.Text = value; }
        }

        public string LblEmployees
        {
            get { return lblEmployees.Text; }
            set { lblEmployees.Text = value; }
        }

        public string LblCustomers
        {
            get { return lblUsers.Text; }
            set { lblUsers.Text = value; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lblCR_Click(object sender, EventArgs e)
        {

        }
    }
}
