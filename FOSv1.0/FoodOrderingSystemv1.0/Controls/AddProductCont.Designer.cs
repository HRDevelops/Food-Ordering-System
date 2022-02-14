
namespace FoodOrderingSystemv1._0.Controls
{
    partial class AddProductCont
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(259, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 23);
            this.tbName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 121);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(126, 506);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 54);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(48, 153);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(153, 20);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Product Description";
            this.lblDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(259, 246);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(191, 23);
            this.tbPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(48, 249);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Product Price";
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.btnBrowse);
            this.gbPicture.Controls.Add(this.pictureBox1);
            this.gbPicture.Location = new System.Drawing.Point(126, 292);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(191, 186);
            this.gbPicture.TabIndex = 8;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(6, 149);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(179, 31);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(259, 107);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(191, 96);
            this.rtbDesc.TabIndex = 10;
            this.rtbDesc.Text = "";
            // 
            // AddProductCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.gbPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProductCont";
            this.Size = new System.Drawing.Size(500, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPicture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox rtbDesc;
    }
}
