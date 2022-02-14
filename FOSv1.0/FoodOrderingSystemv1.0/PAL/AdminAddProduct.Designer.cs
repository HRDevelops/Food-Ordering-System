
namespace FoodOrderingSystemv1._0.PAL
{
    partial class AdminAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddProduct));
            this.GP1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.GP1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP1
            // 
            this.GP1.BorderRadius = 15;
            this.GP1.Controls.Add(this.lblProductID);
            this.GP1.Controls.Add(this.tbName);
            this.GP1.Controls.Add(this.lblName);
            this.GP1.Controls.Add(this.tbID);
            this.GP1.Controls.Add(this.lblID);
            this.GP1.Controls.Add(this.tbPrice);
            this.GP1.Controls.Add(this.lblPrice);
            this.GP1.Controls.Add(this.lblDesc);
            this.GP1.Controls.Add(this.rtbDesc);
            this.GP1.Controls.Add(this.btnSave);
            this.GP1.Controls.Add(this.btnBack);
            this.GP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GP1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.GP1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.GP1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.GP1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.GP1.ForeColor = System.Drawing.Color.White;
            this.GP1.Location = new System.Drawing.Point(0, 0);
            this.GP1.Name = "GP1";
            this.GP1.ShadowDecoration.Parent = this.GP1;
            this.GP1.Size = new System.Drawing.Size(500, 600);
            this.GP1.TabIndex = 22;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.BackColor = System.Drawing.Color.Transparent;
            this.lblProductID.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(161, 10);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(124, 21);
            this.lblProductID.TabIndex = 27;
            this.lblProductID.Text = "Add Product";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.tbName.Location = new System.Drawing.Point(260, 152);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 23);
            this.tbName.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Product Name";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.tbID.Location = new System.Drawing.Point(260, 84);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(191, 23);
            this.tbID.TabIndex = 24;
            this.tbID.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(49, 87);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(87, 20);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "Product ID";
            this.lblID.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.tbPrice.Location = new System.Drawing.Point(260, 347);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(191, 23);
            this.tbPrice.TabIndex = 24;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(49, 350);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 20);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Product Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(49, 254);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(153, 20);
            this.lblDesc.TabIndex = 22;
            this.lblDesc.Text = "Product Description";
            // 
            // rtbDesc
            // 
            this.rtbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.rtbDesc.Location = new System.Drawing.Point(260, 208);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(191, 96);
            this.rtbDesc.TabIndex = 26;
            this.rtbDesc.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(127, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 54);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 35);
            this.btnBack.TabIndex = 17;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AdminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.GP1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddProduct";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdminAddProduct_Load);
            this.GP1.ResumeLayout(false);
            this.GP1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel GP1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProductID;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
    }
}