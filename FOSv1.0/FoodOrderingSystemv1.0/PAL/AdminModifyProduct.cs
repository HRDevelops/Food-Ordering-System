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
    public partial class AdminModifyProduct : Form
    {
        public AdminModifyProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (AdminAddProduct uu = new AdminAddProduct())
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
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
        private void AdminModifyProduct_Load(object sender, EventArgs e)
        {
            db.GetModProduct("Select*from Product", flowLayoutPanel1);
        }
    }
}
