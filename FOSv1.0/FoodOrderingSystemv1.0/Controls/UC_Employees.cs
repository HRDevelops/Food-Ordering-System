﻿using FoodOrderingSystemv1._0.PAL;
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

namespace FoodOrderingSystemv1._0.Controls
{
    public partial class UC_Employees : UserControl
    {
        DBQ1 db;
        public UC_Employees()
        {
            InitializeComponent();
            db = new DBQ1();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (AdminAddEmployee uu = new AdminAddEmployee())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void FLP2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {
            db.GetEmployee("select * from Employee",FLP2);
        }

        private void btnAddEmp_Click_1(object sender, EventArgs e)
        {
            AdminAddEmployee obj = new AdminAddEmployee();
            obj.Show();
        }
    }
}
