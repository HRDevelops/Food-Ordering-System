using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystemv1._0.Controls
{
    public partial class RecordsCont : UserControl
    {
        public RecordsCont()
        {
            InitializeComponent();
        }

        public string EmpID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }

        public string EmpName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string EmpAddress
        {
            get { return lblAddress.Text; }
            set { lblAddress.Text = value; }
        }

        public string EmpPswrd
        {
            get;
            set;
        }

        public long EmpCell
        {
            get { return long.Parse(lblCellNo.Text); }
            set { lblCellNo.Text =value.ToString(); }
        }


        private void RecordsCont_Load(object sender, EventArgs e)
        {

        }
    }
}
