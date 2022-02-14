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
    public partial class CustSingUp : Form
    {
        public CustSingUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id =int.Parse(tbUN.Text);            
            string Name = tbName.Text;
            string address = tbAddress.Text;            
            long phNo =long.Parse( tbMN.Text);
            string pswrd = tbPswrd.Text;
                        

            Customer customer = new Customer(id, Name, address, phNo, pswrd);
            try
            {
                DBQ1.AddCustomerRecord(customer);
                MessageBox.Show("Record Successfully Added");
                tbUN.Text = "";
                tbName.Text = "";                
                tbAddress.Text = "";                
                tbMN.Text = "";
                tbPswrd.Text = "";


            }
            catch (Exception es)
            {
                MessageBox.Show("ERROR!!! In Adding Record");
                throw;
            }
        }

        private void CustSingUp_Load(object sender, EventArgs e)
        {

        }
    }
}
