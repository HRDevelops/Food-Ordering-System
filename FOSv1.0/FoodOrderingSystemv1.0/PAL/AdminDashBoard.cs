using FoodOrderingSystemv1._0.Controls;
using Guna.UI2.WinForms;
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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
            UC_AdminDashboard ucAD = new UC_AdminDashboard();
            AddUserControl(ucAD);
        }

        private void gbtnHome_Click(object sender, EventArgs e)
        {

        }

        private void MovePicBox(object sender)
        {
            Guna2Button btn = (Guna2Button)sender;
            imageSlide.Location = new Point(btn.Location.X + 20, btn.Location.Y - 58);
            imageSlide.SendToBack();
        }

        private void AddUserControl(UserControl uc)
        {
            pnlContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            pnlContainer.Controls.Add(uc);
        }

        private void gbtnHome_CheckedChanged(object sender, EventArgs e)
        {
            UC_AdminDashboard uc = new UC_AdminDashboard();
            MovePicBox(sender);
            AddUserControl(uc);
        }

        private void gbtnCustomerInsight_CheckedChanged(object sender, EventArgs e)
        {
            UC_Customers uc = new UC_Customers();
            MovePicBox(sender);
            AddUserControl(uc);
        }

        private void gbtnEmployee_CheckedChanged(object sender, EventArgs e)
        {
            UC_Employees uc = new UC_Employees();
            MovePicBox(sender);
            AddUserControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminModifyProduct obj = new AdminModifyProduct();
            obj.Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            CusLogin obj = new CusLogin();
            obj.Show();
            this.Hide();
        }

        private void gbtnEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
