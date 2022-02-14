
namespace FoodOrderingSystemv1._0.PAL
{
    partial class EmployeeDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ordersEmpCont1 = new FoodOrderingSystemv1._0.Controls.OrdersEmpCont();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.Controls.Add(this.ordersEmpCont1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1178, 615);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(1147, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(53, 53);
            this.button15.TabIndex = 43;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(1027, 71);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 20);
            this.lblDate.TabIndex = 41;
            this.lblDate.Text = "Address";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(529, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 20);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Price";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.BackColor = System.Drawing.Color.Transparent;
            this.lblTT.Location = new System.Drawing.Point(814, 71);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(101, 20);
            this.lblTT.TabIndex = 39;
            this.lblTT.Text = "Transfer Type";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.BackColor = System.Drawing.Color.Transparent;
            this.lblProdName.Location = new System.Drawing.Point(644, 71);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(133, 20);
            this.lblProdName.TabIndex = 38;
            this.lblProdName.Text = "Product Quantity";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.BackColor = System.Drawing.Color.Transparent;
            this.lblProductID.Location = new System.Drawing.Point(300, 71);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(153, 20);
            this.lblProductID.TabIndex = 37;
            this.lblProductID.Text = "Product Description";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustName.Location = new System.Drawing.Point(165, 71);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(115, 20);
            this.lblCustName.TabIndex = 36;
            this.lblCustName.Text = "Product Name";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustID.Location = new System.Drawing.Point(58, 71);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(87, 20);
            this.lblCustID.TabIndex = 35;
            this.lblCustID.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Employee Dashboard";
            // 
            // ordersEmpCont1
            // 
            this.ordersEmpCont1.Address = "Adress";
            this.ordersEmpCont1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ordersEmpCont1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ordersEmpCont1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersEmpCont1.ForeColor = System.Drawing.Color.White;
            this.ordersEmpCont1.Location = new System.Drawing.Point(4, 5);
            this.ordersEmpCont1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ordersEmpCont1.Name = "ordersEmpCont1";
            this.ordersEmpCont1.ProductDesc = "Desc";
            this.ordersEmpCont1.ProductID = "P123";
            this.ordersEmpCont1.ProductPrice = "Delivery";
            this.ordersEmpCont1.ProductQuantity = "Ali Ahmad";
            this.ordersEmpCont1.Size = new System.Drawing.Size(1166, 64);
            this.ordersEmpCont1.TabIndex = 0;
            this.ordersEmpCont1.TT = "Delivery";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeDashboard";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Controls.OrdersEmpCont ordersEmpCont1;
    }
}