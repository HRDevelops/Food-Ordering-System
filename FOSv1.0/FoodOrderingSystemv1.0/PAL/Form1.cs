using FoodOrderingSystemv1._0.PAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using FoodOrderingSystemv1._0.DAL;
using FoodOrderingSystemv1._0.Controls;

namespace FoodOrderingSystemv1._0
{
    public partial class CusLogin : Form
    {
        public CusLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

        }
        public string cid1;

       // public int CID11 { get {return this.cid1;} set {cid1=value; } }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            //OrderMeal obj = new OrderMeal();
            //obj.Show();
            
            /////////////////////
            if (cbRole.Text == "Customer")
            {
                //string s;
                //cid1 =int.Parse( txtUsername.Text);
                //s = txtUsername.Text;
                //CID11 = int.Parse(s);
                try
                {
                    SqlConnection connection = DBQ1.GetConnection();
                    string query = "Select * From Customer where CustID = @CustID AND CustPswrd=@CustPswrd";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CustID", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@CustPswrd", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        OrderMeal obj = new OrderMeal();
                        obj.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
                /////////
            
            if (cbRole.Text == "Employee")
            {
                try
                {
                    SqlConnection connection = DBQ1.GetConnection();
                    string query = "Select * From Employee where EmpID = @EmpID AND EmpPswrd=@EmpPswrd";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@EmpID", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@EmpPswrd", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        EmployeeDashboard obj = new EmployeeDashboard();
                        obj.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbRole.Text == "Admin")
            {
                try
                {
                    SqlConnection connection = DBQ1.GetConnection();
                    string query = "Select * From Admin where AdID = @AdID AND AdPswrd=@AdPswrd";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@AdID", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@AdPswrd", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        AdminDashBoard obj = new AdminDashBoard();
                        obj.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbRole.Text == "")
            {
                MessageBox.Show("ERROR!!! Choose Your Role");
            }
            else
            {
                Console.WriteLine();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //CusLogin obj = new CusLogin();
            //obj.Show();
            //this.Hide();
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            CustSingUp obj = new CustSingUp();
            obj.Show();

            

        }

        public static string sid;
        public string SID{ get {return sid; } set{sid=value; } }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            sid = txtUsername.Text;
            //CustOrderMealCont obj = new CustOrderMealCont("1234");
        }
    }
}
