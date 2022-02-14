
namespace FoodOrderingSystemv1._0.Controls
{
    partial class CustOrderMealCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustOrderMealCont));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAC = new System.Windows.Forms.Button();
            this.pbProdImage = new System.Windows.Forms.PictureBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
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
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "1";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // btnAC
            // 
            this.btnAC.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAC.FlatAppearance.BorderSize = 0;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Location = new System.Drawing.Point(145, 101);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(99, 30);
            this.btnAC.TabIndex = 33;
            this.btnAC.Text = "Add to Cart";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // pbProdImage
            // 
            this.pbProdImage.Image = ((System.Drawing.Image)(resources.GetObject("pbProdImage.Image")));
            this.pbProdImage.Location = new System.Drawing.Point(252, 5);
            this.pbProdImage.Name = "pbProdImage";
            this.pbProdImage.Size = new System.Drawing.Size(135, 131);
            this.pbProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProdImage.TabIndex = 29;
            this.pbProdImage.TabStop = false;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdPrice.Location = new System.Drawing.Point(3, 65);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(72, 22);
            this.lblProdPrice.TabIndex = 30;
            this.lblProdPrice.Text = "Rs: 700";
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProdDesc.Location = new System.Drawing.Point(7, 30);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(153, 19);
            this.lblProdDesc.TabIndex = 31;
            this.lblProdDesc.Text = "Special Chinese Item";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(17, 5);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(238, 25);
            this.lblProdName.TabIndex = 32;
            this.lblProdName.Text = "Black Pepper Chicken";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(-1, 5);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(24, 25);
            this.lblProductID.TabIndex = 37;
            this.lblProductID.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(93, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 26);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "+";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCut
            // 
            this.btnCut.FlatAppearance.BorderSize = 0;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.Location = new System.Drawing.Point(22, 105);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(20, 23);
            this.btnCut.TabIndex = 38;
            this.btnCut.Text = "-";
            this.btnCut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // CustOrderMealCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.pbProdImage);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblProdDesc);
            this.Controls.Add(this.lblProdName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(25);
            this.Name = "CustOrderMealCont";
            this.Size = new System.Drawing.Size(390, 140);
            this.Load += new System.EventHandler(this.CustOrderMealCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PAL.CircleButtons btnPlus;
        private PAL.CircleButtons btnMinus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.PictureBox pbProdImage;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnAdd;
    }
}
