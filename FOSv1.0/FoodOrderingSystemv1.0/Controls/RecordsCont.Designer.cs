
namespace FoodOrderingSystemv1._0.Controls
{
    partial class RecordsCont
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
            this.geRecords = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblCellNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.SuspendLayout();
            // 
            // geRecords
            // 
            this.geRecords.BorderRadius = 30;
            this.geRecords.TargetControl = this;
            // 
            // lblCellNo
            // 
            this.lblCellNo.AutoSize = true;
            this.lblCellNo.BackColor = System.Drawing.Color.Transparent;
            this.lblCellNo.Location = new System.Drawing.Point(895, 21);
            this.lblCellNo.Name = "lblCellNo";
            this.lblCellNo.Size = new System.Drawing.Size(106, 21);
            this.lblCellNo.TabIndex = 7;
            this.lblCellNo.Text = "Cell Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(595, 21);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 21);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(221, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(57, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 21);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.Location = new System.Drawing.Point(806, 11);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(10, 43);
            this.guna2VSeparator3.TabIndex = 11;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(420, 11);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 43);
            this.guna2VSeparator2.TabIndex = 12;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(136, 11);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 43);
            this.guna2VSeparator1.TabIndex = 13;
            // 
            // RecordsCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.guna2VSeparator3);
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.lblCellNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RecordsCont";
            this.Size = new System.Drawing.Size(1058, 65);
            this.Load += new System.EventHandler(this.RecordsCont_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse geRecords;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label lblCellNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
    }
}
