
namespace FoodOrderingSystemv1._0.Controls
{
    partial class AdminModProdCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminModProdCont));
            this.btnProdRemove = new System.Windows.Forms.Button();
            this.pbProdImage = new System.Windows.Forms.PictureBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdRemove
            // 
            this.btnProdRemove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProdRemove.FlatAppearance.BorderSize = 0;
            this.btnProdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdRemove.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdRemove.Location = new System.Drawing.Point(87, 104);
            this.btnProdRemove.Name = "btnProdRemove";
            this.btnProdRemove.Size = new System.Drawing.Size(99, 30);
            this.btnProdRemove.TabIndex = 19;
            this.btnProdRemove.Text = "Remove";
            this.btnProdRemove.UseVisualStyleBackColor = true;
            this.btnProdRemove.Click += new System.EventHandler(this.btnProdRemove_Click);
            // 
            // pbProdImage
            // 
            this.pbProdImage.Image = ((System.Drawing.Image)(resources.GetObject("pbProdImage.Image")));
            this.pbProdImage.Location = new System.Drawing.Point(302, 3);
            this.pbProdImage.Name = "pbProdImage";
            this.pbProdImage.Size = new System.Drawing.Size(135, 131);
            this.pbProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProdImage.TabIndex = 15;
            this.pbProdImage.TabStop = false;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdPrice.Location = new System.Drawing.Point(6, 60);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(72, 22);
            this.lblProdPrice.TabIndex = 16;
            this.lblProdPrice.Text = "Rs: 700";
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProdDesc.Location = new System.Drawing.Point(6, 30);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(153, 19);
            this.lblProdDesc.TabIndex = 17;
            this.lblProdDesc.Text = "Special Chinese Item";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(35, 5);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(238, 25);
            this.lblProdName.TabIndex = 18;
            this.lblProdName.Text = "Black Pepper Chicken";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(5, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 25);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "1";
            // 
            // AdminModProdCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnProdRemove);
            this.Controls.Add(this.pbProdImage);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblProdDesc);
            this.Controls.Add(this.lblProdName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminModProdCont";
            this.Size = new System.Drawing.Size(440, 140);
            this.Load += new System.EventHandler(this.AdminModProdCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProdRemove;
        private System.Windows.Forms.PictureBox pbProdImage;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.Label lblProdName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblID;
    }
}
