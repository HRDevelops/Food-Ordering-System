using FoodOrderingSystemv1._0.DAL;
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
    public partial class AdminAddProduct : Form
    {
        public AdminAddProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            string Name = tbName.Text;
            string desc = rtbDesc.Text;
            double price = double.Parse(tbPrice.Text);
            //Image img = null;
            


            Product employee = new Product(id, desc, Name, price);
            try
            {
                DBQ1.AddProductRecord(employee);
                MessageBox.Show("Record Successfully Added");
                tbID.Text = "";
                tbName.Text = "";
                rtbDesc.Text = "";
                tbPrice.Text = "";
                


            }
            catch (Exception es)
            {
                MessageBox.Show("ERROR!!! In Adding Record");
                throw;
            }
        }

        private void AdminAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
