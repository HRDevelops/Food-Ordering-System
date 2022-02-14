using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystemv1._0.PAL
{
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void GP1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ordersEmpCont1_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CusLogin obj = new CusLogin();
            obj.Show();
            this.Hide();
        }

        DAL.DBQ1 db = new DAL.DBQ1();

        private void button15_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        DAL.DBQ1 db1 = new DAL.DBQ1();
        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            db1.GetCart2("Select*from Cart2",flowLayoutPanel1);
        }
    }
}
