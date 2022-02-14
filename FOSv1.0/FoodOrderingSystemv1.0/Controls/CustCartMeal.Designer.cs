
namespace FoodOrderingSystemv1._0.Controls
{
    partial class CustCartMeal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustCartMeal));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnProdRemove = new System.Windows.Forms.Button();
            this.pbProdImage = new System.Windows.Forms.PictureBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.circleButtons3 = new FoodOrderingSystemv1._0.PAL.CircleButtons();
            this.circleButtons4 = new FoodOrderingSystemv1._0.PAL.CircleButtons();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnProdRemove
            // 
            this.btnProdRemove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProdRemove.FlatAppearance.BorderSize = 0;
            this.btnProdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdRemove.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdRemove.Location = new System.Drawing.Point(145, 101);
            this.btnProdRemove.Name = "btnProdRemove";
            this.btnProdRemove.Size = new System.Drawing.Size(99, 30);
            this.btnProdRemove.TabIndex = 25;
            this.btnProdRemove.Text = "Done";
            this.btnProdRemove.UseVisualStyleBackColor = true;
            // 
            // pbProdImage
            // 
            this.pbProdImage.Image = ((System.Drawing.Image)(resources.GetObject("pbProdImage.Image")));
            this.pbProdImage.Location = new System.Drawing.Point(296, 3);
            this.pbProdImage.Name = "pbProdImage";
            this.pbProdImage.Size = new System.Drawing.Size(135, 131);
            this.pbProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProdImage.TabIndex = 21;
            this.pbProdImage.TabStop = false;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdPrice.Location = new System.Drawing.Point(39, 61);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(43, 22);
            this.lblProdPrice.TabIndex = 22;
            this.lblProdPrice.Text = "600";
            this.lblProdPrice.Click += new System.EventHandler(this.lblProdPrice_Click);
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProdDesc.Location = new System.Drawing.Point(7, 30);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(153, 19);
            this.lblProdDesc.TabIndex = 23;
            this.lblProdDesc.Text = "Special Chinese Item";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(36, 5);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(238, 25);
            this.lblProdName.TabIndex = 24;
            this.lblProdName.Text = "Black Pepper Chicken";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(63, 105);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(19, 21);
            this.lblQuantity.TabIndex = 26;
            this.lblQuantity.Text = "2";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 25);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "1";
            // 
            // circleButtons3
            // 
            this.circleButtons3.FlatAppearance.BorderSize = 0;
            this.circleButtons3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.circleButtons3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.circleButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtons3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButtons3.Location = new System.Drawing.Point(103, 100);
            this.circleButtons3.Name = "circleButtons3";
            this.circleButtons3.Size = new System.Drawing.Size(26, 30);
            this.circleButtons3.TabIndex = 28;
            this.circleButtons3.Text = "+";
            this.circleButtons3.UseVisualStyleBackColor = true;
            this.circleButtons3.Click += new System.EventHandler(this.circleButtons3_Click);
            // 
            // circleButtons4
            // 
            this.circleButtons4.BackColor = System.Drawing.Color.Transparent;
            this.circleButtons4.FlatAppearance.BorderSize = 0;
            this.circleButtons4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.circleButtons4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.circleButtons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButtons4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButtons4.Location = new System.Drawing.Point(11, 99);
            this.circleButtons4.Name = "circleButtons4";
            this.circleButtons4.Size = new System.Drawing.Size(26, 30);
            this.circleButtons4.TabIndex = 27;
            this.circleButtons4.Text = "-";
            this.circleButtons4.UseVisualStyleBackColor = false;
            this.circleButtons4.Click += new System.EventHandler(this.circleButtons4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rs:";
            this.label1.Click += new System.EventHandler(this.lblProdPrice_Click);
            // 
            // CustCartMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.circleButtons3);
            this.Controls.Add(this.circleButtons4);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnProdRemove);
            this.Controls.Add(this.pbProdImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblProdDesc);
            this.Controls.Add(this.lblProdName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustCartMeal";
            this.Size = new System.Drawing.Size(434, 140);
            this.Load += new System.EventHandler(this.CustCartMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnProdRemove;
        private System.Windows.Forms.PictureBox pbProdImage;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.Label lblProdName;
        private PAL.CircleButtons circleButtons3;
        private PAL.CircleButtons circleButtons4;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
    }
}
