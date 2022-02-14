
namespace FoodOrderingSystemv1._0.PAL
{
    partial class OrderMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMeal));
            this.btnCart = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCart
            // 
            this.btnCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(1069, 6);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(48, 47);
            this.btnCart.TabIndex = 13;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(1142, 11);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(47, 41);
            this.button15.TabIndex = 34;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(570, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 22);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Order Meal";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FLP1
            // 
            this.FLP1.AutoScroll = true;
            this.FLP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.FLP1.Location = new System.Drawing.Point(8, 70);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(1184, 642);
            this.FLP1.TabIndex = 35;
            // 
            // OrderMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.FLP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderMeal";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderMeal";
            this.Load += new System.EventHandler(this.OrderMeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button15;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
    }
}